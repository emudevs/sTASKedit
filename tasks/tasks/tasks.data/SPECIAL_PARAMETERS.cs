//(c)Rey35
using System.IO;

namespace tasks
{
	public class SPECIAL_PARAMETERS
	{
		public int[] ParameterTypes = new int[0];
		public int[] unk176 = new int[0];
		public int FailWhenGetOffCarrier;
		public int TimeWhenRideCarrier;
		public int GetOffCarrierID;
		public int RideCarrierID;
		public int UseItemTimes;
		public int UseItemCount;
		public int[] UseItemIDs = new int[0];
		public int CompleteTaskTimes;
		public int CompleteTaskCount;
		public int ByCompleteTask;
		public int[] CompleteTaskIDs = new int[0];
		public int[] CompleteTaskIDsSpace = new int[0];
		public int Parameter9;
		public int need_story_book_collection;
		public int story_book_collection_count;

		public int UseItemIDsPointer, CompleteTaskIDsPointer, CompleteTaskIDsSpacePointer;

		internal static void Read(int version, BinaryReader br, int ParametersCount, SPECIAL_PARAMETERS SPECIAL_PARAMETERS)
		{
			SPECIAL_PARAMETERS.ParameterTypes = new int[ParametersCount];
			SPECIAL_PARAMETERS.unk176 = new int[ParametersCount];
			for (int i = 0; i < ParametersCount; i++)
			{
				SPECIAL_PARAMETERS.ParameterTypes[i] = br.ReadInt32();
				ReadParamter(version, br, SPECIAL_PARAMETERS, SPECIAL_PARAMETERS.ParameterTypes[i]);
				if (version >= 176)
				{
					SPECIAL_PARAMETERS.unk176[i] = br.ReadInt32();
				}
			}
			SPECIAL_PARAMETERS.UseItemIDs = new int[SPECIAL_PARAMETERS.UseItemCount];
			for (int i = 0; i < SPECIAL_PARAMETERS.UseItemCount; i++)
			{
				SPECIAL_PARAMETERS.UseItemIDs[i] = br.ReadInt32();
			}
			SPECIAL_PARAMETERS.CompleteTaskIDs = new int[SPECIAL_PARAMETERS.CompleteTaskCount];
			for (int i = 0; i < SPECIAL_PARAMETERS.CompleteTaskCount; i++)
			{
				SPECIAL_PARAMETERS.CompleteTaskIDs[i] = br.ReadInt32();
			}
			SPECIAL_PARAMETERS.CompleteTaskIDsSpace = new int[SPECIAL_PARAMETERS.CompleteTaskCount];
			if (version >= 153)
			{
				for (int i = 0; i < SPECIAL_PARAMETERS.CompleteTaskCount; i++)
				{
					SPECIAL_PARAMETERS.CompleteTaskIDsSpace[i] = br.ReadInt32();
				}
			}
		}

		internal static void ReadParamter(int version, BinaryReader br, SPECIAL_PARAMETERS SPECIAL_PARAMETERS, int ParameterType)
		{
			switch (ParameterType)
			{
				case 0:
					SPECIAL_PARAMETERS.FailWhenGetOffCarrier = br.ReadInt32();
					break;
				case 1:
					SPECIAL_PARAMETERS.TimeWhenRideCarrier = br.ReadInt32();
					break;
				case 2:
					SPECIAL_PARAMETERS.UseItemTimes = br.ReadInt32();
					break;
				case 3:
					SPECIAL_PARAMETERS.UseItemCount = br.ReadInt32();
					break;
				case 4:
					SPECIAL_PARAMETERS.UseItemIDsPointer = br.ReadInt32();
					break;
				case 5:
					SPECIAL_PARAMETERS.CompleteTaskTimes = br.ReadInt32();
					break;
				case 6:
					SPECIAL_PARAMETERS.CompleteTaskCount = br.ReadInt32();
					break;
				case 7:
					SPECIAL_PARAMETERS.CompleteTaskIDsPointer = br.ReadInt32();
					break;
				case 8:
					SPECIAL_PARAMETERS.ByCompleteTask = br.ReadInt32();
					break;
				case 9:
					SPECIAL_PARAMETERS.Parameter9 = br.ReadInt32();
					break;
				case 10:
					SPECIAL_PARAMETERS.GetOffCarrierID = br.ReadInt32();
					break;
				case 11:
					SPECIAL_PARAMETERS.RideCarrierID = br.ReadInt32();
					break;
				case 12:
					SPECIAL_PARAMETERS.need_story_book_collection = br.ReadInt32();
					break;
				case 13:
					SPECIAL_PARAMETERS.story_book_collection_count = br.ReadInt32();
					break;
				case 14:
					SPECIAL_PARAMETERS.CompleteTaskIDsSpacePointer = br.ReadInt32();
					break;
			}
		}

