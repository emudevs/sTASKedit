//(c)Rey35
using System.IO;

namespace tasks
{
	public class TASK_PACK_HEADER
	{
		public int magic;
		public int version;
		public int item_count;

		public TASK_PACK_HEADER()
		{
		}

		public TASK_PACK_HEADER(BinaryReader BinaryStream)
		{
			Read(BinaryStream);
		}

		private void Read(BinaryReader br)
		{
			magic = br.ReadInt32();
			version = br.ReadInt32();
			item_count = br.ReadInt32();
		}
	}
}
//(c)Rey35