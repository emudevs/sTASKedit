//(c)Rey35
using System.IO;

namespace tasks
{
	public class TEAM_MEM_WANTED
	{
		public int m_ulLevelMin = 1;
		public int m_ulLevelMax = 150;
		public int m_ulRace;
		public int m_ulOccupation = -1;
		public int m_ulGender;
		public int m_ulMinCount = 1;
		public int m_ulMaxCount = 5;
		public int m_ulTask;
		public int m_iForce;
        public short TeamMemTaskSpace;

		internal static void Read(int version, BinaryReader br, TEAM_MEM_WANTED TEAM_MEM_WANTED)
		{
			TEAM_MEM_WANTED.m_ulLevelMin = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulLevelMax = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulRace = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulOccupation = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulGender = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulMinCount = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulMaxCount = br.ReadInt32();
			TEAM_MEM_WANTED.m_ulTask = br.ReadInt32();
			if (version >= 97)
			{
				TEAM_MEM_WANTED.m_iForce = br.ReadInt32();
			}
			if (version >= 153)
			{
				TEAM_MEM_WANTED.TeamMemTaskSpace = br.ReadInt16();
			}
		}

		internal static void Write(int version, BinaryWriter bw, TEAM_MEM_WANTED TEAM_MEM_WANTED)
		{
			bw.Write(TEAM_MEM_WANTED.m_ulLevelMin);
			bw.Write(TEAM_MEM_WANTED.m_ulLevelMax);
			bw.Write(TEAM_MEM_WANTED.m_ulRace);
			bw.Write(TEAM_MEM_WANTED.m_ulOccupation);
			bw.Write(TEAM_MEM_WANTED.m_ulGender);
			bw.Write(TEAM_MEM_WANTED.m_ulMinCount);
			bw.Write(TEAM_MEM_WANTED.m_ulMaxCount);
			bw.Write(TEAM_MEM_WANTED.m_ulTask);
			if (version >= 97)
			{
				bw.Write(TEAM_MEM_WANTED.m_iForce);
			}
			if (version >= 153)
			{
				bw.Write(TEAM_MEM_WANTED.TeamMemTaskSpace);
			}
		}
	}
}
//(c)Rey35