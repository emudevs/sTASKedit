//(c)Rey35
using System;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace elements
{
	public class eListCollection
	{
		public eListCollection(string elFile, string ConfigsPath, string ErrorMsg, ProgressBar progressBar_Progress, ToolStripProgressBar toolStripProgressBar_Progress, int AdditionalProgBarMaxValue = 0)
		{
			Lists = Load(elFile, ConfigsPath, ErrorMsg, progressBar_Progress, toolStripProgressBar_Progress, AdditionalProgBarMaxValue);
		}
		public short Version;
		public short Signature;
		public int ConversationListIndex;
		public string ConfigFile;
		public eList[] Lists;
		public talk_proc[] talk_procs;

		public void RemoveItem(int ListIndex, int ElementIndex)
		{
			Lists[ListIndex].RemoveItem(ElementIndex);
		}
		public void AddItem(int ListIndex, object[] ItemValues)
		{
			Lists[ListIndex].AddItem(ItemValues);
		}
		public string GetOffset(int ListIndex)
		{
			return BitConverter.ToString(Lists[ListIndex].listOffset);
		}

		public void SetOffset(int ListIndex, string Offset)
		{
			if (Offset != "")
			{
				string[] hex = Offset.Split(new char[] { '-' });
				Lists[ListIndex].listOffset = new byte[hex.Length];
				for (int i = 0; i < hex.Length; i++)
				{
					Lists[ListIndex].listOffset[i] = Convert.ToByte(hex[i], 16);
				}
			}
			else
			{
				Lists[ListIndex].listOffset = new byte[0];
			}
		}

		public string GetValue(int ListIndex, int ElementIndex, int FieldIndex)
		{
			return Lists[ListIndex].GetValue(ElementIndex, FieldIndex);
		}

		public void SetValue(int ListIndex, int ElementIndex, int FieldIndex, string Value)
		{
			Lists[ListIndex].SetValue(ElementIndex, FieldIndex, Value);
		}

		public string GetType(int ListIndex, int FieldIndex)
		{
			return Lists[ListIndex].GetType(FieldIndex);
		}

		private object readValue(BinaryReader br, string type)
		{
			if (type == "int16")
			{
				return br.ReadInt16();
			}
			if (type == "int32")
			{
				return br.ReadInt32();
			}
			if (type == "int64")
			{
				return br.ReadInt64();
			}
			if (type == "float")
			{
				return br.ReadSingle();
			}
			if (type == "double")
			{
				return br.ReadDouble();
			}
			if (type.Contains("byte:"))
			{
				return br.ReadBytes(Convert.ToInt32(type.Substring(5)));
			}
			if (type.Contains("wstring:"))
			{
				return br.ReadBytes(Convert.ToInt32(type.Substring(8)));
			}
			if (type.Contains("string:"))
			{
				return br.ReadBytes(Convert.ToInt32(type.Substring(7)));
			}
			return null;
		}

		private void writeValue(BinaryWriter bw, object value, string type)
		{
			if (type == "int16")
			{
				bw.Write((short)value);
				return;
			}
			if (type == "int32")
			{
				bw.Write((int)value);
				return;
			}
			if (type == "int64")
			{
				bw.Write((long)value);
				return;
			}
			if (type == "float")
			{
				bw.Write((float)value);
				return;
			}
			if (type == "double")
			{
				bw.Write((double)value);
				return;
			}
			if (type.Contains("byte:"))
			{
				bw.Write((byte[])value);
				return;
			}
			if (type.Contains("wstring:"))
			{
				bw.Write((byte[])value);
				return;
			}
			if (type.Contains("string:"))
			{
				bw.Write((byte[])value);
				return;
			}
		}

		private eList[] loadConfiguration(string file)
		{
			StreamReader sr = new StreamReader(file);
			eList[] Li = new eList[Convert.ToInt32(sr.ReadLine())];
			try
			{
				ConversationListIndex = Convert.ToInt32(sr.ReadLine());
			}
			catch
			{
				ConversationListIndex = 58;
			}
			string line;
			for (int i = 0; i < Li.Length; i++)
			{
				Application.DoEvents();

				while ((line = sr.ReadLine()) == "")
				{
				}
				Li[i] = new eList();
				Li[i].listName = line;
				Li[i].listOffset = null;
				string offset = sr.ReadLine();
				if (offset != "AUTO")
				{
					Li[i].listOffset = new byte[Convert.ToInt32(offset)];
				}
				Li[i].elementFields = sr.ReadLine().Split(new char[] { ';' });
				Li[i].elementTypes = sr.ReadLine().Split(new char[] { ';' });
			}
			sr.Close();

			return Li;
		}

		private Hashtable loadRules(string file)
		{
			StreamReader sr = new StreamReader(file);
			Hashtable result = new Hashtable();
			string key = "";
			string value = "";
			string line;
			while (!sr.EndOfStream)
			{
				line = sr.ReadLine();
				Application.DoEvents();

				if (line != "" && !line.StartsWith("#"))
				{
					if (line.Contains("|"))
					{
						key = line.Split(new char[] { '|' })[0];
						value = line.Split(new char[] { '|' })[1];
					}
					else
					{
						key = line;
						value = "";
					}
					result.Add(key, value);
				}
			}
			sr.Close();

			if (!result.ContainsKey("SETCONVERSATIONLISTINDEX"))
				result.Add("SETCONVERSATIONLISTINDEX", "58");

			return result;
		}

		public eList[] Load(string elFile, string ConfigsPath, string ErrorMsg, ProgressBar progressBar_Progress, ToolStripProgressBar toolStripProgressBar_Progress, int AdditionalProgBarMaxValue)
		{
			eList[] Li = new eList[0];

			FileStream fs = File.OpenRead(elFile);
			BinaryReader br = new BinaryReader(fs);

			Version = br.ReadInt16();
			Signature = br.ReadInt16();

			string[] configFiles = Directory.GetFiles(ConfigsPath, "PW_*_v" + Version + ".cfg");
			if (configFiles.Length > 0)
			{
				ConfigFile = configFiles[0];
				Li = loadConfiguration(ConfigFile);
				if (progressBar_Progress != null)
				{
					progressBar_Progress.Maximum = Li.Length + AdditionalProgBarMaxValue;
					progressBar_Progress.Value = 0;
				}
				if (toolStripProgressBar_Progress != null)
				{
					toolStripProgressBar_Progress.Maximum = Li.Length + AdditionalProgBarMaxValue;
					toolStripProgressBar_Progress.Value = 0;
				}

				for (int l = 0; l < Li.Length; l++)
				{
					Application.DoEvents();

					if (Li[l].listOffset != null)
					{
						if (Li[l].listOffset.Length > 0)
						{
							Li[l].listOffset = br.ReadBytes(Li[l].listOffset.Length);
						}
					}
					else
					{
						if (l == 0)
						{
							byte[] t = br.ReadBytes(4);
							byte[] len = br.ReadBytes(4);
							byte[] buffer = br.ReadBytes(BitConverter.ToInt32(len, 0));
							Li[l].listOffset = new byte[t.Length + len.Length + buffer.Length];
							Array.Copy(t, 0, Li[l].listOffset, 0, t.Length);
							Array.Copy(len, 0, Li[l].listOffset, 4, len.Length);
							Array.Copy(buffer, 0, Li[l].listOffset, 8, buffer.Length);
						}
						if (l == 20)
						{
							byte[] tag = br.ReadBytes(4);
							byte[] len = br.ReadBytes(4);
							byte[] buffer = br.ReadBytes(BitConverter.ToInt32(len, 0));
							byte[] t = br.ReadBytes(4);
							Li[l].listOffset = new byte[tag.Length + len.Length + buffer.Length + t.Length];
							Array.Copy(tag, 0, Li[l].listOffset, 0, tag.Length);
							Array.Copy(len, 0, Li[l].listOffset, 4, len.Length);
							Array.Copy(buffer, 0, Li[l].listOffset, 8, buffer.Length);
							Array.Copy(t, 0, Li[l].listOffset, 8 + buffer.Length, t.Length);
						}
						int NPC_WAR_TOWERBUILD_SERVICE_index = 100;
						if (Version >= 191)
							NPC_WAR_TOWERBUILD_SERVICE_index = 99;
						if (l == NPC_WAR_TOWERBUILD_SERVICE_index)
						{
							byte[] tag = br.ReadBytes(4);
							byte[] len = br.ReadBytes(4);
							byte[] buffer = br.ReadBytes(BitConverter.ToInt32(len, 0));
							Li[l].listOffset = new byte[tag.Length + len.Length + buffer.Length];
							Array.Copy(tag, 0, Li[l].listOffset, 0, tag.Length);
							Array.Copy(len, 0, Li[l].listOffset, 4, len.Length);
							Array.Copy(buffer, 0, Li[l].listOffset, 8, buffer.Length);
						}
					}
					if (l == ConversationListIndex)
					{
						Li[l].elementValues = new object[0][];
						talk_procs = new talk_proc[br.ReadInt32()];
						for (int ti = 0; ti < talk_procs.Length; ti++)
						{
							talk_procs[ti] = new talk_proc();
							talk_procs[ti].id_talk = br.ReadInt32();
							talk_procs[ti].text = br.ReadBytes(128);
							talk_procs[ti].num_window = br.ReadInt32();
							talk_procs[ti].windows = new window[talk_procs[ti].num_window];
							for (int wi = 0; wi < talk_procs[ti].num_window; wi++)
							{
								talk_procs[ti].windows[wi] = new window();
								talk_procs[ti].windows[wi].id = br.ReadInt32();
								talk_procs[ti].windows[wi].id_parent = br.ReadInt32();
								talk_procs[ti].windows[wi].talk_text_len = br.ReadInt32();
								talk_procs[ti].windows[wi].talk_text = br.ReadBytes(2 * talk_procs[ti].windows[wi].talk_text_len);
								talk_procs[ti].windows[wi].num_option = br.ReadInt32();
								talk_procs[ti].windows[wi].options = new option[talk_procs[ti].windows[wi].num_option];
								for (int oi = 0; oi < talk_procs[ti].windows[wi].num_option; oi++)
								{
									talk_procs[ti].windows[wi].options[oi] = new option();
									talk_procs[ti].windows[wi].options[oi].param = br.ReadInt32();
									talk_procs[ti].windows[wi].options[oi].text = br.ReadBytes(128);
									talk_procs[ti].windows[wi].options[oi].id = br.ReadInt32();
								}
							}
						}
					}
					else
					{
						if (Version >= 191)
							Li[l].listType = br.ReadInt32();
						Li[l].elementValues = new object[br.ReadInt32()][];
						if (Version >= 191)
							Li[l].elementSize = br.ReadInt32();
						for (int e = 0; e < Li[l].elementValues.Length; e++)
						{
							Li[l].elementValues[e] = new object[Li[l].elementTypes.Length];
							for (int f = 0; f < Li[l].elementValues[e].Length; f++)
							{
								Li[l].elementValues[e][f] = readValue(br, Li[l].elementTypes[f]);
							}
						}
					}
					if (progressBar_Progress != null)
						progressBar_Progress.Value++;
					if (toolStripProgressBar_Progress != null)
						toolStripProgressBar_Progress.Value++;
				}
			}
			else
			{
				MessageBox.Show(String.Format(ErrorMsg, Version, Version));
			}

			br.Close();
			fs.Close();

			return Li;
		}

		public void Save(string elFile)
		{
			if (File.Exists(elFile))
			{
				File.Delete(elFile);
			}

			FileStream fs = new FileStream(elFile, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			bw.Write(Version);
			bw.Write(Signature);

			for (int l = 0; l < Lists.Length; l++)
			{
				Application.DoEvents();

				if (Lists[l].listOffset.Length > 0)
				{
					bw.Write(Lists[l].listOffset);
				}

				if (l != ConversationListIndex)
				{
					if (Version >= 191)
						bw.Write(Lists[l].listType);
					bw.Write(Lists[l].elementValues.Length);
					if (Version >= 191)
						bw.Write(Lists[l].elementSize);
					for (int e = 0; e < Lists[l].elementValues.Length; e++)
					{
						for (int f = 0; f < Lists[l].elementValues[e].Length; f++)
						{
							writeValue(bw, Lists[l].elementValues[e][f], Lists[l].elementTypes[f]);
						}
					}
				}
				else
				{
					bw.Write(talk_procs.Length);
					for (int ti = 0; ti < talk_procs.Length; ti++)
					{
						bw.Write(talk_procs[ti].id_talk);
						bw.Write(talk_procs[ti].text);
						bw.Write(talk_procs[ti].num_window);
						for (int wi = 0; wi < talk_procs[ti].num_window; wi++)
						{
							bw.Write(talk_procs[ti].windows[wi].id);
							bw.Write(talk_procs[ti].windows[wi].id_parent);
							bw.Write(talk_procs[ti].windows[wi].talk_text_len);
							bw.Write(talk_procs[ti].windows[wi].talk_text);
							bw.Write(talk_procs[ti].windows[wi].num_option);
							for (int oi = 0; oi < talk_procs[ti].windows[wi].num_option; oi++)
							{
								bw.Write(talk_procs[ti].windows[wi].options[oi].param);
								bw.Write(talk_procs[ti].windows[wi].options[oi].text);
								bw.Write(talk_procs[ti].windows[wi].options[oi].id);
							}
						}
					}
				}
			}
			bw.Close();
			fs.Close();
		}

		public void Export(string RulesFile, string TargetFile)
		{
			Hashtable rules = loadRules(RulesFile);


			if (File.Exists(TargetFile))
			{
				File.Delete(TargetFile);
			}

			FileStream fs = new FileStream(TargetFile, FileMode.Create, FileAccess.Write);
			BinaryWriter bw = new BinaryWriter(fs);

			if (rules.ContainsKey("SETVERSION"))
			{
				bw.Write(Convert.ToInt16((string)rules["SETVERSION"]));
			}
			else
			{
				MessageBox.Show("Rules file is missing parameter\n\nSETVERSION:", "Export Failed");
				bw.Close();
				fs.Close();
				return;
			}

			if (rules.ContainsKey("SETSIGNATURE"))
			{
				bw.Write(Convert.ToInt16((string)rules["SETSIGNATURE"]));
			}
			else
			{
				MessageBox.Show("Rules file is missing parameter\n\nSETSIGNATURE:", "Export Failed");
				bw.Close();
				fs.Close();
				return;
			}
			for (int l = 0; l < Lists.Length; l++)
			{
				if (Convert.ToInt16((string)rules["SETCONVERSATIONLISTINDEX"]) == l)
				{
					for (int e = 0; e < Lists[ConversationListIndex].elementValues.Length; e++)
					{
						for (int f = 0; f < Lists[ConversationListIndex].elementValues[e].Length; f++)
						{
							Application.DoEvents();

							writeValue(bw, Lists[ConversationListIndex].elementValues[e][f], Lists[ConversationListIndex].elementTypes[f]);
						}
					}
				}
				if (l != ConversationListIndex)
				{
					if (!rules.ContainsKey("REMOVELIST:" + l))
					{

						if (rules.ContainsKey("REPLACEOFFSET:" + l))
						{
							string[] hex = ((string)rules["REPLACEOFFSET:" + l]).Split(new char[] { '-', ' ' });
							if (hex.Length > 1)
							{
								byte[] b = new byte[hex.Length];
								for (int i = 0; i < hex.Length; i++)
								{
									b[i] = Convert.ToByte(hex[i], 16);
								}
								if (b.Length > 0)
								{
									bw.Write(b);
								}
							}
						}
						else
						{
							if (Lists[l].listOffset.Length > 0)
							{
								bw.Write(Lists[l].listOffset);
							}
						}

						if (Convert.ToInt16((string)rules["SETVERSION"]) >= 191)
						{
							bw.Write(Lists[l].listType);
						}

						bw.Write(Lists[l].elementValues.Length);

						if (Convert.ToInt16((string)rules["SETVERSION"]) >= 191)
						{
							bw.Write(Lists[l].elementSize);
						}

						for (int e = 0; e < Lists[l].elementValues.Length; e++)
						{
							for (int f = 0; f < Lists[l].elementValues[e].Length; f++)
							{
								Application.DoEvents();

								if (!rules.ContainsKey("REMOVEVALUE:" + l + ":" + f))
								{
									writeValue(bw, Lists[l].elementValues[e][f], Lists[l].elementTypes[f]);
								}
							}
						}
					}
				}
			}
			bw.Close();
			fs.Close();
		}
	}
}
//(c)Rey35
