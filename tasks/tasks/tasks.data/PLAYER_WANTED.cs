//(c)Rey35
using System.IO;

namespace tasks
{
	public class PLAYER_WANTED
	{
		public int m_ulPlayerNum = 1;
		public int m_ulDropItemId;
		public int m_ulDropItemCount = 1;
		public bool m_bDropCmnItem;
		public float m_fDropProb = 1;
		public Kill_Player_Requirements m_Requirements = new Kill_Player_Requirements();

		internal static void Read(int version, BinaryReader br, PLAYER_WANTED PLAYER_WANTED)
		{
			PLAYER_WANTED.m_ulPlayerNum = br.ReadInt32();
			PLAYER_WANTED.m_ulDropItemId = br.ReadInt32();
			PLAYER_WANTED.m_ulDropItemCount = br.ReadInt32();
			PLAYER_WANTED.m_bDropCmnItem = br.ReadBoolean();
			PLAYER_WANTED.m_fDropProb = br.ReadSingle();
			Kill_Player_Requirements.Read(version, br, PLAYER_WANTED.m_Requirements);
		}

		internal static void Write(int version, BinaryWriter bw, PLAYER_WANTED PLAYER_WANTED)
		{
			bw.Write(PLAYER_WANTED.m_ulPlayerNum);
			bw.Write(PLAYER_WANTED.m_ulDropItemId);
			bw.Write(PLAYER_WANTED.m_ulDropItemCount);
			bw.Write(PLAYER_WANTED.m_bDropCmnItem);
			bw.Write(PLAYER_WANTED.m_fDropProb);
			Kill_Player_Requirements.Write(version, bw, PLAYER_WANTED.m_Requirements);
		}
	}
}
//(c)Rey35