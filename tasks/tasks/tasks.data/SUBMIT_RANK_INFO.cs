//(c)Rey35
using System.IO;

namespace tasks
{
	public class SUBMIT_RANK_INFO
	{
		public int Param1;
		public int Param2;
		public int Param3;

		internal static void Read(int version, BinaryReader br, SUBMIT_RANK_INFO SUBMIT_RANK_INFO)
		{
			SUBMIT_RANK_INFO.Param1 = br.ReadInt32();
			SUBMIT_RANK_INFO.Param2 = br.ReadInt32();
			SUBMIT_RANK_INFO.Param3 = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, SUBMIT_RANK_INFO SUBMIT_RANK_INFO)
		{
			bw.Write(SUBMIT_RANK_INFO.Param1);
			bw.Write(SUBMIT_RANK_INFO.Param2);
			bw.Write(SUBMIT_RANK_INFO.Param3);
		}
	}
}
//(c)Rey35