		internal static void Write(int version, int combinedswitch, BinaryWriter bw, SPECIAL_PARAMETERS SPECIAL_PARAMETERS)
		{
			for (int i = 0; i < SPECIAL_PARAMETERS.ParameterTypes.Length; i++)
			{
				if (CheckParameter(version, SPECIAL_PARAMETERS.ParameterTypes[i]))
				{
					bw.Write(SPECIAL_PARAMETERS.ParameterTypes[i]);
					WriteParamter(version, bw, SPECIAL_PARAMETERS, SPECIAL_PARAMETERS.ParameterTypes[i]);
					if (version >= 176)
					{
						bw.Write(SPECIAL_PARAMETERS.unk176[i]);
					}
				}
			}
			for (int i = 0; i < SPECIAL_PARAMETERS.UseItemCount; i++)
			{
				bw.Write(SPECIAL_PARAMETERS.UseItemIDs[i]);
			}
			for (int i = 0; i < SPECIAL_PARAMETERS.CompleteTaskCount; i++)
			{
				bw.Write(SPECIAL_PARAMETERS.CompleteTaskIDs[i]);
			}
			if (version >= 153)
			{
				for (int i = 0; i < SPECIAL_PARAMETERS.CompleteTaskCount; i++)
				{
					bw.Write(SPECIAL_PARAMETERS.CompleteTaskIDsSpace[i]);
				}
			}
		}

		internal static void WriteParamter(int version, BinaryWriter bw, SPECIAL_PARAMETERS SPECIAL_PARAMETERS, int ParameterType)
		{
			switch (ParameterType)
			{
				case 0:
					bw.Write(SPECIAL_PARAMETERS.FailWhenGetOffCarrier);
					break;
				case 1:
					bw.Write(SPECIAL_PARAMETERS.TimeWhenRideCarrier);
					break;
				case 2:
					bw.Write(SPECIAL_PARAMETERS.UseItemTimes);
					break;
				case 3:
					bw.Write(SPECIAL_PARAMETERS.UseItemCount);
					break;
				case 4:
					bw.Write(SPECIAL_PARAMETERS.UseItemIDsPointer);
					break;
				case 5:
					bw.Write(SPECIAL_PARAMETERS.CompleteTaskTimes);
					break;
				case 6:
					bw.Write(SPECIAL_PARAMETERS.CompleteTaskCount);
					break;
				case 7:
					bw.Write(SPECIAL_PARAMETERS.CompleteTaskIDsPointer);
					break;
				case 8:
					bw.Write(SPECIAL_PARAMETERS.ByCompleteTask);
					break;
				case 9:
					bw.Write(SPECIAL_PARAMETERS.Parameter9);
					break;
				case 10:
					bw.Write(SPECIAL_PARAMETERS.GetOffCarrierID);
					break;
				case 11:
					bw.Write(SPECIAL_PARAMETERS.RideCarrierID);
					break;
				case 12:
					bw.Write(SPECIAL_PARAMETERS.need_story_book_collection);
					break;
				case 13:
					bw.Write(SPECIAL_PARAMETERS.story_book_collection_count);
					break;
				case 14:
					bw.Write(SPECIAL_PARAMETERS.CompleteTaskIDsSpacePointer);
					break;
			}
		}

		static public bool CheckParameter(int version, int Type)
		{
			if (Type == 12 && version < 147)
				return false;
			if (Type == 13 && version < 147)
				return false;
			if (Type == 14 && version < 153)
				return false;
			return true;
		}
	}
}
//(c)Rey35