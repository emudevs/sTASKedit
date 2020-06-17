//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_DATA
	{
		public int m_ulGoldNum { get; set; }
		public int m_ulExp { get; set; }
		public int m_ulRealmExp { get; set; }
		public bool m_bExpandRealmLevelMax { get; set; }
		public int NewTaskSpace { get; set; }
		public int m_ulNewTask { get; set; }
		public int m_ulSP { get; set; }
		public int m_lReputation { get; set; }
		public int m_ulNewPeriod { get; set; }
		public int m_ulNewRelayStation { get; set; }
		public int m_ulStorehouseSize { get; set; }
		public int m_ulStorehouseSize2 { get; set; }
		public int m_ulStorehouseSize3 { get; set; }
		public int m_ulStorehouseSize4 { get; set; }
		public int m_lInventorySize { get; set; }
		public int m_ulPetInventorySize { get; set; }
		public int m_ulFuryULimit { get; set; }
		public int m_ulTransWldId { get; set; }
		public int CrossServerID { get; set; }
		public ZONE_VERT m_TransPt = new ZONE_VERT();
		public int m_lMonsCtrl { get; set; }
		public bool m_bTrigCtrl { get; set; }
		public bool m_bUseLevCo { get; set; }
		public bool m_bDivorce { get; set; }
		public bool m_bSendMsg { get; set; }
		public int m_nMsgChannel { get; set; }
		public int m_ulCandItems { get; set; }
		public AWARD_ITEMS_CAND[] m_CandItems = new AWARD_ITEMS_CAND[0];
		public int m_ulSummonedMonsters { get; set; }
		public AWARD_MONSTERS_SUMMONED m_SummonedMonsters = new AWARD_MONSTERS_SUMMONED();
		public bool m_bAwardDeath { get; set; }
		public bool m_bAwardDeathWithLoss { get; set; }
		public int m_ulDividend { get; set; }
		public bool m_bAwardSkill { get; set; }
		public int m_iAwardSkillID { get; set; }
		public int m_iAwardSkillLevel { get; set; }
		public int m_iSoloTowerChallengeScore { get; set; }
		public int AwardOpenSystem { get; set; }
		public int m_ulSpecifyContribTaskID { get; set; }
		public int m_ulSpecifyContribSubTaskID { get; set; }
		public int m_ulSpecifyContrib { get; set; }
		public int m_ulContrib { get; set; }
		public int m_ulRandContrib { get; set; }
		public int m_ulLowestcontrib { get; set; }
		public int m_iFactionContrib { get; set; }
		public int m_iFactionExpContrib { get; set; }
		public int m_ulPQRankingAwardCnt { get; set; }
		public AWARD_PQ_RANKING m_PQRankingAward = new AWARD_PQ_RANKING();
		public int m_ulChangeKeyCnt { get; set; }
		public int[] m_plChangeKey = new int[0];
		public int[] m_plChangeKeyValue = new int[0];
		public bool[] m_pbChangeType = new bool[0];
		public int PersonChangeKeyCnt { get; set; }
		public int[] PersonChangeKey = new int[0];
		public int[] PersonChangeKeyValue = new int[0];
		public bool[] PersonChangeType = new bool[0];
		public int m_ulHistoryChangeCnt { get; set; }
		public int[] m_plHistoryChangeKey = new int[0];
		public int[] m_plHistoryChangeKeyValue = new int[0];
		public bool[] m_pbHistoryChangeType = new bool[0];
		public bool m_bMulti { get; set; }
		public int m_nNumType { get; set; }
		public int m_lNum { get; set; }
		public int m_ulDisplayKeyCnt { get; set; }
		public int[] m_plDisplayKey = new int[0];
		public int m_ulExpCnt { get; set; }
		public char[][] m_pszExp = new char[0][];
		public TASK_EXPRESSION[][] m_pExpArr = new TASK_EXPRESSION[0][];
		public int m_ulTaskCharCnt { get; set; }
		public short[][] m_pTaskChar = new short[0][];
		public int m_iForceContribution { get; set; }
		public int m_iForceReputation { get; set; }
		public int m_iForceActivity { get; set; }
		public int m_iForceSetRepu { get; set; }
		public int m_iTaskLimit { get; set; }
		public int m_ulTitleNum { get; set; }
		public TITLE_AWARD[] m_pTitleAward = new TITLE_AWARD[0];
		public int m_iLeaderShip { get; set; }
		public int m_iWorldContribution { get; set; }
		public int[] m_iHomeResource = new int[5];
		public bool m_bCreateHome { get; set; }
		public bool AwardLeaveCarrier { get; set; }
		public int AwardFactionMoney { get; set; }
		public int AwardFactionPersonScore { get; set; }
		public int AwardFactionTarget { get; set; }
		public FACTION_TARGET_DATA[] AwardFactionTargetData = new FACTION_TARGET_DATA[0];
		public bool SubmitRankScore { get; set; }
		public SUBMIT_RANK_INFO submit_rank = new SUBMIT_RANK_INFO();
		public int AwardMentorStudent { get; set; }
		public int AwardCoupleIntimacy { get; set; }
		public int AwardRedBookExp { get; set; }
		public int AwardCampScore { get; set; }
		public int AwardCrossServerMoney { get; set; }
		public int InviterAward { get; set; }
		public int AwardFriendPoint { get; set; }
		public int InviterAwardCount { get; set; }
		public int AwardPerceptionValue { get; set; }

		public int m_CandItemsPointer, m_MonstersPointer, m_RankingAwardPointer, m_ulChangeKeyPointer, m_plChangeKeyValuePointer,
		m_pbChangeTypePointer, m_plHistoryChangeKeyPointer, m_plHistoryChangeKeyValuePointer, m_pbHistoryChangeTypePointer,
		m_ulDisplayKeyCntPointer, m_pszExpPointer, m_pExpArrPointer, m_pTaskCharPointer, m_pTitleAwardPointer, AwardFactionTargetDataPointer;

		public static AWARD_DATA Clone(AWARD_DATA award)
		{
			MemoryStream output = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(output);
			BinaryReader binaryStream = new BinaryReader(output);
			Write(9999, bw, award);
			binaryStream.BaseStream.Position = 0;
			AWARD_DATA clone_award = new AWARD_DATA();
			Read(9999, binaryStream, clone_award);
			bw.Close();
			binaryStream.Close();
			output.Close();
			return clone_award;
		}

		internal static void Read(int version, BinaryReader br, AWARD_DATA AWARD_DATA)
		{
			AWARD_DATA.m_ulGoldNum = br.ReadInt32();
			AWARD_DATA.m_ulExp = br.ReadInt32();
			if (version >= 113)
			{
				AWARD_DATA.m_ulRealmExp = br.ReadInt32();
				AWARD_DATA.m_bExpandRealmLevelMax = br.ReadBoolean();
			}
			if (version >= 153)
			{
				AWARD_DATA.NewTaskSpace = br.ReadInt32();
			}
			AWARD_DATA.m_ulNewTask = br.ReadInt32();
			AWARD_DATA.m_ulSP = br.ReadInt32();
			AWARD_DATA.m_lReputation = br.ReadInt32();
			AWARD_DATA.m_ulNewPeriod = br.ReadInt32();
			AWARD_DATA.m_ulNewRelayStation = br.ReadInt32();
			AWARD_DATA.m_ulStorehouseSize = br.ReadInt32();
			if (version >= 57)
			{
				AWARD_DATA.m_ulStorehouseSize2 = br.ReadInt32();
				AWARD_DATA.m_ulStorehouseSize3 = br.ReadInt32();
			}
			if (version >= 75)
			{
				AWARD_DATA.m_ulStorehouseSize4 = br.ReadInt32();
			}
			if (version >= 52)
			{
				AWARD_DATA.m_lInventorySize = br.ReadInt32();
				AWARD_DATA.m_ulPetInventorySize = br.ReadInt32();
			}
			AWARD_DATA.m_ulFuryULimit = br.ReadInt32();
			AWARD_DATA.m_ulTransWldId = br.ReadInt32();
			if (version >= 161)
			{
				AWARD_DATA.CrossServerID = br.ReadInt32();
			}
			ZONE_VERT.Read(version, br, AWARD_DATA.m_TransPt);
			if (version >= 52)
			{
				AWARD_DATA.m_lMonsCtrl = br.ReadInt32();
				AWARD_DATA.m_bTrigCtrl = br.ReadBoolean();
			}
			if (version >= 54)
			{
				AWARD_DATA.m_bUseLevCo = br.ReadBoolean();
			}
			if (version >= 55)
			{
				AWARD_DATA.m_bDivorce = br.ReadBoolean();
			}
			if (version >= 56)
			{
				AWARD_DATA.m_bSendMsg = br.ReadBoolean();
				AWARD_DATA.m_nMsgChannel = br.ReadInt32();
			}
			AWARD_DATA.m_ulCandItems = br.ReadInt32();
			if (version < 176)
			{
				AWARD_DATA.m_CandItemsPointer = br.ReadInt32();
			}
			if (version >= 64)
			{
				AWARD_DATA.m_ulSummonedMonsters = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_MonstersPointer = br.ReadInt32();
				}
			}
			if (version >= 69)
			{
				AWARD_DATA.m_bAwardDeath = br.ReadBoolean();
				AWARD_DATA.m_bAwardDeathWithLoss = br.ReadBoolean();
			}
			if (version >= 75)
			{
				AWARD_DATA.m_ulDividend = br.ReadInt32();
			}
			if (version >= 78)
			{
				AWARD_DATA.m_bAwardSkill = br.ReadBoolean();
				AWARD_DATA.m_iAwardSkillID = br.ReadInt32();
				AWARD_DATA.m_iAwardSkillLevel = br.ReadInt32();
			}
			if (version >= 124)
			{
				AWARD_DATA.m_iSoloTowerChallengeScore = br.ReadInt32();
			}
			if (version >= 153)
			{
				AWARD_DATA.AwardOpenSystem = br.ReadInt32();
			}
			if (version >= 75)
			{
				AWARD_DATA.m_ulSpecifyContribTaskID = br.ReadInt32();
			}
			if (version >= 78)
			{
				AWARD_DATA.m_ulSpecifyContribSubTaskID = br.ReadInt32();
			}
			if (version >= 75)
			{
				AWARD_DATA.m_ulSpecifyContrib = br.ReadInt32();
				AWARD_DATA.m_ulContrib = br.ReadInt32();
				AWARD_DATA.m_ulRandContrib = br.ReadInt32();
				AWARD_DATA.m_ulLowestcontrib = br.ReadInt32();
			}
			if (version >= 87)
			{
				AWARD_DATA.m_iFactionContrib = br.ReadInt32();
			}
			if (version >= 89)
			{
				AWARD_DATA.m_iFactionExpContrib = br.ReadInt32();
			}
			if (version >= 75)
			{
				AWARD_DATA.m_ulPQRankingAwardCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_RankingAwardPointer = br.ReadInt32();
				}
			}
			if (version >= 59)
			{
				AWARD_DATA.m_ulChangeKeyCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_ulChangeKeyPointer = br.ReadInt32();
					AWARD_DATA.m_plChangeKeyValuePointer = br.ReadInt32();
					AWARD_DATA.m_pbChangeTypePointer = br.ReadInt32();
				}
			}
			if (version >= 178)
			{
				AWARD_DATA.PersonChangeKeyCnt = br.ReadInt32();
			}
			if (version >= 112)
			{
				AWARD_DATA.m_ulHistoryChangeCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_plHistoryChangeKeyPointer = br.ReadInt32();
					AWARD_DATA.m_plHistoryChangeKeyValuePointer = br.ReadInt32();
					AWARD_DATA.m_pbHistoryChangeTypePointer = br.ReadInt32();
				}
			}
			if (version >= 59)
			{
				AWARD_DATA.m_bMulti = br.ReadBoolean();
				AWARD_DATA.m_nNumType = br.ReadInt32();
				AWARD_DATA.m_lNum = br.ReadInt32();
				AWARD_DATA.m_ulDisplayKeyCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_ulDisplayKeyCntPointer = br.ReadInt32();
				}
			}
			if (version >= 63)
			{
				AWARD_DATA.m_ulExpCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_pszExpPointer = br.ReadInt32();
					AWARD_DATA.m_pExpArrPointer = br.ReadInt32();
				}
				AWARD_DATA.m_ulTaskCharCnt = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_pTaskCharPointer = br.ReadInt32();
				}
			}
			if (version >= 97)
			{
				AWARD_DATA.m_iForceContribution = br.ReadInt32();
				AWARD_DATA.m_iForceReputation = br.ReadInt32();
				AWARD_DATA.m_iForceActivity = br.ReadInt32();
			}
			if (version >= 100)
			{
				AWARD_DATA.m_iForceSetRepu = br.ReadInt32();
			}
			if (version >= 101)
			{
				AWARD_DATA.m_iTaskLimit = br.ReadInt32();
			}
			if (version >= 109)
			{
				AWARD_DATA.m_ulTitleNum = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.m_pTitleAwardPointer = br.ReadInt32();
				}
			}
			if (version >= 115)
			{
				AWARD_DATA.m_iLeaderShip = br.ReadInt32();
			}
			if (version >= 119)
			{
				AWARD_DATA.m_iWorldContribution = br.ReadInt32();
			}
			if (version >= 126)
			{
				for (int i = 0; i < AWARD_DATA.m_iHomeResource.Length; i++)
				{
					AWARD_DATA.m_iHomeResource[i] = br.ReadInt32();
				}
				AWARD_DATA.m_bCreateHome = br.ReadBoolean();
			}
			if (version >= 135)
			{
				AWARD_DATA.AwardLeaveCarrier = br.ReadBoolean();
			}
			if (version >= 146)
			{
				AWARD_DATA.AwardFactionMoney = br.ReadInt32();
				AWARD_DATA.AwardFactionPersonScore = br.ReadInt32();
				AWARD_DATA.AwardFactionTarget = br.ReadInt32();
				if (version < 176)
				{
					AWARD_DATA.AwardFactionTargetDataPointer = br.ReadInt32();
				}
				AWARD_DATA.SubmitRankScore = br.ReadBoolean();
				SUBMIT_RANK_INFO.Read(version, br, AWARD_DATA.submit_rank);
			}
			if (version >= 156)
			{
				AWARD_DATA.AwardMentorStudent = br.ReadInt32();
				AWARD_DATA.AwardCoupleIntimacy = br.ReadInt32();
			}
			if (version >= 162)
			{
				AWARD_DATA.AwardRedBookExp = br.ReadInt32();
			}
			if (version >= 167)
			{
				AWARD_DATA.AwardCampScore = br.ReadInt32();
				AWARD_DATA.AwardCrossServerMoney = br.ReadInt32();
				AWARD_DATA.InviterAward = br.ReadInt32();
				AWARD_DATA.AwardFriendPoint = br.ReadInt32();
			}
			if (version >= 175)
			{
				AWARD_DATA.InviterAwardCount = br.ReadInt32();
			}
			if (version >= 180)
			{
				AWARD_DATA.AwardPerceptionValue = br.ReadInt32();
			}
			AWARD_DATA.m_CandItems = new AWARD_ITEMS_CAND[AWARD_DATA.m_ulCandItems];
			for (int i = 0; i < AWARD_DATA.m_ulCandItems; i++)
			{
				AWARD_DATA.m_CandItems[i] = new AWARD_ITEMS_CAND();
				AWARD_ITEMS_CAND.Read(version, br, AWARD_DATA.m_CandItems[i]);
			}
			if (version >= 64 && AWARD_DATA.m_ulSummonedMonsters > 0)
			{
				AWARD_DATA.m_SummonedMonsters.m_ulMonsterNum = AWARD_DATA.m_ulSummonedMonsters;
				AWARD_MONSTERS_SUMMONED.Read(version, br, AWARD_DATA.m_SummonedMonsters);
			}
			if (version >= 75 && AWARD_DATA.m_ulPQRankingAwardCnt > 0)
			{
				AWARD_DATA.m_PQRankingAward.m_ulRankingAwardNum = AWARD_DATA.m_ulPQRankingAwardCnt;
				AWARD_PQ_RANKING.Read(version, br, AWARD_DATA.m_PQRankingAward);
			}
			if (version >= 109)
			{
				AWARD_DATA.m_pTitleAward = new TITLE_AWARD[AWARD_DATA.m_ulTitleNum];
				for (int i = 0; i < AWARD_DATA.m_ulTitleNum; i++)
				{
					AWARD_DATA.m_pTitleAward[i] = new TITLE_AWARD();
					TITLE_AWARD.Read(version, br, AWARD_DATA.m_pTitleAward[i]);
				}
			}
			if (version >= 59)
			{
				AWARD_DATA.m_plChangeKey = new int[AWARD_DATA.m_ulChangeKeyCnt];
				AWARD_DATA.m_plChangeKeyValue = new int[AWARD_DATA.m_ulChangeKeyCnt];
				AWARD_DATA.m_pbChangeType = new bool[AWARD_DATA.m_ulChangeKeyCnt];
				for (int i = 0; i < AWARD_DATA.m_ulChangeKeyCnt; i++)
				{
					AWARD_DATA.m_plChangeKey[i] = br.ReadInt32();
					AWARD_DATA.m_plChangeKeyValue[i] = br.ReadInt32();
					AWARD_DATA.m_pbChangeType[i] = br.ReadBoolean();
				}
			}
			if (version >= 178)
			{
				AWARD_DATA.PersonChangeKey = new int[AWARD_DATA.PersonChangeKeyCnt];
				AWARD_DATA.PersonChangeKeyValue = new int[AWARD_DATA.PersonChangeKeyCnt];
				AWARD_DATA.PersonChangeType = new bool[AWARD_DATA.PersonChangeKeyCnt];
				for (int i = 0; i < AWARD_DATA.PersonChangeKeyCnt; i++)
				{
					AWARD_DATA.PersonChangeKey[i] = br.ReadInt32();
					AWARD_DATA.PersonChangeKeyValue[i] = br.ReadInt32();
					AWARD_DATA.PersonChangeType[i] = br.ReadBoolean();
				}
			}
			if (version >= 112)
			{
				AWARD_DATA.m_plHistoryChangeKey = new int[AWARD_DATA.m_ulHistoryChangeCnt];
				AWARD_DATA.m_plHistoryChangeKeyValue = new int[AWARD_DATA.m_ulHistoryChangeCnt];
				AWARD_DATA.m_pbHistoryChangeType = new bool[AWARD_DATA.m_ulHistoryChangeCnt];
				for (int i = 0; i < AWARD_DATA.m_ulHistoryChangeCnt; i++)
				{
					AWARD_DATA.m_plHistoryChangeKey[i] = br.ReadInt32();
					AWARD_DATA.m_plHistoryChangeKeyValue[i] = br.ReadInt32();
					AWARD_DATA.m_pbHistoryChangeType[i] = br.ReadBoolean();
				}
			}
			if (version >= 59)
			{
				AWARD_DATA.m_plDisplayKey = new int[AWARD_DATA.m_ulDisplayKeyCnt];
				for (int i = 0; i < AWARD_DATA.m_ulDisplayKeyCnt; i++)
				{
					AWARD_DATA.m_plDisplayKey[i] = br.ReadInt32();
				}
			}
			if (version >= 63)
			{
				AWARD_DATA.m_pszExp = new char[AWARD_DATA.m_ulExpCnt][];
				AWARD_DATA.m_pExpArr = new TASK_EXPRESSION[AWARD_DATA.m_ulExpCnt][];
				for (int i = 0; i < AWARD_DATA.m_ulExpCnt; i++)
				{
					AWARD_DATA.m_pszExp[i] = GlobalFunctions.ReadChars(GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN, br);
					AWARD_DATA.m_pExpArr[i] = new TASK_EXPRESSION[GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN];
					for (int j = 0; j < AWARD_DATA.m_pExpArr[i].Length; j++)
					{
						AWARD_DATA.m_pExpArr[i][j] = new TASK_EXPRESSION();
						TASK_EXPRESSION.Read(version, br, AWARD_DATA.m_pExpArr[i][j]);
					}
				}
			}
			if (version >= 63)
			{
				AWARD_DATA.m_pTaskChar = new short[AWARD_DATA.m_ulTaskCharCnt][];
				for (int i = 0; i < AWARD_DATA.m_ulTaskCharCnt; i++)
				{
					AWARD_DATA.m_pTaskChar[i] = GlobalFunctions.ReadNameChars(64, br);
				}
			}
			if (version >= 146)
			{
				AWARD_DATA.AwardFactionTargetData = new FACTION_TARGET_DATA[AWARD_DATA.AwardFactionTarget];
				for (int i = 0; i < AWARD_DATA.AwardFactionTarget; i++)
				{
					AWARD_DATA.AwardFactionTargetData[i] = new FACTION_TARGET_DATA();
					FACTION_TARGET_DATA.Read(version, br, AWARD_DATA.AwardFactionTargetData[i]);
				}
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_DATA AWARD_DATA)
		{
			bw.Write(AWARD_DATA.m_ulGoldNum);
			bw.Write(AWARD_DATA.m_ulExp);
			if (version >= 113)
			{
				bw.Write(AWARD_DATA.m_ulRealmExp);
				bw.Write(AWARD_DATA.m_bExpandRealmLevelMax);
			}
			if (version >= 153)
			{
				bw.Write(AWARD_DATA.NewTaskSpace);
			}
			bw.Write(AWARD_DATA.m_ulNewTask);
			bw.Write(AWARD_DATA.m_ulSP);
			bw.Write(AWARD_DATA.m_lReputation);
			bw.Write(AWARD_DATA.m_ulNewPeriod);
			bw.Write(AWARD_DATA.m_ulNewRelayStation);
			bw.Write(AWARD_DATA.m_ulStorehouseSize);
			if (version >= 57)
			{
				bw.Write(AWARD_DATA.m_ulStorehouseSize2);
				bw.Write(AWARD_DATA.m_ulStorehouseSize3);
			}
			if (version >= 75)
			{
				bw.Write(AWARD_DATA.m_ulStorehouseSize4);
			}
			if (version >= 52)
			{
				bw.Write(AWARD_DATA.m_lInventorySize);
				bw.Write(AWARD_DATA.m_ulPetInventorySize);
			}
			bw.Write(AWARD_DATA.m_ulFuryULimit);
			bw.Write(AWARD_DATA.m_ulTransWldId);
			if (version >= 161)
			{
				bw.Write(AWARD_DATA.CrossServerID);
			}
			ZONE_VERT.Write(version, bw, AWARD_DATA.m_TransPt);
			if (version >= 52)
			{
				bw.Write(AWARD_DATA.m_lMonsCtrl);
				bw.Write(AWARD_DATA.m_bTrigCtrl);
			}
			if (version >= 54)
			{
				bw.Write(AWARD_DATA.m_bUseLevCo);
			}
			if (version >= 55)
			{
				bw.Write(AWARD_DATA.m_bDivorce);
			}
			if (version >= 56)
			{
				bw.Write(AWARD_DATA.m_bSendMsg);
				bw.Write(AWARD_DATA.m_nMsgChannel);
			}
			int cand_items_count = GlobalFunctions.GetMaxAwardCandidates(version);
			if (AWARD_DATA.m_ulCandItems > cand_items_count)
			{
				bw.Write(cand_items_count);
			}
			else
			{
				bw.Write(AWARD_DATA.m_ulCandItems);
			}
			if (version < 176)
			{
				bw.Write(AWARD_DATA.m_CandItemsPointer);
			}
			if (version >= 64)
			{
				bw.Write(AWARD_DATA.m_ulSummonedMonsters);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_MonstersPointer);
				}
			}
			if (version >= 69)
			{
				bw.Write(AWARD_DATA.m_bAwardDeath);
				bw.Write(AWARD_DATA.m_bAwardDeathWithLoss);
			}
			if (version >= 75)
			{
				bw.Write(AWARD_DATA.m_ulDividend);
			}
			if (version >= 78)
			{
				bw.Write(AWARD_DATA.m_bAwardSkill);
				bw.Write(AWARD_DATA.m_iAwardSkillID);
				bw.Write(AWARD_DATA.m_iAwardSkillLevel);
			}
			if (version >= 124)
			{
				bw.Write(AWARD_DATA.m_iSoloTowerChallengeScore);
			}
			if (version >= 153)
			{
				bw.Write(AWARD_DATA.AwardOpenSystem);
			}
			if (version >= 75)
			{
				bw.Write(AWARD_DATA.m_ulSpecifyContribTaskID);
			}
			if (version >= 78)
			{
				bw.Write(AWARD_DATA.m_ulSpecifyContribSubTaskID);
			}
			if (version >= 75)
			{
				bw.Write(AWARD_DATA.m_ulSpecifyContrib);
				bw.Write(AWARD_DATA.m_ulContrib);
				bw.Write(AWARD_DATA.m_ulRandContrib);
				bw.Write(AWARD_DATA.m_ulLowestcontrib);
			}
			if (version >= 87)
			{
				bw.Write(AWARD_DATA.m_iFactionContrib);
			}
			if (version >= 89)
			{
				bw.Write(AWARD_DATA.m_iFactionExpContrib);
			}
			if (version >= 75)
			{
				bw.Write(AWARD_DATA.m_ulPQRankingAwardCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_RankingAwardPointer);
				}
			}
			if (version >= 59)
			{
				bw.Write(AWARD_DATA.m_ulChangeKeyCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_ulChangeKeyPointer);
					bw.Write(AWARD_DATA.m_plChangeKeyValuePointer);
					bw.Write(AWARD_DATA.m_pbChangeTypePointer);
				}
			}
			if (version >= 178)
			{
				bw.Write(AWARD_DATA.PersonChangeKeyCnt);
			}
			if (version >= 112)
			{
				bw.Write(AWARD_DATA.m_ulHistoryChangeCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_plHistoryChangeKeyPointer);
					bw.Write(AWARD_DATA.m_plHistoryChangeKeyValuePointer);
					bw.Write(AWARD_DATA.m_pbHistoryChangeTypePointer);
				}
			}
			if (version >= 59)
			{
				bw.Write(AWARD_DATA.m_bMulti);
				bw.Write(AWARD_DATA.m_nNumType);
				bw.Write(AWARD_DATA.m_lNum);
				bw.Write(AWARD_DATA.m_ulDisplayKeyCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_ulDisplayKeyCntPointer);
				}
			}
			if (version >= 63)
			{
				bw.Write(AWARD_DATA.m_ulExpCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_pszExpPointer);
					bw.Write(AWARD_DATA.m_pExpArrPointer);
				}
				bw.Write(AWARD_DATA.m_ulTaskCharCnt);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_pTaskCharPointer);
				}
			}
			if (version >= 97)
			{
				bw.Write(AWARD_DATA.m_iForceContribution);
				bw.Write(AWARD_DATA.m_iForceReputation);
				bw.Write(AWARD_DATA.m_iForceActivity);
			}
			if (version >= 100)
			{
				bw.Write(AWARD_DATA.m_iForceSetRepu);
			}
			if (version >= 101)
			{
				bw.Write(AWARD_DATA.m_iTaskLimit);
			}
			if (version >= 109)
			{
				bw.Write(AWARD_DATA.m_ulTitleNum);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.m_pTitleAwardPointer);
				}
			}
			if (version >= 115)
			{
				bw.Write(AWARD_DATA.m_iLeaderShip);
			}
			if (version >= 119)
			{
				bw.Write(AWARD_DATA.m_iWorldContribution);
			}
			if (version >= 126)
			{
				for (int i = 0; i < AWARD_DATA.m_iHomeResource.Length; i++)
				{
					bw.Write(AWARD_DATA.m_iHomeResource[i]);
				}
				bw.Write(AWARD_DATA.m_bCreateHome);
			}
			if (version >= 135)
			{
				bw.Write(AWARD_DATA.AwardLeaveCarrier);
			}
			if (version >= 146)
			{
				bw.Write(AWARD_DATA.AwardFactionMoney);
				bw.Write(AWARD_DATA.AwardFactionPersonScore);
				bw.Write(AWARD_DATA.AwardFactionTarget);
				if (version < 176)
				{
					bw.Write(AWARD_DATA.AwardFactionTargetDataPointer);
				}
				bw.Write(AWARD_DATA.SubmitRankScore);
				SUBMIT_RANK_INFO.Write(version, bw, AWARD_DATA.submit_rank);
			}
			if (version >= 156)
			{
				bw.Write(AWARD_DATA.AwardMentorStudent);
				bw.Write(AWARD_DATA.AwardCoupleIntimacy);
			}
			if (version >= 162)
			{
				bw.Write(AWARD_DATA.AwardRedBookExp);
			}
			if (version >= 167)
			{
				bw.Write(AWARD_DATA.AwardCampScore);
				bw.Write(AWARD_DATA.AwardCrossServerMoney);
				bw.Write(AWARD_DATA.InviterAward);
				bw.Write(AWARD_DATA.AwardFriendPoint);
			}
			if (version >= 175)
			{
				bw.Write(AWARD_DATA.InviterAwardCount);
			}
			if (version >= 180)
			{
				bw.Write(AWARD_DATA.AwardPerceptionValue);
			}
			for (int i = 0; i < AWARD_DATA.m_ulCandItems && i < cand_items_count; i++)
			{
				AWARD_ITEMS_CAND.Write(version, bw, AWARD_DATA.m_CandItems[i]);
			}
			if (version >= 64 && AWARD_DATA.m_ulSummonedMonsters > 0)
			{
				AWARD_MONSTERS_SUMMONED.Write(version, bw, AWARD_DATA.m_SummonedMonsters);
			}
			if (version >= 75 && AWARD_DATA.m_ulPQRankingAwardCnt > 0)
			{
				AWARD_PQ_RANKING.Write(version, bw, AWARD_DATA.m_PQRankingAward);
			}
			if (version >= 109)
			{
				for (int i = 0; i < AWARD_DATA.m_ulTitleNum; i++)
				{
					TITLE_AWARD.Write(version, bw, AWARD_DATA.m_pTitleAward[i]);
				}
			}
			if (version >= 59)
			{
				for (int i = 0; i < AWARD_DATA.m_ulChangeKeyCnt; i++)
				{
					bw.Write(AWARD_DATA.m_plChangeKey[i]);
					bw.Write(AWARD_DATA.m_plChangeKeyValue[i]);
					bw.Write(AWARD_DATA.m_pbChangeType[i]);
				}
			}
			if (version >= 178)
			{
				for (int i = 0; i < AWARD_DATA.PersonChangeKeyCnt; i++)
				{
					bw.Write(AWARD_DATA.PersonChangeKey[i]);
					bw.Write(AWARD_DATA.PersonChangeKeyValue[i]);
					bw.Write(AWARD_DATA.PersonChangeType[i]);
				}
			}
			if (version >= 112)
			{
				for (int i = 0; i < AWARD_DATA.m_ulHistoryChangeCnt; i++)
				{
					bw.Write(AWARD_DATA.m_plHistoryChangeKey[i]);
					bw.Write(AWARD_DATA.m_plHistoryChangeKeyValue[i]);
					bw.Write(AWARD_DATA.m_pbHistoryChangeType[i]);
				}
			}
			if (version >= 59)
			{
				for (int i = 0; i < AWARD_DATA.m_ulDisplayKeyCnt; i++)
				{
					bw.Write(AWARD_DATA.m_plDisplayKey[i]);
				}
			}
			if (version >= 63)
			{
				for (int i = 0; i < AWARD_DATA.m_ulExpCnt; i++)
				{
					GlobalFunctions.WriteChars(bw, AWARD_DATA.m_pszExp[i]);
					for (int j = 0; j < AWARD_DATA.m_pExpArr[i].Length; j++)
					{
						TASK_EXPRESSION.Write(version, bw, AWARD_DATA.m_pExpArr[i][j]);
					}
				}
			}
			if (version >= 63)
			{
				for (int i = 0; i < AWARD_DATA.m_ulTaskCharCnt; i++)
				{
					GlobalFunctions.WriteNameChars(bw, AWARD_DATA.m_pTaskChar[i]);
				}
			}
			if (version >= 146)
			{
				for (int i = 0; i < AWARD_DATA.AwardFactionTarget; i++)
				{
					FACTION_TARGET_DATA.Write(version, bw, AWARD_DATA.AwardFactionTargetData[i]);
				}
			}
		}
	}
}
//(c)Rey35