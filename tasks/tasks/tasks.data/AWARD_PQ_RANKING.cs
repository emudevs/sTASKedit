//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_PQ_RANKING
	{
		public bool m_bAwardByProf;
		public int m_ulRankingAwardNum;
		public RANKING_AWARD[] m_RankingAward = new RANKING_AWARD[0];

		internal static void Read(int version, BinaryReader br, AWARD_PQ_RANKING AWARD_PQ_RANKING)
		{
			AWARD_PQ_RANKING.m_bAwardByProf = br.ReadBoolean();
			AWARD_PQ_RANKING.m_RankingAward = new RANKING_AWARD[AWARD_PQ_RANKING.m_ulRankingAwardNum];
			for (int i = 0; i < AWARD_PQ_RANKING.m_ulRankingAwardNum; i++)
			{
				AWARD_PQ_RANKING.m_RankingAward[i] = new RANKING_AWARD();
				RANKING_AWARD.Read(version, br, AWARD_PQ_RANKING.m_RankingAward[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_PQ_RANKING AWARD_PQ_RANKING)
		{
			bw.Write(AWARD_PQ_RANKING.m_bAwardByProf);
			for (int i = 0; i < AWARD_PQ_RANKING.m_RankingAward.Length; i++)
			{
				RANKING_AWARD.Write(version, bw, AWARD_PQ_RANKING.m_RankingAward[i]);
			}
		}
	}
}
//(c)Rey35