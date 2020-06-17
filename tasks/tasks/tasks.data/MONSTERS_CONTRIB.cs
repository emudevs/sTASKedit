//(c)Rey35
using System.IO;

namespace tasks
{
	public class MONSTERS_CONTRIB
	{
		public int m_ulMonsterTemplId;
		public int m_iWholeContrib;
		public int m_iShareContrib;
		public int m_iPersonalWholeContrib;

		internal static void Read(int version, BinaryReader br, MONSTERS_CONTRIB MONSTERS_CONTRIB)
		{
			MONSTERS_CONTRIB.m_ulMonsterTemplId = br.ReadInt32();
			MONSTERS_CONTRIB.m_iWholeContrib = br.ReadInt32();
			MONSTERS_CONTRIB.m_iShareContrib = br.ReadInt32();
			if (version >= 82)
			{
				MONSTERS_CONTRIB.m_iPersonalWholeContrib = br.ReadInt32();
			}
		}

		internal static void Write(int version, BinaryWriter bw, MONSTERS_CONTRIB MONSTERS_CONTRIB)
		{
			bw.Write(MONSTERS_CONTRIB.m_ulMonsterTemplId);
			bw.Write(MONSTERS_CONTRIB.m_iWholeContrib);
			bw.Write(MONSTERS_CONTRIB.m_iShareContrib);
			if (version >= 82)
			{
				bw.Write(MONSTERS_CONTRIB.m_iPersonalWholeContrib);
			}
		}
	}
}
//(c)Rey35