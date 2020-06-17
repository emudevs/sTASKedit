//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_MONSTERS_SUMMONED
	{
		public int m_ulMonsterNum;
		public bool m_bRandChoose;
		public int m_ulSummonRadius;
		public bool m_bDeathDisappear;
		public MONSTERS_SUMMONED[] m_Monsters = new MONSTERS_SUMMONED[0];

		internal static void Read(int version, BinaryReader br, AWARD_MONSTERS_SUMMONED AWARD_MONSTERS_SUMMONED)
		{
			AWARD_MONSTERS_SUMMONED.m_bRandChoose = br.ReadBoolean();
			AWARD_MONSTERS_SUMMONED.m_ulSummonRadius = br.ReadInt32();
			AWARD_MONSTERS_SUMMONED.m_bDeathDisappear = br.ReadBoolean();
			AWARD_MONSTERS_SUMMONED.m_Monsters = new MONSTERS_SUMMONED[AWARD_MONSTERS_SUMMONED.m_ulMonsterNum];
			for (int i = 0; i < AWARD_MONSTERS_SUMMONED.m_ulMonsterNum; i++)
			{
				AWARD_MONSTERS_SUMMONED.m_Monsters[i] = new MONSTERS_SUMMONED();
				MONSTERS_SUMMONED.Read(version, br, AWARD_MONSTERS_SUMMONED.m_Monsters[i]);
			}
		}
		internal static void Read2(int version, BinaryReader br, AWARD_MONSTERS_SUMMONED AWARD_MONSTERS_SUMMONED)
		{
			AWARD_MONSTERS_SUMMONED.m_Monsters = new MONSTERS_SUMMONED[GlobalData.MAX_MONSTER_SUMMONED];
			if (version >= 180)
			{
				AWARD_MONSTERS_SUMMONED.m_ulMonsterNum = br.ReadInt32();
				AWARD_MONSTERS_SUMMONED.m_bRandChoose = br.ReadBoolean();
				AWARD_MONSTERS_SUMMONED.m_ulSummonRadius = br.ReadInt32();
				AWARD_MONSTERS_SUMMONED.m_bDeathDisappear = br.ReadBoolean();
			}
			for (int i = 0; i < GlobalData.MAX_MONSTER_SUMMONED; i++)
			{
				AWARD_MONSTERS_SUMMONED.m_Monsters[i] = new MONSTERS_SUMMONED();
				if (version >= 180)
				{
					MONSTERS_SUMMONED.Read(version, br, AWARD_MONSTERS_SUMMONED.m_Monsters[i]);
				}
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_MONSTERS_SUMMONED AWARD_MONSTERS_SUMMONED)
		{
			bw.Write(AWARD_MONSTERS_SUMMONED.m_bRandChoose);
			bw.Write(AWARD_MONSTERS_SUMMONED.m_ulSummonRadius);
			bw.Write(AWARD_MONSTERS_SUMMONED.m_bDeathDisappear);
			for (int i = 0; i < AWARD_MONSTERS_SUMMONED.m_Monsters.Length; i++)
			{
				MONSTERS_SUMMONED.Write(version, bw, AWARD_MONSTERS_SUMMONED.m_Monsters[i]);
			}
		}
		internal static void Write2(int version, BinaryWriter bw, AWARD_MONSTERS_SUMMONED AWARD_MONSTERS_SUMMONED)
		{
			bw.Write(AWARD_MONSTERS_SUMMONED.m_ulMonsterNum);
			bw.Write(AWARD_MONSTERS_SUMMONED.m_bRandChoose);
			bw.Write(AWARD_MONSTERS_SUMMONED.m_ulSummonRadius);
			bw.Write(AWARD_MONSTERS_SUMMONED.m_bDeathDisappear);
			for (int i = 0; i < AWARD_MONSTERS_SUMMONED.m_Monsters.Length; i++)
			{
				MONSTERS_SUMMONED.Write(version, bw, AWARD_MONSTERS_SUMMONED.m_Monsters[i]);
			}
		}
	}
}
//(c)Rey35