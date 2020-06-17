//(c)Rey35
using System.IO;

namespace tasks
{
	public class FACTION_TARGET_DATA
	{
		public int FactionTargetId;
		public int Num = 1;

		internal static void Read(int version, BinaryReader br, FACTION_TARGET_DATA FACTION_TARGET_DATA)
		{
			FACTION_TARGET_DATA.FactionTargetId = br.ReadInt32();
			FACTION_TARGET_DATA.Num = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, FACTION_TARGET_DATA FACTION_TARGET_DATA)
		{
			bw.Write(FACTION_TARGET_DATA.FactionTargetId);
			bw.Write(FACTION_TARGET_DATA.Num);
		}
	}
}
//(c)Rey35