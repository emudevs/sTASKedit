//(c)Rey35
using System.IO;

namespace tasks
{
	public class MONSTER_WANTED
	{
		public int m_ulMonsterTemplId;
		public int m_ulMonsterNum;
		public int m_ulDropItemId;
		public int m_ulDropItemCount;
		public bool m_bDropCmnItem;
		public float m_fDropProb = 1f;
		public bool m_bKillerLev;
		public int m_iDPH;
		public int m_iDPS;

		internal static void Read(int version, BinaryReader br, MONSTER_WANTED MONSTER_WANTED)
		{
			MONSTER_WANTED.m_ulMonsterTemplId = br.ReadInt32();
			MONSTER_WANTED.m_ulMonsterNum = br.ReadInt32();
			MONSTER_WANTED.m_ulDropItemId = br.ReadInt32();
			MONSTER_WANTED.m_ulDropItemCount = br.ReadInt32();
			MONSTER_WANTED.m_bDropCmnItem = br.ReadBoolean();
			MONSTER_WANTED.m_fDropProb = br.ReadSingle();
			MONSTER_WANTED.m_bKillerLev = br.ReadBoolean();
			if (version >= 92)
			{
				MONSTER_WANTED.m_iDPH = br.ReadInt32();
				MONSTER_WANTED.m_iDPS = br.ReadInt32();
			}
		}

		internal static void Write(int version, BinaryWriter bw, MONSTER_WANTED MONSTER_WANTED)
		{
			bw.Write(MONSTER_WANTED.m_ulMonsterTemplId);
			bw.Write(MONSTER_WANTED.m_ulMonsterNum);
			bw.Write(MONSTER_WANTED.m_ulDropItemId);
			bw.Write(MONSTER_WANTED.m_ulDropItemCount);
			bw.Write(MONSTER_WANTED.m_bDropCmnItem);
			bw.Write(MONSTER_WANTED.m_fDropProb);
			bw.Write(MONSTER_WANTED.m_bKillerLev);
			if (version >= 92)
			{
				bw.Write(MONSTER_WANTED.m_iDPH);
				bw.Write(MONSTER_WANTED.m_iDPS);
			}
		}
	}
}
//(c)Rey35