//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_ITEMS_CAND
	{
		public int m_ulAwardItems;
		public int m_ulAwardCmnItems;
		public int m_ulAwardTskItems;
		public ITEM_WANTED[] m_AwardItems = new ITEM_WANTED[0];
		public bool m_bRandChoose;

		internal static void Read(int version, BinaryReader br, AWARD_ITEMS_CAND AWARD_ITEMS_CAND)
		{
			AWARD_ITEMS_CAND.m_bRandChoose = br.ReadBoolean();
			AWARD_ITEMS_CAND.m_ulAwardItems = br.ReadInt32();
			AWARD_ITEMS_CAND.m_AwardItems = new ITEM_WANTED[AWARD_ITEMS_CAND.m_ulAwardItems];
			for (int i = 0; i < AWARD_ITEMS_CAND.m_ulAwardItems; i++)
			{
				AWARD_ITEMS_CAND.m_AwardItems[i] = new ITEM_WANTED();
				ITEM_WANTED.Read(version, br, AWARD_ITEMS_CAND.m_AwardItems[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_ITEMS_CAND AWARD_ITEMS_CAND)
		{
			bw.Write(AWARD_ITEMS_CAND.m_bRandChoose);
			bw.Write(AWARD_ITEMS_CAND.m_ulAwardItems);
			for (int i = 0; i < AWARD_ITEMS_CAND.m_ulAwardItems; i++)
			{
				ITEM_WANTED.Write(version, bw, AWARD_ITEMS_CAND.m_AwardItems[i]);
			}
		}
	}
}
//(c)Rey35