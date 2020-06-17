//(c)Rey35
using System.IO;

namespace tasks
{
	public class RANKING_AWARD
	{
		public int m_iRankingStart;
		public int m_iRankingEnd;
		public bool m_bCommonItem = true;
		public int m_ulAwardItemId;
		public int m_ulAwardItemNum = 1;
		public int m_lPeriod;

		internal static void Read(int version, BinaryReader br, RANKING_AWARD RANKING_AWARD)
		{
			RANKING_AWARD.m_iRankingStart = br.ReadInt32();
			RANKING_AWARD.m_iRankingEnd = br.ReadInt32();
			RANKING_AWARD.m_bCommonItem = br.ReadBoolean();
			RANKING_AWARD.m_ulAwardItemId = br.ReadInt32();
			RANKING_AWARD.m_ulAwardItemNum = br.ReadInt32();
			RANKING_AWARD.m_lPeriod = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, RANKING_AWARD PLAYER_WANTED)
		{
			bw.Write(PLAYER_WANTED.m_iRankingStart);
			bw.Write(PLAYER_WANTED.m_iRankingEnd);
			bw.Write(PLAYER_WANTED.m_bCommonItem);
			bw.Write(PLAYER_WANTED.m_ulAwardItemId);
			bw.Write(PLAYER_WANTED.m_ulAwardItemNum);
			bw.Write(PLAYER_WANTED.m_lPeriod);
		}
	}
}
//(c)Rey35