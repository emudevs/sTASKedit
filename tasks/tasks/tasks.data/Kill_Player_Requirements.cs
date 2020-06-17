//(c)Rey35
using System.IO;

namespace tasks
{
	public class Kill_Player_Requirements
	{
		public int m_ulOccupations;
		public int m_iMinLevel = 1;
		public int m_iMaxLevel = 150;
		public int m_iGender;
		public int m_iForce;
		public bool ModelCheck;
		public byte[] ModelType = new byte[3];

		internal static void Read(int version, BinaryReader br, Kill_Player_Requirements Kill_Player_Requirements)
		{
			Kill_Player_Requirements.m_ulOccupations = br.ReadInt32();
			Kill_Player_Requirements.m_iMinLevel = br.ReadInt32();
			Kill_Player_Requirements.m_iMaxLevel = br.ReadInt32();
			Kill_Player_Requirements.m_iGender = br.ReadInt32();
			Kill_Player_Requirements.m_iForce = br.ReadInt32();
			if (version >= 130)
			{
				Kill_Player_Requirements.ModelCheck = br.ReadBoolean();
				for (int i = 0; i < 3; i++)
				{
					Kill_Player_Requirements.ModelType[i] = br.ReadByte();
				}
			}
		}

		internal static void Write(int version, BinaryWriter bw, Kill_Player_Requirements Kill_Player_Requirements)
		{
			bw.Write(Kill_Player_Requirements.m_ulOccupations);
			bw.Write(Kill_Player_Requirements.m_iMinLevel);
			bw.Write(Kill_Player_Requirements.m_iMaxLevel);
			bw.Write(Kill_Player_Requirements.m_iGender);
			bw.Write(Kill_Player_Requirements.m_iForce);
			if (version >= 130)
			{
				bw.Write(Kill_Player_Requirements.ModelCheck);
				for (byte i = 0; i < 3; i++)
				{
					bw.Write(Kill_Player_Requirements.ModelType[i]);
				}
			}
		}
	}
}
//(c)Rey35