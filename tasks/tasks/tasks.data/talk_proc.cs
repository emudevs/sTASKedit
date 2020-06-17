//(c)Rey35
using System.IO;

namespace tasks
{
	public class talk_proc
	{
		public int crypt_key;
		public int id_talk;
		public short[] text = new short[64];
		public int num_window;
		public window[] windows = new window[0];
		public string DialogText
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

		internal static void Read(int version, BinaryReader br, int Id , talk_proc talk_proc)
		{
			talk_proc.crypt_key = Id;
			talk_proc.id_talk = br.ReadInt32();
			talk_proc.text = GlobalFunctions.ReadNameChars(64, br);
			talk_proc.num_window = br.ReadInt32();
			talk_proc.windows = new window[talk_proc.num_window];
			for (int i = 0; i < talk_proc.num_window; i++)
			{
				talk_proc.windows[i] = new window();
				talk_proc.windows[i].crypt_key = talk_proc.crypt_key;
				window.Read(version, br, talk_proc.windows[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, talk_proc talk_proc)
		{
			bw.Write(talk_proc.id_talk);
			GlobalFunctions.WriteNameChars(bw, talk_proc.text);
			bw.Write(talk_proc.num_window);
			for (int i = 0; i < talk_proc.num_window; i++)
			{
				window.Write(version, bw, talk_proc.windows[i]);
			}
		}
	}
}
//(c)Rey35