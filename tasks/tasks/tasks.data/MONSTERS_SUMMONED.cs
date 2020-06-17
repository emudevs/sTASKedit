//(c)Rey35
using System.IO;

namespace tasks
{
	public class MONSTERS_SUMMONED
	{
		public int m_ulMonsterTemplId;
		public int m_ulMonsterNum;
		public float m_fSummonProb;
		public int m_lPeriod;

		internal static void Read(int version, BinaryReader br, MONSTERS_SUMMONED MONSTERS_SUMMONED)
		{
			MONSTERS_SUMMONED.m_ulMonsterTemplId = br.ReadInt32();
			MONSTERS_SUMMONED.m_ulMonsterNum = br.ReadInt32();
			MONSTERS_SUMMONED.m_fSummonProb = br.ReadSingle();
			MONSTERS_SUMMONED.m_lPeriod = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, MONSTERS_SUMMONED MONSTERS_SUMMONED)
		{
			bw.Write(MONSTERS_SUMMONED.m_ulMonsterTemplId);
			bw.Write(MONSTERS_SUMMONED.m_ulMonsterNum);
			bw.Write(MONSTERS_SUMMONED.m_fSummonProb);
			bw.Write(MONSTERS_SUMMONED.m_lPeriod);
		}

		public static MONSTERS_SUMMONED[] NewArray(int size) 
		{
			MONSTERS_SUMMONED[] MONSTERS_SUMMONED = new MONSTERS_SUMMONED[size];
			for (int i = 0; i < size; i++) 
			{
				MONSTERS_SUMMONED[i] = new MONSTERS_SUMMONED();
			}
			return MONSTERS_SUMMONED;
		}
	}
}
//(c)Rey35