using System;
using System.IO;

namespace package
{
	public class Package : IDisposable
	{
		protected BufferedStream pck = null;
		protected BufferedStream pkx = null;
		protected BufferedStream pkx1 = null;
		string path = "";
		public long Position = 0;
		public Keys key = new Keys();
		const uint PCK_MAX_SIZE = 2147483392;
		const int BUFFER_SIZE = 33554432;

		public Package(string path, Keys key = null)
		{
			this.path = path;
			if (key != null)
			{
				this.key = key;
			}
			pck = new BufferedStream(new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite), BUFFER_SIZE);
			if (File.Exists(path.Replace(".pck", ".pkx")) && Path.GetExtension(path) != ".cup")
			{
				pkx = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx"), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite), BUFFER_SIZE);
				if (File.Exists(path.Replace(".pck", ".pkx1")) && Path.GetExtension(path) != ".cup")
					pkx1 = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx1"), FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite), BUFFER_SIZE);
			}
		}

		public void Seek(long offset, SeekOrigin origin)
		{
			switch (origin)
			{
				case SeekOrigin.Begin:
					Position = offset;
					break;
				case SeekOrigin.Current:
					Position += offset;
					break;
				case SeekOrigin.End:
					Position = GetLenght() + offset;
					break;
			}
			if (Position < pck.Length)
				pck.Seek(Position, SeekOrigin.Begin);
			else if (Position < pck.Length + pkx.Length)
				pkx.Seek(Position - pck.Length, SeekOrigin.Begin);
			else
				pkx1.Seek(Position - (pck.Length + pkx.Length), SeekOrigin.Begin);
		}

		public long GetLenght()
		{
			if (pkx1 != null)
				return pck.Length + pkx.Length + pkx1.Length;
			else if (pkx != null)
				return pck.Length + pkx.Length;
			else
				return pck.Length;
		}


		public static int GetFilesCount(Package package)
		{
			package.Seek(-8, SeekOrigin.End);
			return package.ReadInt32();
		}

		public byte[] ReadBytes(int count)
		{
			byte[] array = new byte[count];
			int BytesRead = 0;
			if (Position < pck.Length)
			{
				BytesRead = pck.Read(array, 0, count);
				if (BytesRead < count && pkx != null)
				{
					pkx.Seek(0, SeekOrigin.Begin);
					BytesRead += pkx.Read(array, BytesRead, count - BytesRead);
					if (BytesRead < count && pkx1 != null)
					{
						pkx1.Seek(0, SeekOrigin.Begin);
						BytesRead += pkx1.Read(array, BytesRead, count - BytesRead);
					}
				}
			}
			else if (Position > pck.Length && pkx != null)
			{
				if (Position > pck.Length + pkx.Length && pkx1 != null)
					BytesRead = pkx1.Read(array, 0, count);
				else
					BytesRead = pkx.Read(array, 0, count);
			}
			Position += count;
			return array;
		}

		public void WriteBytes(byte[] array)
		{
			if (Position + array.Length < PCK_MAX_SIZE)
			{
				pck.Write(array, 0, array.Length);
			}
			else if (Position + array.Length > PCK_MAX_SIZE * 2)
			{
				if (pkx1 == null)
				{
					pkx1 = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx1"), FileMode.Create, FileAccess.ReadWrite), BUFFER_SIZE);
				}
				if (Position > PCK_MAX_SIZE * 2)
				{
					pkx1.Write(array, 0, array.Length);
				}
				else
				{
					if (pkx1 == null)
					{
						pkx1 = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx1"), FileMode.Create, FileAccess.ReadWrite), BUFFER_SIZE);
					}
					pkx.Write(array, 0, (int)((PCK_MAX_SIZE * 2) - Position));
					pkx1.Write(array, (int)((PCK_MAX_SIZE * 2) - Position), array.Length - (int)((PCK_MAX_SIZE * 2) - Position));
				}
			}
			else if (Position + array.Length > PCK_MAX_SIZE)
			{
				if (pkx == null)
				{
					pkx = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx"), FileMode.Create, FileAccess.ReadWrite), BUFFER_SIZE);
				}
				if (Position > PCK_MAX_SIZE)
				{
					pkx.Write(array, 0, array.Length);
				}
				else
				{
					if (pkx == null)
					{
						pkx = new BufferedStream(new FileStream(path.Replace(".pck", ".pkx"), FileMode.Create, FileAccess.ReadWrite), BUFFER_SIZE);
					}
					pck.Write(array, 0, (int)(PCK_MAX_SIZE - Position));
					pkx.Write(array, (int)(PCK_MAX_SIZE - Position), array.Length - (int)(PCK_MAX_SIZE - Position));
				}
			}
			Position += array.Length;
		}

		public uint ReadUInt32() => BitConverter.ToUInt32(ReadBytes(4), 0);

		public int ReadInt32() => BitConverter.ToInt32(ReadBytes(4), 0);

		public long ReadInt64() => BitConverter.ToInt64(ReadBytes(8), 0);

		public void WriteInt16(short value) => WriteBytes(BitConverter.GetBytes(value));

		public void WriteInt32(int value) => WriteBytes(BitConverter.GetBytes(value));

		public void WriteUInt32(uint value) => WriteBytes(BitConverter.GetBytes(value));

		public void WriteInt64(long value) => WriteBytes(BitConverter.GetBytes(value));

		public void Dispose()
		{
			pck?.Close();
			pkx?.Close();
			pkx1?.Close();
		}

	}
}
