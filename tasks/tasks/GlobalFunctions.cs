//(c)Rey35
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace tasks
{
	public class GlobalFunctions
	{
		public static IEnumerable<int> GetPowers(int value)
		{
			uint v = (uint)value;
			int i = 0;
			while (v > 0)
			{
				if ((v & 0x01) == 1)
					yield return (i);
				v >>= 1;
				i++;
			}
		}

		public static string ColorClean(string line)
		{
			string[] blocks = line.Split(new char[] { '^' });
			if (blocks.Length > 1)
			{
				string result = "";
				if (blocks[0] != "")
					result += blocks[0];
				for (int i = 1; i < blocks.Length; i++)
				{
					if (blocks[i] != "")
						try
						{
							if (Int32.TryParse(blocks[i].Substring(0, 6), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int color_int))
								result += blocks[i].Substring(6);
							else
								result += "^" + blocks[i];
						}
						catch
						{
							result += "^" + blocks[i];
						}
				}
				return result;
			}
			else
				return line;
		}

		internal static char[] ReadChars(int length, BinaryReader br)
		{
			char[] chars = new char[length];
			for (int i = 0; i < chars.Length; i++)
				chars[i] = (char)br.ReadByte();
			return chars;
		}
		internal static short[] ReadNameChars(int length, BinaryReader br)
		{
			short[] Chars = new short[length];
			for (int i = 0; i < length; i++)
				Chars[i] = br.ReadInt16();
			return Chars;
		}
		internal static short[] ReadChars_pwstr(BinaryReader br)
		{
			int len = br.ReadInt32();
			short[] Chars = new short[len];
			for (int i = 0; i < len; i++)
				Chars[i] = br.ReadInt16();
			return Chars;
		}
		internal static void WriteChars(BinaryWriter bw, char[] Chars)
		{
			for (int i = 0; i < Chars.Length; i++)
				bw.Write((byte)Chars[i]);
		}
		internal static void WriteNameChars(BinaryWriter bw, short[] Chars)
		{
			for (int i = 0; i < Chars.Length; i++)
				bw.Write(Chars[i]);
		}
		internal static void WriteChars_pwstr(BinaryWriter bw, short[] Chars)
		{
			bw.Write(Chars.Length);
			for (int i = 0; i < Chars.Length; i++)
				bw.Write(Chars[i]);
		}

		public static void UpdateNode(TreeNode Node, ATaskTempl Task, int UpdateType, int GMIconIndex = 12)
		{
			string Name = Task.Name;
			Color Color = Color.White;
			int ImageIndex = 0;
			int SelectedImageIndex = 1;
			switch ((GlobalData.ENUM_TASK_TYPE)Task.m_ulType)
			{
				case GlobalData.ENUM_TASK_TYPE.enumTTCommonOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTRepeatedOld:
					ImageIndex = 8;
					SelectedImageIndex = 9;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTKeyOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTBossOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTInstanceOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTScrollOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTBusinessOld:
					ImageIndex = 4;
					SelectedImageIndex = 5;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTFeelingOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTTacticsOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTRegionOld:
					ImageIndex = 6;
					SelectedImageIndex = 7;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTSevenKillListOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTFactionOld:
					ImageIndex = 6;
					SelectedImageIndex = 7;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTHintOld:
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTDaily:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(38, 178, 255);
						else
							Color = Color.FromArgb(100, 185, 250);
					}
					ImageIndex = 8;
					SelectedImageIndex = 9;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTLevel2:
					if (GlobalData.version >= 120)
						Color = Color.FromArgb(238, 156, 15);
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTMajor:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(20, 255, 255);
						else
							Color = Color.FromArgb(255, 150, 255);
					}
					if (GlobalData.version >= 156)
					{
						ImageIndex = 16;
						SelectedImageIndex = 17;
					}
					else
					{
						ImageIndex = 10;
						SelectedImageIndex = 11;
					}
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTBranch:
					if (GlobalData.version >= 120)
						Color = Color.FromArgb(255, 255, 255);
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTEvent:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(150, 224, 255);
						else
							Color = Color.FromArgb(255, 255, 0);
					}
					ImageIndex = 8;
					SelectedImageIndex = 9;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTQiShaList:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 161)
							Color = Color.FromArgb(150, 224, 255);
						else if (GlobalData.version >= 156)
							Color = Color.FromArgb(255, 255, 255);
						else
							Color = Color.FromArgb(180, 180, 255);
					}
					ImageIndex = 6;
					SelectedImageIndex = 7;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTFaction:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(255, 255, 255);
						else
							Color = Color.FromArgb(0, 200, 200);
					}
					ImageIndex = 4;
					SelectedImageIndex = 5;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTFunction:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(20, 196, 100);
						else
							Color = Color.FromArgb(120, 255, 120);
					}
					ImageIndex = 4;
					SelectedImageIndex = 5;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTLegend:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 126)
						{
							if (GlobalData.version >= 156)
								Color = Color.FromArgb(255, 255, 255);
							else
								Color = Color.FromArgb(255, 0, 0);
						}
						else
							Color = Color.FromArgb(255, 120, 120);
					}
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTQuestion:
					if (GlobalData.version >= 120)
						Color = Color.FromArgb(146, 255, 216);
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTHome:
					if (GlobalData.version >= 120)
					{
						if (GlobalData.version >= 156)
							Color = Color.FromArgb(84, 197, 255);
						else
							Color = Color.FromArgb(255, 120, 120);
					}
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTGrowth:
					Color = Color.FromArgb(20, 196, 100);
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTStory:
					Color = Color.FromArgb(255, 173, 255);
					ImageIndex = 12;
					SelectedImageIndex = 13;
					break;
				case GlobalData.ENUM_TASK_TYPE.enumTTInstance:
					Color = Color.FromArgb(255, 255, 255);
					ImageIndex = 0;
					SelectedImageIndex = 1;
					break;
			}
			if (Task.m_bKeyTask)
			{
				Color = Color.FromArgb(238, 156, 15);
				if (GlobalData.version >= 156)
				{
					ImageIndex = 14;
					SelectedImageIndex = 15;
				}
				else
				{
					ImageIndex = 2;
					SelectedImageIndex = 3;
				}
			}
			if (Task.m_bGM)
			{
				ImageIndex = GMIconIndex;
				SelectedImageIndex = GMIconIndex;
			}
			if (Name.StartsWith("^"))
			{
				try
				{
					if (GlobalData.version <= 119 || ((Task.m_ulType == (int)GlobalData.ENUM_TASK_TYPE.enumTTQiShaList || Task.m_ulType == (int)GlobalData.ENUM_TASK_TYPE.enumTTHome) && !Task.m_bKeyTask))
					{
						if (Int32.TryParse(Name.Substring(1, 6), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int color_int))
							Color = Color.FromArgb(color_int);
						else
							Color = Color.White;
					}
				}
				catch
				{
					Color = Color.White;
				}
			}
			if (UpdateType != 1)
				Node.Text = Task.m_ID.ToString() + " - " + ColorClean(Name);
			Node.ForeColor = Color;
			Node.ImageIndex = ImageIndex;
			Node.SelectedImageIndex = SelectedImageIndex;
		}

		public static int GetMaxTimetableSize(int version)
		{
			if (version < 69)
				return 12;
			return GlobalData.MAX_TIMETABLE_SIZE;
		}
		public static int GetMaxTaskRegion(int version)
		{
			if (version < 175)
				return 8;
			return GlobalData.MAX_TASKREGION;
		}

		public static int GetMaxPremTaskCount(int version)
		{
			if (version < 90)
				return 5;
			return GlobalData.MAX_PREM_TASK_COUNT;
		}

		public static int GetMaxOccupations(int version)
		{
			if (version < 89)
				return 8;
			else if (version < 120)
				return 10;
			else if (version < 147)
				return 12;
			return GlobalData.MAX_OCCUPATIONS;
		}

		public static int GetMaxTeamMemWanted(int version)
		{
			if (version < 89)
				return 8;
			else if (version < 120)
				return 10;
			else if (version < 147)
				return 12;
			return GlobalData.MAX_TEAM_MEM_WANTED;
		}

		public static int GetMaxPlayerWanted(int version)
		{
			if (version < 135)
				return 3;
			return GlobalData.MAX_PLAYER_WANTED;
		}

		public static int GetMaxMonsterWanted(int version)
		{
			if (version < 135)
				return 3;
			return GlobalData.MAX_MONSTER_WANTED;
		}

		public static int GetMaxAwardScales(int version)
		{
			if (version < 140)
				return 5;
			return GlobalData.MAX_AWARD_SCALES;
		}

		public static int GetCombinedSwitches(int version)
		{
			if (version < 146)
				return 16;
			else if (version < 153)
				return 17;
			else if (version < 167)
				return 18;
			else if (version < 177)
				return 19;
			return GlobalData.MAX_COMBINED_SWITCHES;
		}

		public static int GetMaxAwardCandidates(int version)
		{
			if (version < 89)
				return 8;
			else if (version < 120)
				return 10;
			else if (version < 164)
				return 12;
			return GlobalData.MAX_AWARD_CANDIDATES;
		}

		public static bool CheckFlag(int value, int flag)
		{
			return (value & flag) != 0;
		}

		public static bool CheckParam(int version, byte[] combied_switces, int param)
		{
			int param_index = param;
			if (version < 180)
			{
				if (param >= (int)GlobalData.TaskParameters.MultiNpcTalk)
					param_index--;
				if (version < 178)
				{
					if (param >= (int)GlobalData.TaskParameters.PremNeedCompPerson)
						param_index--;
					if (param >= (int)GlobalData.TaskParameters.FinNeedCompPerson)
						param_index--;
				}
			}
			int index = Convert.ToInt32(Math.Truncate(param_index / 8.0f));
			int mask = 0b_0000_0001 << (param_index - (8 * index));
			return (combied_switces[index] & mask) != 0;
		}

		public static void SetParam(int version, byte[] combied_switces, int param, bool param_val)
		{
			if (param_val)
			{
				int param_index = param;
				if (version < 180)
				{
					if (param >= (int)GlobalData.TaskParameters.MultiNpcTalk)
						param_index--;
					if (version < 178)
					{
						if (param >= (int)GlobalData.TaskParameters.PremNeedCompPerson)
							param_index--;
						if (param >= (int)GlobalData.TaskParameters.FinNeedCompPerson)
							param_index--;
					}
				}
				int index = Convert.ToInt32(Math.Truncate(param_index / 8.0f));
				int mask = 0b_0000_0001 << (param_index - (8 * index));
				combied_switces[index] += (byte)mask;
			}
		}
	}
}
//(c)Rey35