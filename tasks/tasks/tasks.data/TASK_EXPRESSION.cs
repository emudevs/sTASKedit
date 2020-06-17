//(c)Rey35
using System.IO;

namespace tasks
{
	public class TASK_EXPRESSION
	{
		public int type;
		public float value;

		static public TASK_EXPRESSION[] New(int size)
		{
			TASK_EXPRESSION[] expArr = new TASK_EXPRESSION[size];
			for (int i = 0; i < size; i++)
			{
				expArr[i] = new TASK_EXPRESSION();
			}
			return expArr;
		}

		internal static void Read(int version, BinaryReader br, TASK_EXPRESSION TASK_EXPRESSION)
		{
			TASK_EXPRESSION.type = br.ReadInt32();
			TASK_EXPRESSION.value = br.ReadSingle();
		}

		internal static void Write(int version, BinaryWriter bw, TASK_EXPRESSION TASK_EXPRESSION)
		{
			bw.Write(TASK_EXPRESSION.type);
			bw.Write(TASK_EXPRESSION.value);
		}
	}
}
//(c)Rey35