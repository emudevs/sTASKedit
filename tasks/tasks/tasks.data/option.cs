//(c)Rey35
using System.IO;

namespace tasks
{
	public class option
	{
		public int crypt_key;
		public int param;
		public short[] text = new short[64];
		public int id;
		public string optiontext
		{
			get
			{
				return tasksConvert.decrypt(this.crypt_key, this.text);
			}
			set
			{
				this.text = tasksConvert.encrypt(this.crypt_key, value, 64, false);
			}
		}

		internal static void Read(int version, BinaryReader br, option option)
		{
			option.param = br.ReadInt32();
			option.text = GlobalFunctions.ReadNameChars(64, br);
			option.id = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, option option)
		{
			bw.Write(option.param);
			GlobalFunctions.WriteNameChars(bw, option.text);
			bw.Write(option.id);
		}
	}
}
//(c)Rey35