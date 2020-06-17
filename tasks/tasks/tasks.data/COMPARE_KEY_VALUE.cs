//(c)Rey35
using System.IO;

namespace tasks
{
	public class COMPARE_KEY_VALUE
	{
		public int nLeftType;
		public int lLeftNum;
		public int nCompOper;
		public int nRightType;
		public int lRightNum;

		internal static void Read(int version, BinaryReader br, COMPARE_KEY_VALUE COMPARE_KEY_VALUE)
		{
			COMPARE_KEY_VALUE.nLeftType = br.ReadInt32();
			COMPARE_KEY_VALUE.lLeftNum = br.ReadInt32();
			COMPARE_KEY_VALUE.nCompOper = br.ReadInt32();
			COMPARE_KEY_VALUE.nRightType = br.ReadInt32();
			COMPARE_KEY_VALUE.lRightNum = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, COMPARE_KEY_VALUE COMPARE_KEY_VALUE)
		{
			bw.Write(COMPARE_KEY_VALUE.nLeftType);
			bw.Write(COMPARE_KEY_VALUE.lLeftNum);
			bw.Write(COMPARE_KEY_VALUE.nCompOper);
			bw.Write(COMPARE_KEY_VALUE.nRightType);
			bw.Write(COMPARE_KEY_VALUE.lRightNum);
		}
	}
}
//(c)Rey35