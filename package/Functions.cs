using System.IO;

namespace package
{
    public class Functions
    {
		public static FileInfo[] GetFileTable(string PackagePath, string GameMode)
		{
			Package package = new Package(PackagePath, Keys.SetKeys(GameMode));
			int Offset = -272;
			package.Seek(-4, SeekOrigin.End);
			int Version = package.ReadInt32();
			if (Version == 131075)
				Offset = -280;
			package.Seek(-8, SeekOrigin.End);
			int FilesCount = package.ReadInt32();
			package.Seek(Offset, SeekOrigin.End);
			long FileTableOffset;
			if (Version == 131075)
				FileTableOffset = package.ReadInt64() ^ package.key.KEY_1;
			else
				FileTableOffset = package.ReadUInt32() ^ (uint)package.key.KEY_1;
			package.Seek(FileTableOffset, SeekOrigin.Begin);
			BinaryReader TableStream = new BinaryReader(new MemoryStream(package.ReadBytes((int)(package.GetLenght() - FileTableOffset - 280))));
			FileInfo[] FileTable = new FileInfo[FilesCount];
			for (int i = 0; i < FilesCount; i++)
			{
				FileTable[i] = FileInfo.Read(TableStream, Version, package.key);
			}
			package.Dispose();
			return FileTable;
		}

		public static MemoryStream GetFile(FileInfo[] FileTable, string PackagePath, string GameMode, string File)
		{
			Package package = new Package(PackagePath, Keys.SetKeys(GameMode));
			for (int i = 0; i < FileTable.Length; i++)
			{
				if (File.ToLower() == FileTable[i].Path.ToLower())
				{
					package.Seek(FileTable[i].Offset, SeekOrigin.Begin);
					byte[] file = package.ReadBytes(FileTable[i].CompressedSize);
					if (FileTable[i].CompressedSize < FileTable[i].Size)
					{
						package.Dispose();
						return new MemoryStream(Zlib.Decompress(file, FileTable[i].Size));
					}
					else
					{
						package.Dispose();
						return new MemoryStream(file);
					}
				}
			}
			package.Dispose();
			return new MemoryStream();
		}
	}
}
