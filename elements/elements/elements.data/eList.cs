//(c)Rey35
using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace elements
{
	public class eList
	{
		public eList()
		{
		}

		public string listName;
		public byte[] listOffset;
		public int listType;
		public int elementSize;
		public string[] elementFields;
		public string[] elementTypes;
		public object[][] elementValues;

		public string GetValue(int ElementIndex, int FieldIndex)
		{
			if (FieldIndex > -1)
			{
				object value = elementValues[ElementIndex][FieldIndex];
				string type = elementTypes[FieldIndex];

				if (type == "int16")
				{
					return Convert.ToString((short)value);
				}
				if (type == "int32")
				{
					return Convert.ToString((int)value);
				}
				if (type == "int64")
				{
					return Convert.ToString((long)value);
				}
				if (type == "float")
				{
					return ((float)value).ToString("F6");
				}
				if (type == "double")
				{
					return Convert.ToString((double)value);
				}
				if (type.Contains("byte:"))
				{
					byte[] b = (byte[])value;
					return BitConverter.ToString(b);
				}
				if (type.Contains("wstring:"))
				{
					Encoding enc = Encoding.GetEncoding("Unicode");
					return enc.GetString((byte[])value).Split(new char[] { '\0' })[0];
				}
				if (type.Contains("string:"))
				{
					Encoding enc = Encoding.GetEncoding("GBK");
					return enc.GetString((byte[])value).Split(new char[] { '\0' })[0];
				}
			}
			return "";
		}

		public void SetValue(int ElementIndex, int FieldIndex, string Value)
		{
			string type = elementTypes[FieldIndex];

			if (type == "int16")
			{
				elementValues[ElementIndex][FieldIndex] = Convert.ToInt16(Value);
				return;
			}
			if (type == "int32")
			{
				elementValues[ElementIndex][FieldIndex] = Convert.ToInt32(Value);
				return;
			}
			if (type == "int64")
			{
				elementValues[ElementIndex][FieldIndex] = Convert.ToInt64(Value);
				return;
			}
			if (type == "float")
			{
				elementValues[ElementIndex][FieldIndex] = Convert.ToSingle(Value);
				return;
			}
			if (type == "double")
			{
				elementValues[ElementIndex][FieldIndex] = Convert.ToDouble(Value);
				return;
			}
			if (type.Contains("byte:"))
			{
				string[] hex = Value.Split(new char[] { '-' });
				byte[] b = new byte[Convert.ToInt32(type.Substring(5))];
				for (int i = 0; i < hex.Length; i++)
				{
					b[i] = Convert.ToByte(hex[i], 16);
				}
				elementValues[ElementIndex][FieldIndex] = b;
				return;
			}
			if (type.Contains("wstring:"))
			{
				Encoding enc = Encoding.GetEncoding("Unicode");
				byte[] target = new byte[Convert.ToInt32(type.Substring(8))];
				byte[] source = enc.GetBytes(Value);
				if (target.Length > source.Length)
				{
					Array.Copy(source, target, source.Length);
				}
				else
				{
					Array.Copy(source, target, target.Length);
				}
				elementValues[ElementIndex][FieldIndex] = target;
				return;
			}
			if (type.Contains("string:"))
			{
				Encoding enc = Encoding.GetEncoding("GBK");
				byte[] target = new byte[Convert.ToInt32(type.Substring(7))];
				byte[] source = enc.GetBytes(Value);
				if (target.Length > source.Length)
				{
					Array.Copy(source, target, source.Length);
				}
				else
				{
					Array.Copy(source, target, target.Length);
				}
				elementValues[ElementIndex][FieldIndex] = target;
				return;
			}
			return;
		}

		public string GetType(int FieldIndex)
		{
			if (FieldIndex > -1)
			{
				return elementTypes[FieldIndex];
			}
			return "";
		}

		public void RemoveItem(int itemIndex)
		{
			object[][] newValues = new object[elementValues.Length - 1][];
			Array.Copy(elementValues, 0, newValues, 0, itemIndex);
			int length = newValues.Length - itemIndex;
			Array.Copy(elementValues, itemIndex + 1, newValues, itemIndex, newValues.Length - itemIndex);
			elementValues = newValues;
		}

		public void AddItem(object[] itemValues)
		{
			object[][] newValues = new object[elementValues.Length + 1][];
			Array.Resize(ref elementValues, elementValues.Length + 1);
			elementValues[elementValues.Length - 1] = itemValues;
		}

		public void ExportItem(string file, int index)
		{
			StreamWriter sw = new StreamWriter(file, false, Encoding.Unicode);
			for (int i = 0; i < elementTypes.Length; i++)
			{
				sw.WriteLine(elementFields[i] + "(" + elementTypes[i] + ")=\"" + GetValue(index, i) + "\"");
			}
			sw.Close();
		}

		public void ImportItem(string file, int index)
		{
			StreamReader sr = new StreamReader(file, Encoding.Unicode);
			for (int i = 0; i < elementTypes.Length; i++)
			{
				string field = sr.ReadLine();
				if (!field.StartsWith("#") && !field.StartsWith("//") && field != "")
				{
					string value = field.Substring(field.IndexOf("\"") + 1);
					int valueLength = value.IndexOf("\"");
					if (valueLength > -1)
						value = value.Substring(0, valueLength);
					else
					{
						int nextValueLineLength = -1;
						string nextValueLine = "";
						do
						{
							value += nextValueLine;
							nextValueLine = "\r\n" + sr.ReadLine();
							nextValueLineLength = nextValueLine.IndexOf("\"");
						} while (nextValueLineLength < 0);
						value += nextValueLine.Substring(0, nextValueLineLength);
					}
					SetValue(index, i, value);
				}
			}
			sr.Close();
		}

		public ArrayList JoinElements(eList newList, int listID, bool addNew, bool backupNew, bool replaceChanged, bool backupChanged, bool removeMissing, bool backupMissing, string dirBackupNew, string dirBackupChanged, string dirBackupMissing)
		{
			object[][] newElementValues = newList.elementValues;
			string[] newElementTypes = newList.elementTypes;

			ArrayList report = new ArrayList();
			bool exists;

			for (int n = 0; n < elementValues.Length; n++)
			{
				Application.DoEvents();
				exists = false;
				for (int e = 0; e < newElementValues.Length; e++)
				{
					if (this.GetValue(n, 0) == newList.GetValue(e, 0))
					{
						exists = true;
					}
				}
				if (!exists)
				{
					if (dirBackupMissing != null && Directory.Exists(dirBackupMissing))
					{
						ExportItem(dirBackupMissing + "\\List_" + listID.ToString() + "_Item_" + this.GetValue(n, 0) + ".txt", n);
					}
					if (removeMissing)
					{
						report.Add("- MISSING ITEM (*removed): " + ((int)elementValues[n][0]).ToString());
						RemoveItem(n);
						n--;
					}
					else
					{
						report.Add("- MISSING ITEM (*not removed): " + ((int)elementValues[n][0]).ToString());
					}
				}
			}

			for (int e = 0; e < newElementValues.Length; e++)
			{
				Application.DoEvents();
				exists = false;
				for (int n = 0; n < elementValues.Length; n++)
				{
					if (this.GetValue(n, 0) == newList.GetValue(e, 0))
					{
						exists = true;
						if (this.elementValues[n].Length != newList.elementValues[e].Length)
						{
							report.Add("<> DIFFERENT ITEM (*not replaced, invalid amount of values): " + this.GetValue(n, 0));
						}
						else
						{
							for (int i = 0; i < this.elementValues[n].Length; i++)
							{
								if (this.GetValue(n, i) != newList.GetValue(e, i))
								{
									if (backupChanged && Directory.Exists(dirBackupChanged))
									{
										ExportItem(dirBackupChanged + "\\List_" + listID.ToString() + "_Item_" + this.GetValue(n, 0) + ".txt", n);
									}
									if (replaceChanged)
									{
										report.Add("<> DIFFERENT ITEM (*replaced): " + this.GetValue(n, 0));
										elementValues[n] = newList.elementValues[e];
									}
									else
									{
										report.Add("<> DIFFERENT ITEM (*not replaced): " + this.GetValue(n, 0));
									}
									break;
								}
							}
						}
						break;
					}
				}
				if (!exists)
				{
					if (backupNew && Directory.Exists(dirBackupNew))
					{
						newList.ExportItem(dirBackupNew + "\\List_" + listID.ToString() + "_Item_" + newList.GetValue(e, 0) + ".txt", e);
					}
					if (addNew)
					{
						AddItem(newElementValues[e]);
						report.Add("+ NEW ITEM (*added): " + this.GetValue(elementValues.Length - 1, 0));
					}
					else
					{
						report.Add("+ NEW ITEM (*not added): " + this.GetValue(elementValues.Length - 1, 0));
					}
				}
			}

			return report;
		}
	}
}
//(c)Rey35
