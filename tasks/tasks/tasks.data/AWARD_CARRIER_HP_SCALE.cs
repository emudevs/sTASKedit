//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_CARRIER_HP_SCALE
	{
		public int m_ulScales;
		public int[] AwardCarrierHp = new int[GlobalData.MAX_AWARD_CARRIER_HP_SCALES];
		public AWARD_DATA[] m_Awards = new AWARD_DATA[0];

		internal static void Read(int version, BinaryReader br, AWARD_CARRIER_HP_SCALE AWARD_CARRIER_HP_SCALE)
		{
			AWARD_CARRIER_HP_SCALE.m_ulScales = br.ReadInt32();
			for (int i = 0; i < AWARD_CARRIER_HP_SCALE.AwardCarrierHp.Length; i++)
			{
				AWARD_CARRIER_HP_SCALE.AwardCarrierHp[i] = br.ReadInt32();
			}
			AWARD_CARRIER_HP_SCALE.m_Awards = new AWARD_DATA[AWARD_CARRIER_HP_SCALE.m_ulScales];
			for (int i = 0; i < AWARD_CARRIER_HP_SCALE.m_Awards.Length; i++)
			{
				AWARD_CARRIER_HP_SCALE.m_Awards[i] = new AWARD_DATA();
				AWARD_DATA.Read(version, br, AWARD_CARRIER_HP_SCALE.m_Awards[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_CARRIER_HP_SCALE AWARD_CARRIER_HP_SCALE)
		{
			bw.Write(AWARD_CARRIER_HP_SCALE.m_ulScales);
			for (int i = 0; i < AWARD_CARRIER_HP_SCALE.AwardCarrierHp.Length; i++)
			{
				bw.Write(AWARD_CARRIER_HP_SCALE.AwardCarrierHp[i]);
			}
			for (int i = 0; i < AWARD_CARRIER_HP_SCALE.m_Awards.Length; i++)
			{
				AWARD_DATA.Write(version, bw, AWARD_CARRIER_HP_SCALE.m_Awards[i]);
			}
		}
	}
}
//(c)Rey35