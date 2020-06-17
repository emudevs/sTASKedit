//(c)Rey35
using System.IO;

namespace tasks
{
	public class Task_Region
	{
		public int MapID;
		public ZONE_VERT zvMin = new ZONE_VERT();
		public ZONE_VERT zvMax = new ZONE_VERT();

		internal static void Read(int version, BinaryReader br, Task_Region Task_Region)
		{
			if (version >= 157)
			{
				Task_Region.MapID = br.ReadInt32();
			}
			ZONE_VERT.Read(version, br, Task_Region.zvMin);
			ZONE_VERT.Read(version, br, Task_Region.zvMax);
		}

		internal static void Write(int version, BinaryWriter bw, Task_Region Task_Region)
		{
			if (version >= 157)
			{
				bw.Write(Task_Region.MapID);
			}
			ZONE_VERT.Write(version, bw, Task_Region.zvMin);
			ZONE_VERT.Write(version, bw, Task_Region.zvMax);
		}
	}
}
//(c)Rey35