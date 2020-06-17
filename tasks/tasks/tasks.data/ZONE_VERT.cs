//(c)Rey35
using System.IO;

namespace tasks
{
	public class ZONE_VERT
	{
		public float[] v = new float[3];

		internal static void Read(int version, BinaryReader br, ZONE_VERT ZONE_VERT)
		{
			for (int i = 0; i < 3; i++)
			{
				ZONE_VERT.v[i] = br.ReadSingle();
			}
		}

		internal static void Write(int version, BinaryWriter bw, ZONE_VERT ZONE_VERT)
		{
			for (int i = 0; i < 3; i++)
			{
				bw.Write(ZONE_VERT.v[i]);
			}
		}
	}
}
//(c)Rey35