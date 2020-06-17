//(c)Rey35
using System.IO;

namespace tasks
{
	public class window
	{
		public int crypt_key;
		public int id;
		public int id_parent;
		public int talk_text_len;
		public short[] talk_text = new short[0];
		public int num_option;
		public option[] options = new option[0];
		public string talktext
		{
			get
			{
				return tasksConvert.decrypt(this.crypt_key, this.talk_text);
			}
			set
			{
				value = value.TrimEnd('\0');
				this.talk_text = tasksConvert.encrypt(this.crypt_key, value, value.Length , true);
				this.talk_text_len = this.talk_text.Length;
			}
		}

		internal static void Read(int version, BinaryReader br, window window)
		{
			window.id = br.ReadInt32();
			window.id_parent = br.ReadInt32();
			window.talk_text_len = br.ReadInt32();
			window.talk_text = GlobalFunctions.ReadNameChars(window.talk_text_len, br);
			window.num_option = br.ReadInt32();
			window.options = new option[window.num_option];
			for (int i = 0; i < window.num_option; i++)
			{
				window.options[i] = new option();
				window.options[i].crypt_key = window.crypt_key;
				option.Read(version, br, window.options[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, window window)
		{
			bw.Write(window.id);
			bw.Write(window.id_parent);
			bw.Write(window.talk_text_len);
			GlobalFunctions.WriteNameChars(bw, window.talk_text);
			bw.Write(window.num_option);
			for (int i = 0; i < window.num_option; i++)
			{
				option.Write(version, bw, window.options[i]);
			}
		}
	}
}
//(c)Rey35