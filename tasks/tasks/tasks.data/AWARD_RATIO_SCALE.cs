//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_RATIO_SCALE
	{
		public int m_ulScales;
		public float[] m_Ratios = new float[GlobalData.MAX_AWARD_SCALES];
		public AWARD_DATA[] m_Awards = new AWARD_DATA[0];

		internal static void Read(int version, BinaryReader br, AWARD_RATIO_SCALE AWARD_RATIO_SCALE)
		{
			AWARD_RATIO_SCALE.m_ulScales = br.ReadInt32();
			int ratios_count = GlobalFunctions.GetMaxAwardScales(version);
			for (int i = 0; i < ratios_count; i++)
			{
				AWARD_RATIO_SCALE.m_Ratios[i] = br.ReadSingle();
			}
			AWARD_RATIO_SCALE.m_Awards = new AWARD_DATA[AWARD_RATIO_SCALE.m_ulScales];
			for (int i = 0; i < AWARD_RATIO_SCALE.m_ulScales; i++)
			{
				AWARD_RATIO_SCALE.m_Awards[i] = new AWARD_DATA();
				AWARD_DATA.Read(version, br, AWARD_RATIO_SCALE.m_Awards[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_RATIO_SCALE AWARD_RATIO_SCALE)
		{
			int ratios_count = GlobalFunctions.GetMaxAwardScales(version);
			if (AWARD_RATIO_SCALE.m_ulScales > ratios_count)
			{
				bw.Write(ratios_count);
			}
			else
			{
				bw.Write(AWARD_RATIO_SCALE.m_ulScales);
			}
			for (int i = 0; i < ratios_count; i++)
			{
				bw.Write(AWARD_RATIO_SCALE.m_Ratios[i]);
			}
			for (int i = 0; i < AWARD_RATIO_SCALE.m_ulScales && i < ratios_count; i++)
			{
				AWARD_DATA.Write(version, bw, AWARD_RATIO_SCALE.m_Awards[i]);
			}
		}
	}
}
//(c)Rey35