//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_ITEMS_SCALE
	{
		public int m_ulScales;
		public int m_ulItemId;
		public int[] m_Counts = new int[GlobalData.MAX_AWARD_SCALES];
		public AWARD_DATA[] m_Awards = new AWARD_DATA[0];

		internal static void Read(int version, BinaryReader br, AWARD_ITEMS_SCALE AWARD_ITEMS_SCALE)
		{
			AWARD_ITEMS_SCALE.m_ulScales = br.ReadInt32();
			AWARD_ITEMS_SCALE.m_ulItemId = br.ReadInt32();
			int counts_count = GlobalFunctions.GetMaxAwardScales(version);
			for (int i = 0; i < counts_count; i++)
			{
				AWARD_ITEMS_SCALE.m_Counts[i] = br.ReadInt32();
			}
			AWARD_ITEMS_SCALE.m_Awards = new AWARD_DATA[AWARD_ITEMS_SCALE.m_ulScales];
			for (int i = 0; i < AWARD_ITEMS_SCALE.m_ulScales; i++)
			{
				AWARD_ITEMS_SCALE.m_Awards[i] = new AWARD_DATA();
				AWARD_DATA.Read(version, br, AWARD_ITEMS_SCALE.m_Awards[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_ITEMS_SCALE AWARD_ITEMS_SCALE)
		{
			int counts_count = GlobalFunctions.GetMaxAwardScales(version);
			if (AWARD_ITEMS_SCALE.m_ulScales > counts_count)
			{
				bw.Write(counts_count);
			}
			else
			{
				bw.Write(AWARD_ITEMS_SCALE.m_ulScales);
			}
			bw.Write(AWARD_ITEMS_SCALE.m_ulItemId);
			for (int i = 0; i < counts_count; i++)
			{
				bw.Write(AWARD_ITEMS_SCALE.m_Counts[i]);
			}
			for (int i = 0; i < AWARD_ITEMS_SCALE.m_ulScales && i < counts_count; i++)
			{
				AWARD_DATA.Write(version, bw, AWARD_ITEMS_SCALE.m_Awards[i]);
			}
		}
	}
}
//(c)Rey35