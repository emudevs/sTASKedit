//(c)Rey35
using System;
using System.Text;

namespace tasks
{
	public class tasksConvert
	{
		public static string decrypt(int key, short[] chars)
		{
			short[] tmp = new short[chars.Length];
			string result = "";
			for (int i = 0; i < chars.Length; i++)
			{
				tmp[i] = chars[i];
				if (GlobalData.version >= 52)
					tmp[i] ^= (short)key;
				result += (char)tmp[i];
			}
			return result.Split('\0')[0];
		}
		public static short[] encrypt(int key, string text, int length, bool appendZero)
		{
			short[] result;
			result = new short[length + Convert.ToByte(appendZero)];
			for (int i = 0; i < result.Length; i++)
			{
				if (i < text.Length)
					result[i] = (short)Convert.ToChar(text.Substring(i, 1));
				if (GlobalData.version >= 52)
					result[i] ^= (short)key;
			}
			return result;
		}

		public static string BytesToHexString(byte[] value)
		{
			return BitConverter.ToString(value);
		}
		public static byte[] HexStringToBytes(string value)
		{
			char[] chArray = new char[]
			{
				'-'
			};
			string[] strArray = value.Split(chArray);
			byte[] numArray = new byte[strArray.Length];
			for (int index = 0; index < strArray.Length; index++)
				numArray[index] = Convert.ToByte(strArray[index], 16);
			return numArray;
		}

		public static string BytesToGbkString(byte[] text)
		{
			Encoding encoding = Encoding.GetEncoding("GBK");
			return encoding.GetString(text).Split('\0')[0];
		}
		public static byte[] GbkStringToBytes(string text, int length)
		{
			Encoding encoding = Encoding.GetEncoding("GBK");
			byte[] numArray = new byte[length];
			byte[] bytes = encoding.GetBytes(text);
			if (numArray.Length > bytes.Length)
				Array.Copy(bytes, numArray, bytes.Length);
			else
			{
				byte[] numArray2 = bytes;
				byte[] numArray3 = numArray;
				int length2 = numArray3.Length;
				Array.Copy(numArray2, numArray3, length2);
			}
			return numArray;
		}
		public static byte[] GbkStringToBytes2(string text, int length)
		{
			Encoding enc = Encoding.GetEncoding("GBK");
			byte[] target = new byte[length];
			byte[] source = enc.GetBytes(text);
			if (target.Length > source.Length)
				Array.Copy(source, target, source.Length);
			else
				Array.Copy(source, target, target.Length);
			return target;
		}

		public static string BytesToUnicodeString(byte[] text)
		{
			Encoding encoding = Encoding.GetEncoding("Unicode");
			return encoding.GetString(text).Split('\0')[0];
		}
		public static byte[] UnicodeStringToBytes(string text, int length)
		{
			Encoding encoding = Encoding.GetEncoding("Unicode");
			byte[] numArray = new byte[length];
			byte[] bytes = encoding.GetBytes(text);
			if (numArray.Length > bytes.Length)
				Array.Copy(bytes, numArray, bytes.Length);
			else
			{
				byte[] numArray2 = bytes;
				byte[] numArray3 = numArray;
				int length2 = numArray3.Length;
				Array.Copy(numArray2, numArray3, length2);
			}
			return numArray;
		}
		public static byte[] UnicodeStringToBytes2(string text, int length)
		{
			Encoding enc = Encoding.GetEncoding("Unicode");
			byte[] target = new byte[length];
			byte[] source = enc.GetBytes(text);
			if (target.Length > source.Length)
				Array.Copy(source, target, source.Length);
			else
				Array.Copy(source, target, target.Length);
			return target;
		}

		public static string ShortsToUnicodeString(short[] chars)
		{
			string result = "";
			for (int i = 0; i < chars.Length; i++)
			{
				result += (char)chars[i];
			}
			return result.Split('\0')[0];
		}
		public static short[] UnicodeStringToShorts(string text, int length)
		{
			short[] result = new short[length];
			for (int i = 0; i < result.Length && i < text.Length; i++)
				result[i] = (short)Convert.ToChar(text.Substring(i, 1));
			return result;
		}

		public static string ShortsToGbkString(short[] chars)
		{
			byte[] tmp = new byte[chars.Length * 2];
			for (int i = 0; i < chars.Length; i++)
			{
				byte[] tmp2 = BitConverter.GetBytes(chars[i]);
				tmp[i * 2] = tmp2[0];
				tmp[(i * 2) + 1] = tmp2[1];
			}
			Encoding encoding = Encoding.GetEncoding("GBK");
			return encoding.GetString(tmp).Split('\0')[0];
		}
		public static short[] GbkStringToShorts(string text, int length)
		{
			Encoding encoding = Encoding.GetEncoding("GBK");
			byte[] numArray = new byte[length * 2];
			byte[] bytes = encoding.GetBytes(text);
			Array.Copy(bytes, numArray, bytes.Length);

			short[] result = new short[length];
			for (int i = 0; i < result.Length; i++)
				result[i] = BitConverter.ToInt16(numArray, i * 2);
			return result;
		}

		public static string CharsToString(char[] chars)
		{
			string result = "";
			for (int i = 0; i < chars.Length; i++)
			{
				result += chars[i];
			}
			return result.Split('\0')[0];
		}
		public static char[] StringToChars(string text, int length)
		{
			char[] result = new char[length];
			for (int i = 0; i < result.Length && i < text.Length; i++)
				result[i] = Convert.ToChar(text.Substring(i, 1));
			return result;
		}
	}
}
//(c)Rey35