//(c)Rey35
using System.IO;
using System.Windows.Forms;

namespace tasks
{
	public class ATaskTempl : ATaskTemplFixedData
	{
		public short[] m_pwstrDescript = new short[0];
		public short[] m_pwstrOkText = new short[0];
		public short[] m_pwstrNoText = new short[0];
		public short[] m_pwstrTribute = new short[0];
		public talk_proc m_DelvTaskTalk = new talk_proc();
		public talk_proc m_UnqualifiedTaskTalk = new talk_proc();
		public talk_proc m_DelvItemTalk = new talk_proc();
		public talk_proc m_ExeTalk = new talk_proc();
		public talk_proc m_AwardTalk = new talk_proc();
		public int m_nSubCount { set; get; }
		public ATaskTempl[] pSub = new ATaskTempl[0];

		public int ID
		{
			get
			{
				return this.m_ID;
			}
			set
			{
				string szName = this.Name;
				string pszSignature = this.Signature;
				string pwstrDescript = this.Descript;
				string pwstrOkText = this.OkText;
				string pwstrNoText = this.NoText;
				string pwstrTribute = this.Tribute;
				this.m_ID = value;
				this.Name = szName;
				this.Signature = pszSignature;
				this.Descript = pwstrDescript;
				this.OkText = pwstrOkText;
				this.NoText = pwstrNoText;
				this.Tribute = pwstrTribute;
				Set_talk_proc_Text(this.m_DelvTaskTalk, value);
				Set_talk_proc_Text(this.m_UnqualifiedTaskTalk, value);
				Set_talk_proc_Text(this.m_DelvItemTalk, value);
				Set_talk_proc_Text(this.m_ExeTalk, value);
				Set_talk_proc_Text(this.m_AwardTalk, value);
			}
		}

		public string Descript
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_pwstrDescript);
			}
			set
			{
				value = value.TrimEnd('\0');
				this.m_pwstrDescript = tasksConvert.encrypt(this.m_ID, value, value.Length, false);
			}
		}
		public string OkText
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_pwstrOkText);
			}
			set
			{
				value = value.TrimEnd('\0');
				this.m_pwstrOkText = tasksConvert.encrypt(this.m_ID, value, value.Length, false);
			}
		}
		public string NoText
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_pwstrNoText);
			}
			set
			{
				value = value.TrimEnd('\0');
				this.m_pwstrNoText = tasksConvert.encrypt(this.m_ID, value, value.Length, false);
			}
		}
		public string Tribute
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_pwstrTribute);
			}
			set
			{
				value = value.TrimEnd('\0');
				this.m_pwstrTribute = tasksConvert.encrypt(this.m_ID, value, value.Length, false);
			}
		}
		private void Set_talk_proc_Text(talk_proc talk_proc, int value)
		{
			string DialogText = talk_proc.DialogText;
			talk_proc.crypt_key = value;
			talk_proc.DialogText = DialogText;
			for (int i1 = 0; i1 < talk_proc.windows.Length; i1++)
			{
				string TalkText = talk_proc.windows[i1].talktext;
				talk_proc.windows[i1].crypt_key = value;
				talk_proc.windows[i1].talktext = TalkText;
				for (int i2 = 0; i2 < talk_proc.windows[i1].options.Length; i2++)
				{
					string OptionText = talk_proc.windows[i1].options[i2].optiontext;
					talk_proc.windows[i1].options[i2].crypt_key = value;
					talk_proc.windows[i1].options[i2].optiontext = OptionText;
				}
			}
		}

		public ATaskTempl()
		{
		}
		public ATaskTempl(int version, BinaryReader BinaryStream, int BaseStreamPosition = -1, TreeNodeCollection Nodes = null, int GMIconIndex = 12)
		{
			this.Read(version, BinaryStream, BaseStreamPosition, Nodes, GMIconIndex);
		}

		public ATaskTempl Clone()
		{
			MemoryStream output = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(output);
			BinaryReader binaryStream = new BinaryReader(output);
			this.Write(9999, bw);
			ATaskTempl task = new ATaskTempl(9999, binaryStream, 0, null);
			bw.Close();
			binaryStream.Close();
			output.Close();
			return task;
		}

		public void AddNode(TreeNodeCollection nodes, int GMIconIndex = 12)
		{
			if (nodes != null)
			{
				nodes.Add("");
				GlobalFunctions.UpdateNode(nodes[nodes.Count - 1], this, 0, GMIconIndex);
			}
		}

		private void Read(int version, BinaryReader br, int stream_position, TreeNodeCollection nodes, int GMIconIndex)
		{
			if(stream_position > -1)
				br.BaseStream.Position = (long)stream_position;
			this.ReadATaskTemplFixedData(version, br);
			this.m_pwstrDescript = GlobalFunctions.ReadChars_pwstr(br);
			this.m_pwstrOkText = GlobalFunctions.ReadChars_pwstr(br);
			this.m_pwstrNoText = GlobalFunctions.ReadChars_pwstr(br);
			this.m_pwstrTribute = GlobalFunctions.ReadChars_pwstr(br);
			talk_proc.Read(version, br, this.m_ID, this.m_DelvTaskTalk);
			talk_proc.Read(version, br, this.m_ID, this.m_UnqualifiedTaskTalk);
			talk_proc.Read(version, br, this.m_ID, this.m_DelvItemTalk);
			talk_proc.Read(version, br, this.m_ID, this.m_ExeTalk);
			talk_proc.Read(version, br, this.m_ID, this.m_AwardTalk);
			AddNode(nodes, GMIconIndex);
			if (this.m_ID > GlobalData.NewID) GlobalData.NewID = this.m_ID;
			this.m_nSubCount = br.ReadInt32();
			this.pSub = new ATaskTempl[this.m_nSubCount];
			for (int i = 0; i < this.m_nSubCount; i++)
            {
                if (nodes != null)
				{
					this.pSub[i] = new ATaskTempl(version, br, (int)br.BaseStream.Position, nodes[nodes.Count - 1].Nodes);
				}
				else
				{
					this.pSub[i] = new ATaskTempl(version, br, (int)br.BaseStream.Position, null);
				}
			}
		}

		public void Write(int version, BinaryWriter bw, bool bSaveSubQuests = true)
		{
			this.WriteReadATaskTemplFixedData(version, bw);
			GlobalFunctions.WriteChars_pwstr(bw, this.m_pwstrDescript);
			GlobalFunctions.WriteChars_pwstr(bw, this.m_pwstrOkText);
			GlobalFunctions.WriteChars_pwstr(bw, this.m_pwstrNoText);
			GlobalFunctions.WriteChars_pwstr(bw, this.m_pwstrTribute);
			talk_proc.Write(version, bw, this.m_DelvTaskTalk);
			talk_proc.Write(version, bw, this.m_UnqualifiedTaskTalk);
			talk_proc.Write(version, bw, this.m_DelvItemTalk);
			talk_proc.Write(version, bw, this.m_ExeTalk);
			talk_proc.Write(version, bw, this.m_AwardTalk);
			if(bSaveSubQuests)
			{
				bw.Write(this.m_nSubCount);
				for (int i = 0; i < this.m_nSubCount; i++)
				{
					this.pSub[i].Write(version, bw);
				}
			}
            else
			{
				bw.Write(0);
			}
		}
	}
}
//(c)Rey35
