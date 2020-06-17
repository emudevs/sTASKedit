//(c)Rey35
using System.IO;

namespace tasks
{
	public class TITLE_AWARD
	{
		public int m_ulTitleID;
		public int m_lPeriod;

		internal static void Read(int version, BinaryReader br, TITLE_AWARD TITLE_AWARD)
		{
			TITLE_AWARD.m_ulTitleID = br.ReadInt32();
			TITLE_AWARD.m_lPeriod = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, TITLE_AWARD TITLE_AWARD)
		{
			bw.Write(TITLE_AWARD.m_ulTitleID);
			bw.Write(TITLE_AWARD.m_lPeriod);
		}
	}
}
//(c)Rey35