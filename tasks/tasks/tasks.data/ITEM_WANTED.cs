//(c)Rey35
using System.IO;

namespace tasks
{
	public class ITEM_WANTED
	{
		public int m_ulItemTemplId;
		public bool m_bCommonItem = true;
		public int m_ulItemNum = 1;
		public float m_fProb = 1f;
		public int m_lPeriod;

		internal static void Read(int version, BinaryReader br, ITEM_WANTED ITEM_WANTED)
		{
			ITEM_WANTED.m_ulItemTemplId = br.ReadInt32();
			ITEM_WANTED.m_bCommonItem = br.ReadBoolean();
			ITEM_WANTED.m_ulItemNum = br.ReadInt32();
			ITEM_WANTED.m_fProb = br.ReadSingle();
			if (version >= 60)
			{
				ITEM_WANTED.m_lPeriod = br.ReadInt32();
			}
		}

		internal static void Write(int version, BinaryWriter bw, ITEM_WANTED ITEM_WANTED)
		{
			bw.Write(ITEM_WANTED.m_ulItemTemplId);
			bw.Write(ITEM_WANTED.m_bCommonItem);
			bw.Write(ITEM_WANTED.m_ulItemNum);
			bw.Write(ITEM_WANTED.m_fProb);
			if (version >= 60)
			{
				bw.Write(ITEM_WANTED.m_lPeriod);
			}
		}
	}
}
//(c)Rey35