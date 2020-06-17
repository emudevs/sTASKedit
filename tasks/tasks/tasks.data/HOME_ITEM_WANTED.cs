//(c)Rey35
using System.IO;

namespace tasks
{
	public class HOME_ITEM_WANTED
	{
		public int m_ulHomeItemTid;
		public int m_ulHomeItemCount = 1;

		internal static void Read(int version, BinaryReader br, HOME_ITEM_WANTED HOME_ITEM_WANTED)
		{
			HOME_ITEM_WANTED.m_ulHomeItemTid = br.ReadInt32();
			HOME_ITEM_WANTED.m_ulHomeItemCount = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, HOME_ITEM_WANTED HOME_ITEM_WANTED)
		{
			bw.Write(HOME_ITEM_WANTED.m_ulHomeItemTid);
			bw.Write(HOME_ITEM_WANTED.m_ulHomeItemCount);
		}
	}
}
//(c)Rey35