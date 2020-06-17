//(c)Rey35
using System.IO;

namespace tasks
{
	public class TaskEventData
	{
		public short IdSpace;
		public int Id;
		public float Value = 1f;

		internal static void Read(int version, BinaryReader br, TaskEventData TaskEventData)
		{
			if (version >= 153)
			{
				TaskEventData.IdSpace = br.ReadInt16();
			}
			TaskEventData.Id = br.ReadInt32();
			TaskEventData.Value = br.ReadSingle();
		}

		internal static void Write(int version, BinaryWriter bw, TaskEventData TaskEventData)
		{
			if (version >= 153)
			{
				bw.Write(TaskEventData.IdSpace);
			}
			bw.Write(TaskEventData.Id);
			bw.Write(TaskEventData.Value);
		}
	}
}
//(c)Rey35