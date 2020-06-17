using System;
using System.IO;
using System.Text;

namespace package
{
	public class FileInfo
	{
		public string Path { get; set; }
		public long Offset { get; set; }
		public int v3p1 { get; set; }
		public int Size { get; set; }
		public int CompressedSize { get; set; }
		public int v3p2 { get; set; }
		public int unk { get; set; }

		public FileInfo()
		{

		}

		public FileInfo(byte[] bytes, int version)
		{
			ReadFile(bytes, version);
		}

		public static FileInfo Read(BinaryReader TableStream, int Version, Keys Key)
		{
			int EntrySize = TableStream.ReadInt32() ^ Key.KEY_1;
			TableStream.ReadInt32();
			return new FileInfo(TableStream.ReadBytes(EntrySize), Version);
		}

		public void ReadFile(byte[] bytes, int version)
		{
			int Length = 276;
			if (version == 131075)
				Length = 288;
			if (bytes.Length < Length)
			{
				bytes = Zlib.Decompress(bytes, Length);
			}
			BinaryReader br = new BinaryReader(new MemoryStream(bytes));
			Path = Encoding.GetEncoding(936).GetString(br.ReadBytes(260)).Split(new string[] { "\0" }, StringSplitOptions.RemoveEmptyEntries)[0].Replace("/", "\\");
			if (version == 131075)
			{
				v3p1 = br.ReadInt32();
				Offset = br.ReadInt64();
			}
			else
				Offset = br.ReadUInt32();
			Size = br.ReadInt32();
			CompressedSize = br.ReadInt32();
			if (version == 131075)
				v3p2 = br.ReadInt32();
			unk = br.ReadInt32();
			br.Close();
		}

		public byte[] WriteFile(int CompressionLevel, int version)
		{
			int Length = 276;
			if (version == 131075)
				Length = 288;
			byte[] buffer = new byte[Length];
			MemoryStream msb = new MemoryStream(buffer);
			BinaryWriter bw = new BinaryWriter(msb);
			bw.Write(Encoding.GetEncoding("GB2312").GetBytes(Path.Replace("/", "\\")));
			bw.BaseStream.Seek(260, SeekOrigin.Begin);
			if (version == 131075)
			{
				bw.Write(v3p1);
				bw.Write(Offset);
			}
			else
				bw.Write((uint)Offset);
			bw.Write(Size);
			bw.Write(CompressedSize);
			if (version == 131075)
				bw.Write(v3p2);
			bw.Write(unk);
			bw.BaseStream.Seek(0, SeekOrigin.Begin);
			bw.Close();
			byte[] compressed = Zlib.Compress(buffer, CompressionLevel);
			return compressed.Length < Length ? compressed : buffer;
		}
	}
}
