//(c)Rey35
using System.IO;

namespace tasks
{
	public class task_tm
	{
		public int year;
		public int month;
		public int day;
		public int hour;
		public int min;
		public int wday;

		internal static void Read(int version, BinaryReader br, task_tm task_tm)
		{
			task_tm.year = br.ReadInt32();
			task_tm.month = br.ReadInt32();
			task_tm.day = br.ReadInt32();
			task_tm.hour = br.ReadInt32();
			task_tm.min = br.ReadInt32();
			task_tm.wday = br.ReadInt32();
		}

		internal static void Write(int version, BinaryWriter bw, task_tm task_tm)
		{
			bw.Write(task_tm.year);
			bw.Write(task_tm.month);
			bw.Write(task_tm.day);
			bw.Write(task_tm.hour);
			bw.Write(task_tm.min);
			bw.Write(task_tm.wday);
		}
	}
}
//(c)Rey35