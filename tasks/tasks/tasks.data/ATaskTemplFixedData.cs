//(c)Rey35
using System;
using System.IO;

namespace tasks
{
	public class ATaskTemplFixedData
	{
		public short IDSpace;
		public int m_ID;
		public short[] m_szName = new short[GlobalData.MAX_TASK_NAME_LEN];
		public bool m_bHasSign { set; get; }
		public short[] m_pszSignature = new short[0];
		public int m_ulType { set; get; }
		public int m_ulTimeLimit { set; get; }
		public bool m_bOfflineFail { set; get; }
		public bool m_bAbsFail { set; get; }
		public task_tm m_tmAbsFailTime = new task_tm();
		public bool NextFail { set; get; }
		public task_tm NextFailTime = new task_tm();
		public bool m_bItemNotTakeOff { set; get; }
		public bool m_bAbsTime { set; get; }
		public int m_ulTimetable { set; get; }
		public byte[] m_tmType = new byte[GlobalData.MAX_TIMETABLE_SIZE];
		public task_tm[] m_tmStart = new task_tm[0];
		public task_tm[] m_tmEnd = new task_tm[0];
		public int m_lAvailFrequency { set; get; }
		public int m_lPeriodLimit { set; get; } = 1;
		public bool AvailFrequency { set; get; }
		public task_tm AvailFrequencyTime = new task_tm();
		public bool MultiNpcTalk { set; get; }
		public bool m_bChooseOne { set; get; }
		public bool m_bRandOne { set; get; }
		public bool m_bExeChildInOrder { set; get; }
		public bool m_bParentAlsoFail { set; get; } = true;
		public bool m_bParentAlsoSucc { set; get; }
		public bool m_bCanGiveUp { set; get; } = true;
		public bool m_bCanRedo { set; get; } = true;
		public bool m_bCanRedoAfterFailure { set; get; } = true;
		public bool m_bClearAsGiveUp { set; get; }
		public bool m_bNeedRecord { set; get; }
		public bool m_bFailAsPlayerDie { set; get; }
		public int m_ulMaxReceiver { set; get; }
		public bool m_bDelvInZone { set; get; }
		public int m_ulDelvWorld { set; get; } = 1;
		public int m_ulDelvRegionCnt { set; get; }
		public Task_Region[] m_pDelvRegion = new Task_Region[0];
		public bool m_bEnterRegionFail { set; get; }
		public int m_ulEnterRegionWorld { set; get; }
		public int m_ulEnterRegionCnt { set; get; }
		public Task_Region[] m_pEnterRegion = new Task_Region[0];
		public bool m_bLeaveRegionFail { set; get; }
		public int m_ulLeaveRegionWorld { set; get; }
		public int m_ulLeaveRegionCnt { set; get; }
		public Task_Region[] m_pLeaveRegion = new Task_Region[0];
		public bool m_bLeaveForceFail { set; get; }
		public bool m_bTransTo { set; get; }
		public int m_ulTransWldId { set; get; } = 1;
		public ZONE_VERT m_TransPt = new ZONE_VERT();
		public int m_lMonsCtrl { set; get; }
		public bool m_bTrigCtrl { set; get; }
		public bool m_bAutoDeliver { set; get; }
		public bool m_bDisplayInExclusiveUI { set; get; }
		public bool m_bReadyToNotifyServer { set; get; }
		public bool m_bUsedInTokenShop { set; get; }
		public bool m_bDeathTrig { set; get; }
		public bool m_bClearAcquired { set; get; } = true;
		public int m_ulSuitableLevel { set; get; }
		public bool m_bShowPrompt { set; get; } = true;
		public bool m_bKeyTask { set; get; }
		public int m_ulDelvNPC { set; get; }
		public int m_ulAwardNPC { set; get; }
		public bool m_bSkillTask { set; get; }
		public bool m_bCanSeekOut { set; get; }
		public bool m_bShowDirection { set; get; } = true;
		public bool m_bMarriage { set; get; }
		public int m_ulChangeKeyCnt { set; get; }
		public int[] m_plChangeKey = new int[0];
		public int[] m_plChangeKeyValue = new int[0];
		public bool[] m_pbChangeType = new bool[0];
		public int PersonChangeKeyCnt { set; get; }
		public int[] PersonChangeKey = new int[0];
		public int[] PersonChangeKeyValue = new int[0];
		public bool[] PersonChangeType = new bool[0];
		public bool m_bSwitchSceneFail { set; get; }
		public bool m_bHidden { set; get; }
		public bool m_bDeliverySkill { set; get; }
		public int m_iDeliveredSkillID { set; get; }
		public int m_iDeliveredSkillLevel { set; get; }
		public bool m_bShowGfxFinished { set; get; }
		public bool m_bChangePQRanking { set; get; }
		public bool m_bCompareItemAndInventory { set; get; }
		public int m_ulInventorySlotNum { set; get; }
		public bool m_bTowerTask { set; get; }
		public bool m_bHomeTask { set; get; }
		public bool m_bDeliverInHostHome { set; get; }
		public bool m_bFinishInHostHome { set; get; }
		public bool m_bPQTask { set; get; }
		public int m_ulPQExpCnt { set; get; }
		public char[][] m_pszPQExp = new char[0][];
		public TASK_EXPRESSION[][] m_pPQExpArr = new TASK_EXPRESSION[0][];
		public bool m_bPQSubTask { set; get; }
		public bool m_bClearContrib { set; get; }
		public int m_ulMonsterContribCnt { set; get; }
		public MONSTERS_CONTRIB[] m_MonstersContrib = new MONSTERS_CONTRIB[0];
		public int m_iPremNeedRecordTasksNum { set; get; }
		public bool m_bShowByNeedRecordTasksNum { set; get; } = true;
		public int m_iPremiseFactionContrib { set; get; }
		public bool m_bShowByFactionContrib { set; get; } = true;
		public bool m_bAccountTaskLimit { set; get; }
		public bool m_bRoleTaskLimit { set; get; }
		public int m_ulAccountTaskLimitCnt { set; get; }
		public bool m_bLeaveFactionFail { set; get; }
		public bool m_bNotIncCntWhenFailed { set; get; }
		public bool m_bNotClearItemWhenFailed { set; get; }
		public bool m_bDisplayInTitleTaskUI { set; get; }
		public bool CanAwardOnCarrier { set; get; }
		public bool CheckFactionMem { set; get; }
		public int FactionMem { set; get; }
		public bool SpecailLogicTask { set; get; }
		public bool DiscardedTask { set; get; }
		public bool NoCheckTitleGot { set; get; }
		public int CrossServer { set; get; } = 1;
		public int IconStateIDForAwardVar { set; get; }
		public int GlobalKeyForAwardVar { set; get; }
		public int PersonKeyForAwardVar { set; get; }
		public bool RecordFinishCount { set; get; }
		public bool TeamHaveRecaller { set; get; }
		public bool BindedRecaller { set; get; }
		public bool HistoryVarTask { set; get; }
		public bool FailNeedComp { set; get; }
		public int FailExp1AndOrExp2 { set; get; }
		public COMPARE_KEY_VALUE Fail1KeyValue = new COMPARE_KEY_VALUE();
		public COMPARE_KEY_VALUE Fail2KeyValue = new COMPARE_KEY_VALUE();
		public bool DeliverByUI { set; get; }
		public bool WarTaskAward { set; get; }
		public bool HideOtherPlayer { set; get; }
		public int HideOtherPlayerTime { set; get; }
		public int PropMonsterSummonedCnt { set; get; }
		public AWARD_MONSTERS_SUMMONED PropMonsterSummoned = new AWARD_MONSTERS_SUMMONED();
		public int GfxType { set; get; }
		public byte m_ucPremiseTransformedForm { set; get; } = 255;
		public bool m_bShowByTransformed { set; get; }
		public int m_ulPremise_Lev_Min { set; get; }
		public int m_ulPremise_Lev_Max { set; get; }
		public int m_bPremCheckMaxHistoryLevel { set; get; }
		public bool m_bShowByLev { set; get; } = true;
		public bool m_bPremCheckReincarnation { set; get; }
		public int m_ulPremReincarnationMin { set; get; }
		public int m_ulPremReincarnationMax { set; get; }
		public bool m_bShowByReincarnation { set; get; } = true;
		public bool m_bPremCheckRealmLevel { set; get; }
		public int m_ulPremRealmLevelMin { set; get; }
		public int m_ulPremRealmLevelMax { set; get; }
		public bool m_bPremCheckRealmExpFull { set; get; }
		public bool m_bShowByRealmLevel { set; get; } = true;
		public int m_ulPremItems { set; get; }
		public ITEM_WANTED[] m_PremItems = new ITEM_WANTED[0];
		public bool m_bShowByItems { set; get; } = true;
		public bool m_bPremItemsAnyOne { set; get; }
		public bool NotOpenWithItem { set; get; }
		public int m_ulGivenItems { set; get; }
		public int m_ulGivenCmnCount { set; get; }
		public int m_ulGivenTskCount { set; get; }
		public ITEM_WANTED[] m_GivenItems = new ITEM_WANTED[0];
		public int m_ulPremise_Deposit { set; get; }
		public bool m_bShowByDeposit { set; get; } = true;
		public int m_lPremise_Reputation { set; get; }
		public int m_lPremise_RepuMax { set; get; }
		public bool m_bShowByRepu { set; get; } = true;
		public int m_ulPremise_Task_Count { set; get; }
		public int[] m_ulPremise_Tasks = new int[GlobalData.MAX_PREM_TASK_COUNT];
		public short[] PremiseTaskSpace = new short[GlobalData.MAX_PREM_TASK_COUNT];
		public bool m_bShowByPreTask { set; get; } = true;
		public int m_ulPremise_Task_Least_Num { set; get; }
		public int m_ulPremise_Period { set; get; }
		public bool m_bShowByPeriod { set; get; } = true;
		public int m_ulPremise_Faction { set; get; }
		public int m_iPremise_FactionRole { set; get; } = 6;
		public bool m_bShowByFaction { set; get; } = true;
		public int m_ulGender { set; get; }
		public bool m_bShowByGender { set; get; } = true;
		public int m_ulOccupations { set; get; }
		public int[] m_Occupations = new int[GlobalData.MAX_OCCUPATIONS];
		public bool m_bShowByOccup { set; get; } = true;
		public bool m_bPremise_Spouse { set; get; }
		public bool m_bShowBySpouse { set; get; } = true;
		public bool m_bPremiseWeddingOwner { set; get; }
		public bool m_bShowByWeddingOwner { set; get; } = true;
		public bool m_bGM { set; get; }
		public bool m_bShieldUser { set; get; }
		public bool m_bShowByRMB { set; get; } = true;
		public int m_ulPremRMBMin { set; get; }
		public int m_ulPremRMBMax { set; get; }
		public bool m_bCharTime { set; get; }
		public bool m_bShowByCharTime { set; get; } = true;
		public int m_iCharStartTime { set; get; }
		public int m_iCharEndTime { set; get; }
		public task_tm m_tmCharEndTime = new task_tm();
		public int m_ulCharTimeGreaterThan { set; get; }
		public short PremiseCotaskSpace { set; get; }
		public int m_ulPremise_Cotask { set; get; }
		public int m_ulCoTaskCond { set; get; }
		public int m_ulMutexTaskCount { set; get; }
		public short[] MutexTaskSpace = new short[GlobalData.MAX_MUTEX_TASK_COUNT];
		public int[] m_ulMutexTasks = new int[GlobalData.MAX_MUTEX_TASK_COUNT];
		public int[] m_lSkillLev = new int[GlobalData.MAX_LIVING_SKILLS];
		public byte m_DynTaskType { set; get; }
		public int m_ulSpecialAward { set; get; }
		public bool m_bTeamwork { set; get; }
		public bool m_bRcvByTeam { set; get; }
		public bool m_bSharedTask { set; get; }
		public bool m_bSharedAchieved { set; get; }
		public bool m_bCheckTeammate { set; get; }
		public float m_fTeammateDist { set; get; }
		public bool m_bAllFail { set; get; }
		public bool m_bCapFail { set; get; }
		public bool m_bCapSucc { set; get; }
		public float m_fSuccDist { set; get; }
		public bool m_bDismAsSelfFail { set; get; }
		public bool m_bRcvChckMem { set; get; }
		public float m_fRcvMemDist { set; get; }
		public bool m_bCntByMemPos { set; get; }
		public float m_fCntMemDist { set; get; }
		public bool m_bAllSucc { set; get; }
		public bool m_bCoupleOnly { set; get; }
		public bool m_bDistinguishedOcc { set; get; }
		public int m_ulTeamMemsWanted { set; get; }
		public TEAM_MEM_WANTED[] m_TeamMemsWanted = new TEAM_MEM_WANTED[0];
		public bool m_bShowByTeam { set; get; } = true;
		public bool m_bPremNeedComp { set; get; }
		public int m_nPremExp1AndOrExp2 { set; get; }
		public COMPARE_KEY_VALUE m_Prem1KeyValue = new COMPARE_KEY_VALUE();
		public COMPARE_KEY_VALUE m_Prem2KeyValue = new COMPARE_KEY_VALUE();
		public bool PremNeedCompPerson { set; get; }
		public int PremPersonExp1AndOrExp2 { set; get; }
		public COMPARE_KEY_VALUE PremPerson1KeyValue = new COMPARE_KEY_VALUE();
		public COMPARE_KEY_VALUE PremPerson2KeyValue = new COMPARE_KEY_VALUE();
		public bool m_bPremCheckForce { set; get; }
		public int m_iPremForce { set; get; }
		public bool m_bShowByForce { set; get; } = true;
		public int m_iPremForceReputation { set; get; }
		public bool m_bShowByForceReputation { set; get; } = true;
		public int m_iPremForceContribution { set; get; }
		public bool m_bShowByForceContribution { set; get; } = true;
		public int m_iPremForceExp { set; get; }
		public bool m_bShowByForceExp { set; get; } = true;
		public int m_iPremForceSP { set; get; }
		public bool m_bShowByForceSP { set; get; } = true;
		public int m_iPremForceActivityLevel { set; get; } = -1;
		public bool m_bShowByForceActivityLevel { set; get; } = true;
		public bool m_bPremIsKing { set; get; }
		public bool m_bShowByKing { set; get; } = true;
		public bool m_bPremNotInTeam { set; get; }
		public bool m_bShowByNotInTeam { set; get; } = true;
		public int m_iPremTitleNumTotal { set; get; }
		public int m_iPremTitleNumRequired { set; get; }
		public int[] m_PremTitles = new int[0];
		public bool m_bShowByTitle { set; get; }
		public int[] m_iPremHistoryStageIndex = new int[2];
		public bool m_bShowByHistoryStage { set; get; } = true;
		public int m_ulPremGeneralCardCount { set; get; }
		public bool m_bShowByGeneralCard { set; get; } = true;
		public int m_iPremGeneralCardRank { set; get; } = -1;
		public int m_ulPremGeneralCardRankCount { set; get; }
		public bool m_bShowByGeneralCardRank { set; get; } = true;
		public int m_ulPremIconStateID { set; get; }
		public bool m_bShowByIconStateID { set; get; }
		public int m_iVIPLevelMin { set; get; }
		public int m_iVIPLevelMax { set; get; }
		public bool m_bShowByVIPLevel { set; get; }
		public bool PremNoHome { set; get; }
		public int m_iPremHomeLevelMin { set; get; }
		public int m_iPremHomeLevelMax { set; get; }
		public bool m_bShowByHomeLevel { set; get; }
		public int m_iPremHomeResourceLevelType { set; get; }
		public int m_iPremHomeResourceLevelMin { set; get; }
		public int m_iPremHomeResourceLevelMax { set; get; }
		public bool m_bShowByHomeResourceLevel { set; get; }
		public int m_iPremHomeFactoryLevelType { set; get; }
		public int m_iPremHomeFactoryLevelMin { set; get; }
		public int m_iPremHomeFactoryLevelMax { set; get; }
		public bool m_bShowByHomeFactoryLevel { set; get; }
		public int m_iPremHomeFlourishMin { set; get; }
		public int m_iPremHomeFlourishMax { set; get; }
		public bool m_bShowByHomeFlourish { set; get; }
		public bool m_bPremHomeStorageTask { set; get; }
		public bool m_bShowByHomeStorageTask { set; get; }
		public int ArenaWinCount { set; get; }
		public bool PreReachArenaWinCount { set; get; }
		public bool ShowByReachArenaWinCount { set; get; }
		public bool ByFactionScore { set; get; }
		public int PreFactionScore { set; get; }
		public bool ShowByPreFactionScore { set; get; }
		public int PreFactionMoney { set; get; }
		public bool ShowByPreFactionMoney { set; get; }
		public int PreFactionPersonScore { set; get; }
		public bool ShowByPreFactionPersonScore { set; get; }
		public bool BecomeMentor { set; get; }
		public int PremMentorMorality { set; get; }
		public bool ShowMentorMorality { set; get; }
		public int PremMentorStudent { set; get; }
		public bool ShowMentorStudent { set; get; }
		public int PremCoupleIntimacy { set; get; }
		public bool ShowCoupleIntimacy { set; get; }
		public int m_ulPremise_Deposit2 { set; get; }
		public bool m_bShowByDeposit2 { set; get; }
		public int NeededTaskCount { set; get; }
		public short[] NeededTaskSpace = new short[GlobalData.MAX_NEEDED_TASK_COUNT];
		public int[] NeededTask = new int[GlobalData.MAX_NEEDED_TASK_COUNT];
		public byte NeededTaskLeast { set; get; }
		public int PremCamp { set; get; }
		public bool ShowCamp { set; get; }
		public int PremCampPower { set; get; }
		public bool ShowCampPower { set; get; }
		public bool ReturnCampPower { set; get; }
		public int NeedFriendPoint { set; get; }
		public bool ShowNeedFriendPoint { set; get; }
		public bool PremRank { set; get; }
		public int RankType { set; get; }
		public short RankGradeMin { set; get; }
		public short RankGradeMax { set; get; }
		public short RankGradeMinKey { set; get; }
		public short RankGradeMaxKey { set; get; }
		public int m_enumMethod { set; get; }
		public int m_enumFinishType { set; get; }
		public int m_ulPlayerWanted { set; get; }
		public PLAYER_WANTED[] m_PlayerWanted = new PLAYER_WANTED[0];
		public int m_ulMonsterWanted { set; get; }
		public MONSTER_WANTED[] m_MonsterWanted = new MONSTER_WANTED[0];
		public bool MonsterTotalCount { set; get; }
		public int m_ulItemsWanted { set; get; }
		public ITEM_WANTED[] m_ItemsWanted = new ITEM_WANTED[0];
		public int m_ulGoldWanted { set; get; }
		public int m_iFactionContribWanted { set; get; }
		public int m_iFactionExpContribWanted { set; get; }
		public int m_ulNPCToProtect { set; get; }
		public int m_ulProtectTimeLen { set; get; }
		public int m_ulNPCMoving { set; get; }
		public int m_ulNPCDestSite { set; get; }
		public Task_Region[] m_pReachSite = new Task_Region[0];
		public int m_ulReachSiteCnt { set; get; }
		public int m_ulReachSiteId { set; get; } = 1;
		public int m_ulWaitTime { set; get; }
		public ZONE_VERT m_TreasureStartZone = new ZONE_VERT();
		public byte m_ucZonesNumX { set; get; } = 1;
		public byte m_ucZonesNumZ { set; get; } = 1;
		public byte m_ucZoneSide { set; get; } = 10;
		public short treasureZoneMapID { set; get; } = 1;
		public Task_Region[] m_pLeaveSite = new Task_Region[0];
		public int m_ulLeaveSiteCnt { set; get; }
		public int m_ulLeaveSiteId { set; get; }
		public bool m_bFinNeedComp { set; get; } = true;
		public int m_nFinExp1AndOrExp2 { set; get; }
		public COMPARE_KEY_VALUE m_Fin1KeyValue = new COMPARE_KEY_VALUE();
		public COMPARE_KEY_VALUE m_Fin2KeyValue = new COMPARE_KEY_VALUE();
		public bool FinNeedCompPerson { set; get; } = true;
		public int FinPersonExp1AndOrExp2 { set; get; }
		public COMPARE_KEY_VALUE FinPerson1KeyValue = new COMPARE_KEY_VALUE();
		public COMPARE_KEY_VALUE FinPerson2KeyValue = new COMPARE_KEY_VALUE();
		public int m_ulExpCnt { set; get; }
		public char[][] m_pszExp = new char[0][];
		public TASK_EXPRESSION[][] m_pExpArr = new TASK_EXPRESSION[0][];
		public int PersonExpCnt { set; get; }
		public char[][] PersonExp = new char[0][];
		public TASK_EXPRESSION[][] PersonExpArr = new TASK_EXPRESSION[0][];
		public int m_ulTaskCharCnt { set; get; }
		public short[][] m_pTaskChar = new short[0][];
		public int PersonTaskCharCnt { set; get; }
		public short[][] PersonTaskChar = new short[0][];
		public byte m_ucTransformedForm { set; get; }
		public int TransformedDescID { set; get; }
		public int m_ulReachLevel { set; get; }
		public int m_ulReachReincarnationCount { set; get; }
		public int m_ulReachRealmLevel { set; get; }
		public int m_uiEmotion { set; get; }
		public int GrowthTarget { set; get; }
		public int m_ulTMIconStateID { set; get; }
		public int TMIconStateDescID { set; get; }
		public int m_ulTMHomeLevelType { set; get; }
		public int m_ulTMReachHomeLevel { set; get; }
		public int m_ulTMReachHomeFlourish { set; get; }
		public int m_ulHomeItemsWanted { set; get; }
		public HOME_ITEM_WANTED[] m_HomeItemsWanted = new HOME_ITEM_WANTED[0];
		public int TMBindCarrierId { set; get; }
		public int TMReachArenaTime { set; get; }
		public int ReachArenaWinCount { set; get; }
		public short[] Dialog = new short[GlobalData.MAX_DIALOG_LEN];
		public int SuccTriggerEvent { set; get; }
		public int VerifyStateLayer { set; get; }
		public int VerifyStateLayerID { set; get; }
		public int KeyWordIndex { set; get; }
		public short[] TaskEventChar = new short[GlobalData.MAX_TASK_NAME_LEN];
		public int TaskEventType { set; get; }
		public short TaskEventTime { set; get; }
		public short TaskEventMonsterCount { set; get; }
		public TaskEventData[] TaskEventMonsterData = new TaskEventData[0];
		public short TaskEventMineCount { set; get; }
		public TaskEventData[] TaskEventMineData = new TaskEventData[0];
		public short TaskEventTaskCount { set; get; }
		public TaskEventData[] TaskEventTaskData = new TaskEventData[0];
		public short FactionPersonScore { set; get; }
		public byte TMTinyGameType { set; get; }
		public int m_ulGold2Wanted { set; get; }
		public int m_ulAwardType_S { set; get; }
		public int m_ulAwardType_F { set; get; }
		public AWARD_DATA m_Award_S = new AWARD_DATA();
		public AWARD_DATA m_Award_F = new AWARD_DATA();
		public AWARD_RATIO_SCALE m_AwByRatio_S = new AWARD_RATIO_SCALE();
		public AWARD_RATIO_SCALE m_AwByRatio_F = new AWARD_RATIO_SCALE();
		public AWARD_ITEMS_SCALE m_AwByItems_S = new AWARD_ITEMS_SCALE();
		public AWARD_ITEMS_SCALE m_AwByItems_F = new AWARD_ITEMS_SCALE();
		public AWARD_RATIO_SCALE AwByTaskEventRatio_S = new AWARD_RATIO_SCALE();
		public AWARD_RATIO_SCALE AwByTaskEventRatio_F = new AWARD_RATIO_SCALE();
		public AWARD_CARRIER_HP_SCALE AwByCarrierHp_S = new AWARD_CARRIER_HP_SCALE();
		public AWARD_CARRIER_HP_SCALE AwByCarrierHp_F = new AWARD_CARRIER_HP_SCALE();
		public AWARD_VAR_SCALE AwByVar_S = new AWARD_VAR_SCALE();
		public AWARD_VAR_SCALE AwByVar_F = new AWARD_VAR_SCALE();
		public int m_ulParent { set; get; }
		public int m_ulPrevSibling { set; get; }
		public int m_ulNextSibling { set; get; }
		public int m_ulFirstChild { set; get; }
		public bool m_bIsLibraryTask { set; get; }
		public float m_fLibraryTasksProbability { set; get; }
		public bool m_bIsUniqueStorageTask { set; get; }
		public int m_iWorldContribution { set; get; }
		public byte[] CombinedSwitches = new byte[GlobalData.MAX_COMBINED_SWITCHES];
		public bool WriteSpecialLog { set; get; }
		public int SpecialParametersCount { set; get; }
		public SPECIAL_PARAMETERS SpecialParameters = new SPECIAL_PARAMETERS();

		public int m_pszSignaturePointer, m_tmStartPointer, m_tmEndPointer, m_pDelvRegionPointer, m_pEnterRegionPointer,
		m_pLeaveRegionPointer, m_plChangeKeyPointer, m_plChangeKeyValuePointer, m_pbChangeTypePointer, m_pszPQExpPointer,
		m_pPQExpArrPointer, m_MonstersContribPointer, m_PremItemsPointer, m_GivenItemsPointer, m_TeamMemsWantedPointer,
		m_PremTitlesPointer, m_PlayerWantedPointer, m_MonsterWantedPointer, m_ItemsWantedPointer, m_pReachSitePointer,
		m_pLeaveSitePointer, m_pszExpPointer, m_pExpArrPointer, m_pTaskCharPointer, m_HomeItemsWantedPointer,
		TaskEventMonsterDataPointer, TaskEventMineDataPointer, TaskEventTaskDataPointer,
		m_Award_SPointer, m_Award_FPointer, m_AwByRatio_SPointer, m_AwByRatio_FPointer, m_AwByItems_SPointer, m_AwByItems_FPointer,
		AwByTaskEventRatio_SPointer, AwByTaskEventRatio_FPointer, AwByCarrierHp_SPointer, AwByCarrierHp_FPointer, AwByVar_SPointer,
		AwByVar_FPointer, SpecialParametersPointer;

		public string Name
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_szName);
			}
			set
			{
				this.m_szName = tasksConvert.encrypt(this.m_ID, value, GlobalData.MAX_TASK_NAME_LEN, false);
			}
		}
		public string Signature
		{
			get
			{
				return tasksConvert.decrypt(this.m_ID, this.m_pszSignature);
			}
			set
			{
				this.m_pszSignature = tasksConvert.encrypt(this.m_ID, value, GlobalData.MAX_TASK_NAME_LEN, false);
			}
		}

		public void ReadATaskTemplFixedData(int version, BinaryReader br)
		{
			if (version >= 153)
			{
				this.IDSpace = br.ReadInt16();
			}
			this.m_ID = br.ReadInt32();
			this.m_szName = GlobalFunctions.ReadNameChars(GlobalData.MAX_TASK_NAME_LEN, br);
			if (version < 135)
			{
				this.m_bHasSign = br.ReadBoolean();
			}
			if (version < 176)
			{
				this.m_pszSignaturePointer = br.ReadInt32();
			}
			this.m_ulType = br.ReadInt32();
			this.m_ulTimeLimit = br.ReadInt32();
			if (version >= 68)
			{
				if (version < 135)
				{
					this.m_bOfflineFail = br.ReadBoolean();
				}
				this.m_bAbsFail = br.ReadBoolean();
				task_tm.Read(version, br, this.m_tmAbsFailTime);
				if (version >= 175)
				{
					this.NextFail = br.ReadBoolean();
					task_tm.Read(version, br, this.NextFailTime);
				}
				if (version < 135)
				{
					this.m_bItemNotTakeOff = br.ReadBoolean();
				}
			}
			if (version >= 52 && version < 135)
			{
				this.m_bAbsTime = br.ReadBoolean();
			}
			this.m_ulTimetable = br.ReadInt32();
			if (version >= 52)
			{
				int timetable_count = GlobalFunctions.GetMaxTimetableSize(version);
				for (int i = 0; i < timetable_count; i++)
				{
					this.m_tmType[i] = br.ReadByte();
				}
			}
			if (version < 176)
			{
				this.m_tmStartPointer = br.ReadInt32();
				this.m_tmEndPointer = br.ReadInt32();
			}
			if (version >= 52)
			{
				this.m_lAvailFrequency = br.ReadInt32();
			}
			if (version >= 85)
			{
				this.m_lPeriodLimit = br.ReadInt32();
			}
			if (version >= 175)
			{
				this.AvailFrequency = br.ReadBoolean();
				task_tm.Read(version, br, this.AvailFrequencyTime);
			}
			if (version < 135)
			{
				this.m_bChooseOne = br.ReadBoolean();
				this.m_bRandOne = br.ReadBoolean();
				this.m_bExeChildInOrder = br.ReadBoolean();
				this.m_bParentAlsoFail = br.ReadBoolean();
				this.m_bParentAlsoSucc = br.ReadBoolean();
				this.m_bCanGiveUp = br.ReadBoolean();
				this.m_bCanRedo = br.ReadBoolean();
				this.m_bCanRedoAfterFailure = br.ReadBoolean();
				this.m_bClearAsGiveUp = br.ReadBoolean();
				this.m_bNeedRecord = br.ReadBoolean();
				this.m_bFailAsPlayerDie = br.ReadBoolean();
			}
			this.m_ulMaxReceiver = br.ReadInt32();
			if (version < 135)
			{
				this.m_bDelvInZone = br.ReadBoolean();
			}
			this.m_ulDelvWorld = br.ReadInt32();
			if (version >= 80)
			{
				this.m_ulDelvRegionCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_pDelvRegionPointer = br.ReadInt32();
				}
			}
			else
			{
				this.m_ulDelvRegionCnt = 1;
				this.m_pDelvRegion = new Task_Region[this.m_ulDelvRegionCnt];
				this.m_pDelvRegion[0] = new Task_Region();
				Task_Region.Read(version, br, this.m_pDelvRegion[0]);
				this.m_pDelvRegion[0].MapID = this.m_ulDelvWorld;
			}
			if (version >= 68)
			{
				if (version < 135)
				{
					this.m_bEnterRegionFail = br.ReadBoolean();
				}
				this.m_ulEnterRegionWorld = br.ReadInt32();
				if (version >= 80)
				{
					this.m_ulEnterRegionCnt = br.ReadInt32();
					if (version < 176)
					{
						this.m_pEnterRegionPointer = br.ReadInt32();
					}
				}
				else
				{
					this.m_ulEnterRegionCnt = 1;
					this.m_pEnterRegion = new Task_Region[this.m_ulEnterRegionCnt];
					this.m_pEnterRegion[0] = new Task_Region();
					Task_Region.Read(version, br, this.m_pEnterRegion[0]);
					this.m_pEnterRegion[0].MapID = this.m_ulEnterRegionWorld;
				}
			}
			else
			{
				this.m_pEnterRegion = new Task_Region[0];
			}
			if (version >= 68)
			{
				if (version < 135)
				{
					this.m_bLeaveRegionFail = br.ReadBoolean();
				}
				this.m_ulLeaveRegionWorld = br.ReadInt32();
				if (version >= 80)
				{
					this.m_ulLeaveRegionCnt = br.ReadInt32();
					if (version < 176)
					{
						this.m_pLeaveRegionPointer = br.ReadInt32();
					}
				}
				else
				{
					this.m_ulLeaveRegionCnt = 1;
					this.m_pLeaveRegion = new Task_Region[this.m_ulLeaveRegionCnt];
					this.m_pLeaveRegion[0] = new Task_Region();
					Task_Region.Read(version, br, this.m_pLeaveRegion[0]);
					this.m_pLeaveRegion[0].MapID = this.m_ulLeaveRegionWorld;
				}
			}
			else
			{
				this.m_pLeaveRegion = new Task_Region[0];
			}
			if (version >= 97 && version < 135)
			{
				this.m_bLeaveForceFail = br.ReadBoolean();
			}
			if (version < 135)
			{
				this.m_bTransTo = br.ReadBoolean();
			}
			this.m_ulTransWldId = br.ReadInt32();
			ZONE_VERT.Read(version, br, this.m_TransPt);
			if (version >= 52)
			{
				this.m_lMonsCtrl = br.ReadInt32();
				if (version < 135)
				{
					this.m_bTrigCtrl = br.ReadBoolean();
				}
			}
			if (version < 135)
			{
				this.m_bAutoDeliver = br.ReadBoolean();
				if (version >= 84)
				{
					this.m_bDisplayInExclusiveUI = br.ReadBoolean();
				}
				if (version >= 89)
				{
					this.m_bReadyToNotifyServer = br.ReadBoolean();
				}
				if (version >= 116)
				{
					this.m_bUsedInTokenShop = br.ReadBoolean();
				}
				this.m_bDeathTrig = br.ReadBoolean();
				this.m_bClearAcquired = br.ReadBoolean();
			}
			this.m_ulSuitableLevel = br.ReadInt32();
			if (version < 135)
			{
				this.m_bShowPrompt = br.ReadBoolean();
				this.m_bKeyTask = br.ReadBoolean();
			}
			this.m_ulDelvNPC = br.ReadInt32();
			this.m_ulAwardNPC = br.ReadInt32();
			if (version < 135)
			{
				this.m_bSkillTask = br.ReadBoolean();
				if (version >= 52)
				{
					this.m_bCanSeekOut = br.ReadBoolean();
					this.m_bShowDirection = br.ReadBoolean();
				}
				if (version >= 55)
				{
					this.m_bMarriage = br.ReadBoolean();
				}
			}
			if (version >= 59)
			{
				this.m_ulChangeKeyCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_plChangeKeyPointer = br.ReadInt32();
					this.m_plChangeKeyValuePointer = br.ReadInt32();
					this.m_pbChangeTypePointer = br.ReadInt32();
				}
			}
			if (version >= 178)
			{
				this.PersonChangeKeyCnt = br.ReadInt32();
			}
			if (version >= 63 && version < 135)
			{
				this.m_bSwitchSceneFail = br.ReadBoolean();
				this.m_bHidden = br.ReadBoolean();
			}
			if (version >= 78)
			{
				if (version < 135)
				{
					this.m_bDeliverySkill = br.ReadBoolean();
				}
				this.m_iDeliveredSkillID = br.ReadInt32();
				this.m_iDeliveredSkillLevel = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowGfxFinished = br.ReadBoolean();
				}
			}
			if (version >= 79 && version < 135)
			{
				this.m_bChangePQRanking = br.ReadBoolean();
			}
			if (version >= 81)
			{
				if (version < 135)
				{
					this.m_bCompareItemAndInventory = br.ReadBoolean();
				}
				this.m_ulInventorySlotNum = br.ReadInt32();
			}
			if (version < 135)
			{
				if (version >= 123)
				{
					this.m_bTowerTask = br.ReadBoolean();
				}
				if (version >= 126)
				{
					this.m_bHomeTask = br.ReadBoolean();
				}
				if (version >= 128)
				{
					this.m_bDeliverInHostHome = br.ReadBoolean();
					this.m_bFinishInHostHome = br.ReadBoolean();
				}
			}
			if (version >= 75)
			{
				if (version < 135)
				{
					this.m_bPQTask = br.ReadBoolean();
				}
				this.m_ulPQExpCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_pszPQExpPointer = br.ReadInt32();
					this.m_pPQExpArrPointer = br.ReadInt32();
				}
				if (version < 135)
				{
					this.m_bPQSubTask = br.ReadBoolean();
					this.m_bClearContrib = br.ReadBoolean();
				}
				this.m_ulMonsterContribCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_MonstersContribPointer = br.ReadInt32();
				}
			}
			if (version >= 91)
			{
				this.m_iPremNeedRecordTasksNum = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByNeedRecordTasksNum = br.ReadBoolean();
				}
			}
			if (version >= 87)
			{
				this.m_iPremiseFactionContrib = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByFactionContrib = br.ReadBoolean();
				}
			}
			if (version < 135)
			{
				if (version >= 75)
				{
					this.m_bAccountTaskLimit = br.ReadBoolean();
				}
				if (version >= 115)
				{
					this.m_bRoleTaskLimit = br.ReadBoolean();
				}
			}
			if (version >= 75)
			{
				this.m_ulAccountTaskLimitCnt = br.ReadInt32();
			}
			if (version < 135)
			{
				if (version >= 105)
				{
					this.m_bLeaveFactionFail = br.ReadBoolean();
				}
				if (version >= 111)
				{
					this.m_bNotIncCntWhenFailed = br.ReadBoolean();
				}
				if (version >= 108)
				{
					this.m_bNotClearItemWhenFailed = br.ReadBoolean();
				}
				if (version >= 110)
				{
					this.m_bDisplayInTitleTaskUI = br.ReadBoolean();
				}
			}
			if (version >= 146)
			{
				this.FactionMem = br.ReadInt32();
			}
			if (version >= 161)
			{
				this.CrossServer = br.ReadInt32();
				this.IconStateIDForAwardVar = br.ReadInt32();
				this.GlobalKeyForAwardVar = br.ReadInt32();
			}
			if (version >= 178)
			{
				this.PersonKeyForAwardVar = br.ReadInt32();
			}
			if (version >= 175)
			{
				this.FailNeedComp = br.ReadBoolean();
				this.FailExp1AndOrExp2 = br.ReadInt32();
				COMPARE_KEY_VALUE.Read(version, br, this.Fail1KeyValue);
				COMPARE_KEY_VALUE.Read(version, br, this.Fail2KeyValue);
			}
			if (version >= 180)
			{
				this.HideOtherPlayerTime = br.ReadInt32();
				this.PropMonsterSummonedCnt = br.ReadInt32();
			}
			AWARD_MONSTERS_SUMMONED.Read2(version, br, this.PropMonsterSummoned);
			if (version >= 181)
			{
				this.GfxType = br.ReadInt32();
			}
			if (version >= 96)
			{
				this.m_ucPremiseTransformedForm = br.ReadByte();
				if (version < 135)
				{
					this.m_bShowByTransformed = br.ReadBoolean();
				}
			}
			this.m_ulPremise_Lev_Min = br.ReadInt32();
			this.m_ulPremise_Lev_Max = br.ReadInt32();
			if (version >= 113)
			{
				this.m_bPremCheckMaxHistoryLevel = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByLev = br.ReadBoolean();
			}
			if (version >= 113)
			{
				if (version < 135)
				{
					this.m_bPremCheckReincarnation = br.ReadBoolean();
				}
				this.m_ulPremReincarnationMin = br.ReadInt32();
				this.m_ulPremReincarnationMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByReincarnation = br.ReadBoolean();
					this.m_bPremCheckRealmLevel = br.ReadBoolean();
				}
				this.m_ulPremRealmLevelMin = br.ReadInt32();
				this.m_ulPremRealmLevelMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bPremCheckRealmExpFull = br.ReadBoolean();
					this.m_bShowByRealmLevel = br.ReadBoolean();
				}
			}
			this.m_ulPremItems = br.ReadInt32();
			if (version < 176)
			{
				this.m_PremItemsPointer = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByItems = br.ReadBoolean();
				if (version >= 98)
				{
					this.m_bPremItemsAnyOne = br.ReadBoolean();
				}
			}
			this.m_ulGivenItems = br.ReadInt32();
			this.m_ulGivenCmnCount = br.ReadInt32();
			this.m_ulGivenTskCount = br.ReadInt32();
			if (version < 176)
			{
				this.m_GivenItemsPointer = br.ReadInt32();
			}
			this.m_ulPremise_Deposit = br.ReadInt32();
			if (version < 135)
			{
				this.m_bShowByDeposit = br.ReadBoolean();
			}
			this.m_lPremise_Reputation = br.ReadInt32();
			if (version >= 53)
			{
				this.m_lPremise_RepuMax = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByRepu = br.ReadBoolean();
			}
			this.m_ulPremise_Task_Count = br.ReadInt32();
			int premise_tasks_count = GlobalFunctions.GetMaxPremTaskCount(version);
			for (int i = 0; i < premise_tasks_count; i++)
			{
				this.m_ulPremise_Tasks[i] = br.ReadInt32();
			}
			if (version >= 153)
			{
				for (int i = 0; i < premise_tasks_count; i++)
				{
					this.PremiseTaskSpace[i] = br.ReadInt16();
				}
			}
			if (version < 135)
			{
				this.m_bShowByPreTask = br.ReadBoolean();
			}
			if (version >= 90)
			{
				this.m_ulPremise_Task_Least_Num = br.ReadInt32();
			}
			this.m_ulPremise_Period = br.ReadInt32();
			if (version < 135)
			{
				this.m_bShowByPeriod = br.ReadBoolean();
			}
			this.m_ulPremise_Faction = br.ReadInt32();
			if (version >= 93)
			{
				this.m_iPremise_FactionRole = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByFaction = br.ReadBoolean();
			}
			this.m_ulGender = br.ReadInt32();
			if (version < 135)
			{
				this.m_bShowByGender = br.ReadBoolean();
			}
			this.m_ulOccupations = br.ReadInt32();
			int occupations_cout = GlobalFunctions.GetMaxOccupations(version);
			for (int i = 0; i < occupations_cout; i++)
			{
				this.m_Occupations[i] = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByOccup = br.ReadBoolean();
				this.m_bPremise_Spouse = br.ReadBoolean();
				this.m_bShowBySpouse = br.ReadBoolean();
				if (version >= 102)
				{
					this.m_bPremiseWeddingOwner = br.ReadBoolean();
					this.m_bShowByWeddingOwner = br.ReadBoolean();
				}
			}
			if (version < 135)
			{
				if (version >= 52)
				{
					this.m_bGM = br.ReadBoolean();
				}
				if (version >= 68)
				{
					this.m_bShieldUser = br.ReadBoolean();
				}
			}
			if (version >= 75)
			{
				if (version < 135)
				{
					this.m_bShowByRMB = br.ReadBoolean();
				}
				this.m_ulPremRMBMin = br.ReadInt32();
				this.m_ulPremRMBMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bCharTime = br.ReadBoolean();
					this.m_bShowByCharTime = br.ReadBoolean();
				}
				this.m_iCharStartTime = br.ReadInt32();
				this.m_iCharEndTime = br.ReadInt32();
				task_tm.Read(version, br, this.m_tmCharEndTime);
				this.m_ulCharTimeGreaterThan = br.ReadInt32();
			}
			if (version >= 153)
			{
				this.PremiseCotaskSpace = br.ReadInt16();
			}
			this.m_ulPremise_Cotask = br.ReadInt32();
			this.m_ulCoTaskCond = br.ReadInt32();
			this.m_ulMutexTaskCount = br.ReadInt32();
			if (version >= 153)
			{
				for (int i = 0; i < this.MutexTaskSpace.Length; i++)
				{
					this.MutexTaskSpace[i] = br.ReadInt16();
				}
			}
			for (int i = 0; i < this.m_ulMutexTasks.Length; i++)
			{
				this.m_ulMutexTasks[i] = br.ReadInt32();
			}
			for (int i = 0; i < this.m_lSkillLev.Length; i++)
			{
				this.m_lSkillLev[i] = br.ReadInt32();
			}
			this.m_DynTaskType = br.ReadByte();
			this.m_ulSpecialAward = br.ReadInt32();
			if (version < 135)
			{
				this.m_bTeamwork = br.ReadBoolean();
				this.m_bRcvByTeam = br.ReadBoolean();
				this.m_bSharedTask = br.ReadBoolean();
				this.m_bSharedAchieved = br.ReadBoolean();
				this.m_bCheckTeammate = br.ReadBoolean();
			}
			this.m_fTeammateDist = br.ReadSingle();
			if (version < 135)
			{
				this.m_bAllFail = br.ReadBoolean();
				this.m_bCapFail = br.ReadBoolean();
				this.m_bCapSucc = br.ReadBoolean();
			}
			this.m_fSuccDist = br.ReadSingle();
			if (version < 135)
			{
				this.m_bDismAsSelfFail = br.ReadBoolean();
				this.m_bRcvChckMem = br.ReadBoolean();
			}
			this.m_fRcvMemDist = br.ReadSingle();
			if (version < 135)
			{
				this.m_bCntByMemPos = br.ReadBoolean();
			}
			this.m_fCntMemDist = br.ReadSingle();
			if (version < 135)
			{
				if (version >= 68)
				{
					this.m_bAllSucc = br.ReadBoolean();
				}
				if (version >= 75)
				{
					this.m_bCoupleOnly = br.ReadBoolean();
				}
				if (version >= 86)
				{
					this.m_bDistinguishedOcc = br.ReadBoolean();
				}
			}
			this.m_ulTeamMemsWanted = br.ReadInt32();
			if (version < 176)
			{
				this.m_TeamMemsWantedPointer = br.ReadInt32();
			}
			if (version < 135)
			{
				this.m_bShowByTeam = br.ReadBoolean();
			}
			if (version >= 59)
			{
				if (version < 135)
				{
					this.m_bPremNeedComp = br.ReadBoolean();
				}
				this.m_nPremExp1AndOrExp2 = br.ReadInt32();
				COMPARE_KEY_VALUE.Read(version, br, this.m_Prem1KeyValue);
				COMPARE_KEY_VALUE.Read(version, br, this.m_Prem2KeyValue);
			}
			if (version >= 178)
			{
				this.PremPersonExp1AndOrExp2 = br.ReadInt32();
				COMPARE_KEY_VALUE.Read(version, br, this.PremPerson1KeyValue);
				COMPARE_KEY_VALUE.Read(version, br, this.PremPerson2KeyValue);
			}
			if (version >= 97)
			{
				if (version < 135)
				{
					this.m_bPremCheckForce = br.ReadBoolean();
				}
				this.m_iPremForce = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForce = br.ReadBoolean();
				}
				this.m_iPremForceReputation = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForceReputation = br.ReadBoolean();
				}
				this.m_iPremForceContribution = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForceContribution = br.ReadBoolean();
				}
				this.m_iPremForceExp = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForceExp = br.ReadBoolean();
				}
				this.m_iPremForceSP = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForceSP = br.ReadBoolean();
				}
			}
			if (version >= 99)
			{
				this.m_iPremForceActivityLevel = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByForceActivityLevel = br.ReadBoolean();
				}
			}
			if (version < 135)
			{
				if (version >= 106)
				{
					this.m_bPremIsKing = br.ReadBoolean();
					this.m_bShowByKing = br.ReadBoolean();
				}
				if (version >= 107)
				{
					this.m_bPremNotInTeam = br.ReadBoolean();
					this.m_bShowByNotInTeam = br.ReadBoolean();
				}
			}
			if (version >= 109)
			{
				this.m_iPremTitleNumTotal = br.ReadInt32();
				this.m_iPremTitleNumRequired = br.ReadInt32();
				if (version < 176)
				{
					this.m_PremTitlesPointer = br.ReadInt32();
				}
				if (version < 135)
				{
					this.m_bShowByTitle = br.ReadBoolean();
				}
			}
			if (version >= 112)
			{
				for (int i = 0; i < this.m_iPremHistoryStageIndex.Length; i++)
				{
					this.m_iPremHistoryStageIndex[i] = br.ReadInt32();
				}
			}
			if (version < 135)
			{
				if (version >= 118)
				{
					this.m_bShowByHistoryStage = br.ReadBoolean();
				}
			}
			if (version >= 114)
			{
				this.m_ulPremGeneralCardCount = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByGeneralCard = br.ReadBoolean();
				}
			}
			if (version >= 117)
			{
				this.m_iPremGeneralCardRank = br.ReadInt32();
				this.m_ulPremGeneralCardRankCount = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByGeneralCardRank = br.ReadBoolean();
				}
			}
			if (version >= 122)
			{
				this.m_ulPremIconStateID = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByIconStateID = br.ReadBoolean();
				}
			}
			if (version >= 125)
			{
				this.m_iVIPLevelMin = br.ReadInt32();
				this.m_iVIPLevelMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByVIPLevel = br.ReadBoolean();
				}
			}
			if (version >= 129 && version < 135)
			{
				this.PremNoHome = br.ReadBoolean();
			}
			if (version >= 126)
			{
				this.m_iPremHomeLevelMin = br.ReadInt32();
				this.m_iPremHomeLevelMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByHomeLevel = br.ReadBoolean();
				}
				this.m_iPremHomeResourceLevelType = br.ReadInt32();
				this.m_iPremHomeResourceLevelMin = br.ReadInt32();
				this.m_iPremHomeResourceLevelMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByHomeResourceLevel = br.ReadBoolean();
				}
				this.m_iPremHomeFactoryLevelType = br.ReadInt32();
				this.m_iPremHomeFactoryLevelMin = br.ReadInt32();
				this.m_iPremHomeFactoryLevelMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByHomeFactoryLevel = br.ReadBoolean();
				}
				this.m_iPremHomeFlourishMin = br.ReadInt32();
				this.m_iPremHomeFlourishMax = br.ReadInt32();
				if (version < 135)
				{
					this.m_bShowByHomeFlourish = br.ReadBoolean();
					this.m_bPremHomeStorageTask = br.ReadBoolean();
					this.m_bShowByHomeStorageTask = br.ReadBoolean();
				}
			}
			if (version >= 137)
			{
				this.ArenaWinCount = br.ReadInt32();
			}
			if (version >= 146)
			{
				this.PreFactionScore = br.ReadInt32();
				this.PreFactionMoney = br.ReadInt32();
				this.PreFactionPersonScore = br.ReadInt32();
			}
			if (version >= 153)
			{
				this.PremMentorMorality = br.ReadInt32();
				this.PremMentorStudent = br.ReadInt32();
			}
			if (version >= 156)
			{
				this.PremCoupleIntimacy = br.ReadInt32();
			}
			if (version >= 158)
			{
				this.m_ulPremise_Deposit2 = br.ReadInt32();
			}
			if (version >= 161)
			{
				this.NeededTaskCount = br.ReadInt32();
				for (int i = 0; i < this.NeededTaskSpace.Length; i++)
				{
					this.NeededTaskSpace[i] = br.ReadInt16();
				}
				for (int i = 0; i < this.NeededTask.Length; i++)
				{
					this.NeededTask[i] = br.ReadInt32();
				}
				this.NeededTaskLeast = br.ReadByte();
			}
			if (version >= 167)
			{
				this.PremCamp = br.ReadInt32();
				this.PremCampPower = br.ReadInt32();
				this.NeedFriendPoint = br.ReadInt32();
			}
			if (version >= 175)
			{
				this.RankType = br.ReadInt32();
				this.RankGradeMin = br.ReadInt16();
				this.RankGradeMax = br.ReadInt16();
				this.RankGradeMinKey = br.ReadInt16();
				this.RankGradeMaxKey = br.ReadInt16();
			}
			this.m_enumMethod = br.ReadInt32();
			this.m_enumFinishType = br.ReadInt32();
			if (version >= 103)
			{
				this.m_ulPlayerWanted = br.ReadInt32();
				if (version < 176)
				{
					this.m_PlayerWantedPointer = br.ReadInt32();
				}
			}
			this.m_ulMonsterWanted = br.ReadInt32();
			if (version < 176)
			{
				this.m_MonsterWantedPointer = br.ReadInt32();
			}
			this.m_ulItemsWanted = br.ReadInt32();
			if (version < 176)
			{
				this.m_ItemsWantedPointer = br.ReadInt32();
			}
			this.m_ulGoldWanted = br.ReadInt32();
			if (version >= 88)
			{
				this.m_iFactionContribWanted = br.ReadInt32();
			}
			if (version >= 89)
			{
				this.m_iFactionExpContribWanted = br.ReadInt32();
			}
			this.m_ulNPCToProtect = br.ReadInt32();
			this.m_ulProtectTimeLen = br.ReadInt32();
			this.m_ulNPCMoving = br.ReadInt32();
			this.m_ulNPCDestSite = br.ReadInt32();
			if (version >= 80)
			{
				if (version < 176)
				{
					this.m_pReachSitePointer = br.ReadInt32();
				}
				this.m_ulReachSiteCnt = br.ReadInt32();
				this.m_ulReachSiteId = br.ReadInt32();
			}
			else
			{
				this.m_ulReachSiteCnt = 1;
				this.m_pReachSite = new Task_Region[this.m_ulReachSiteCnt];
				this.m_pReachSite[0] = new Task_Region();
				Task_Region.Read(version, br, this.m_pReachSite[0]);
				this.m_ulReachSiteId = br.ReadInt32();
				this.m_pReachSite[0].MapID = this.m_ulReachSiteId;
			}
			this.m_ulWaitTime = br.ReadInt32();
			if (version >= 94)
			{
				ZONE_VERT.Read(version, br, this.m_TreasureStartZone);
				this.m_ucZonesNumX = br.ReadByte();
				this.m_ucZonesNumZ = br.ReadByte();
				this.m_ucZoneSide = br.ReadByte();
			}
			if (version >= 137)
			{
				this.treasureZoneMapID = br.ReadInt16();
			}
			if (version >= 69)
			{
				if (version >= 80)
				{
					if (version < 176)
					{
						this.m_pLeaveSitePointer = br.ReadInt32();
					}
					this.m_ulLeaveSiteCnt = br.ReadInt32();
					this.m_ulLeaveSiteId = br.ReadInt32();
				}
				else
				{
					this.m_ulLeaveSiteCnt = 1;
					this.m_pLeaveSite = new Task_Region[this.m_ulLeaveSiteCnt];
					this.m_pLeaveSite[0] = new Task_Region();
					Task_Region.Read(version, br, this.m_pLeaveSite[0]);
					this.m_ulLeaveSiteId = br.ReadInt32();
					this.m_pLeaveSite[0].MapID = this.m_ulLeaveSiteId;
				}
			}
			else
			{
				this.m_pLeaveSite = new Task_Region[0];
			}
			if (version >= 59)
			{
				if (version < 135)
				{
					this.m_bFinNeedComp = br.ReadBoolean();
				}
				this.m_nFinExp1AndOrExp2 = br.ReadInt32();
				COMPARE_KEY_VALUE.Read(version, br, this.m_Fin1KeyValue);
				COMPARE_KEY_VALUE.Read(version, br, this.m_Fin2KeyValue);
			}
			if (version >= 178)
			{
				this.FinPersonExp1AndOrExp2 = br.ReadInt32();
				COMPARE_KEY_VALUE.Read(version, br, this.FinPerson1KeyValue);
				COMPARE_KEY_VALUE.Read(version, br, this.FinPerson2KeyValue);
			}
			if (version >= 63)
			{
				this.m_ulExpCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_pszExpPointer = br.ReadInt32();
					this.m_pExpArrPointer = br.ReadInt32();
				}
			}
			if (version >= 178)
			{
				this.PersonExpCnt = br.ReadInt32();
			}
			if (version >= 63)
			{
				this.m_ulTaskCharCnt = br.ReadInt32();
				if (version < 176)
				{
					this.m_pTaskCharPointer = br.ReadInt32();
				}
			}
			if (version >= 178)
			{
				this.PersonTaskCharCnt = br.ReadInt32();
			}
			if (version >= 104)
			{
				this.m_ucTransformedForm = br.ReadByte();
			}
			if (version >= 156 && version < 175)
			{
				this.TransformedDescID = br.ReadInt32();
			}
			if (version >= 113)
			{
				this.m_ulReachLevel = br.ReadInt32();
				this.m_ulReachReincarnationCount = br.ReadInt32();
				this.m_ulReachRealmLevel = br.ReadInt32();
				this.m_uiEmotion = br.ReadInt32();
			}
			if (version >= 153)
			{
				this.GrowthTarget = br.ReadInt32();
			}
			if (version >= 122)
			{
				this.m_ulTMIconStateID = br.ReadInt32();
			}
			if (version >= 156 && version < 175)
			{
				this.TMIconStateDescID = br.ReadInt32();
			}
			if (version >= 127)
			{
				this.m_ulTMHomeLevelType = br.ReadInt32();
			}
			if (version >= 126)
			{
				this.m_ulTMReachHomeLevel = br.ReadInt32();
				this.m_ulTMReachHomeFlourish = br.ReadInt32();
				this.m_ulHomeItemsWanted = br.ReadInt32();
				if (version < 176)
				{
					this.m_HomeItemsWantedPointer = br.ReadInt32();
				}
			}
			if (version >= 135)
			{
				this.TMBindCarrierId = br.ReadInt32();
				if (version >= 140)
				{
					this.TMReachArenaTime = br.ReadInt16();
				}
				else
				{
					this.TMReachArenaTime = br.ReadInt32();
				}
			}
			if (version >= 137)
			{
				if (version >= 140)
				{
					this.ReachArenaWinCount = br.ReadInt16();
				}
				else
				{
					this.ReachArenaWinCount = br.ReadInt32();
				}
			}
			if (version >= 156)
			{
				this.Dialog = GlobalFunctions.ReadNameChars(GlobalData.MAX_DIALOG_LEN, br);
			}
			if (version >= 167)
			{
				this.SuccTriggerEvent = br.ReadInt32();
			}
			if (version >= 175)
			{
				this.VerifyStateLayer = br.ReadInt32();
				this.VerifyStateLayerID = br.ReadInt32();
				this.KeyWordIndex = br.ReadInt32();
			}
			if (version >= 140)
			{
				this.TaskEventChar = GlobalFunctions.ReadNameChars(GlobalData.MAX_TASK_NAME_LEN, br);
				this.TaskEventType = br.ReadInt32();
				this.TaskEventTime = br.ReadInt16();
				this.TaskEventMonsterCount = br.ReadInt16();
				if (version < 176)
				{
					this.TaskEventMonsterDataPointer = br.ReadInt32();
				}
				this.TaskEventMineCount = br.ReadInt16();
				if (version < 176)
				{
					this.TaskEventMineDataPointer = br.ReadInt32();
				}
				this.TaskEventTaskCount = br.ReadInt16();
				if (version < 176)
				{
					this.TaskEventTaskDataPointer = br.ReadInt32();
				}
			}
			if (version >= 146)
			{
				this.FactionPersonScore = br.ReadInt16();
			}
			if (version >= 153)
			{
				this.TMTinyGameType = br.ReadByte();
			}
			if (version >= 158)
			{
				this.m_ulGold2Wanted = br.ReadInt32();
			}
			this.m_ulAwardType_S = br.ReadInt32();
			this.m_ulAwardType_F = br.ReadInt32();
			if (version < 176)
			{
				this.m_Award_SPointer = br.ReadInt32();
				this.m_Award_FPointer = br.ReadInt32();
				this.m_AwByRatio_SPointer = br.ReadInt32();
				this.m_AwByRatio_FPointer = br.ReadInt32();
				this.m_AwByItems_SPointer = br.ReadInt32();
				this.m_AwByItems_FPointer = br.ReadInt32();
				if (version >= 140)
				{
					this.AwByTaskEventRatio_SPointer = br.ReadInt32();
					this.AwByTaskEventRatio_FPointer = br.ReadInt32();
				}
				if (version >= 146)
				{
					this.AwByCarrierHp_SPointer = br.ReadInt32();
					this.AwByCarrierHp_FPointer = br.ReadInt32();
				}
				if (version >= 161)
				{
					this.AwByVar_SPointer = br.ReadInt32();
					this.AwByVar_FPointer = br.ReadInt32();
				}
			}
			this.m_ulParent = br.ReadInt32();
			this.m_ulPrevSibling = br.ReadInt32();
			this.m_ulNextSibling = br.ReadInt32();
			this.m_ulFirstChild = br.ReadInt32();
			if (version >= 83)
			{
				if (version < 135)
				{
					this.m_bIsLibraryTask = br.ReadBoolean();
				}
				this.m_fLibraryTasksProbability = br.ReadSingle();
			}
			if (version >= 95 && version < 135)
			{
				this.m_bIsUniqueStorageTask = br.ReadBoolean();
			}
			if (version >= 119)
			{
				this.m_iWorldContribution = br.ReadInt32();
			}
			if (version >= 135)
			{
				this.CombinedSwitches = br.ReadBytes(GlobalFunctions.GetCombinedSwitches(version));

				this.m_bShowByTransformed = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByTransformed);
				this.m_bShowByLev = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByLev);
				this.m_bPremCheckReincarnation = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremCheckReincarnation);
				this.m_bShowByReincarnation = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByReincarnation);
				this.m_bPremCheckRealmLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremCheckRealmLevel);
				this.m_bPremCheckRealmExpFull = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremCheckRealmExpFull);
				this.m_bShowByRealmLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByRealmLevel);
				this.m_bShowByItems = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByItems);
				this.m_bPremItemsAnyOne = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremItemsAnyOne);
				this.NotOpenWithItem = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.NotOpenWithItem);
				this.m_bShowByDeposit = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByDeposit);
				this.m_bShowByRepu = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByRepu);
				this.m_bShowByPreTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByPreTask);
				this.m_bShowByPeriod = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByPeriod);
				this.m_bShowByFaction = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByFaction);
				this.m_bShowByGender = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByGender);
				this.m_bShowByOccup = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByOccup);
				this.m_bPremise_Spouse = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.Premise_Spouse);
				this.m_bShowBySpouse = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowBySpouse);
				this.m_bPremiseWeddingOwner = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremiseWeddingOwner);
				this.m_bShowByWeddingOwner = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByWeddingOwner);
				this.m_bGM = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.GM);
				this.m_bShieldUser = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShieldUser);
				this.m_bShowByRMB = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByRMB);
				this.m_bCharTime = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CharTime);
				this.m_bShowByCharTime = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByCharTime);
				this.m_bTeamwork = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.Teamwork);
				this.m_bRcvByTeam = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RcvByTeam);
				this.m_bSharedTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.SharedTask);
				this.m_bSharedAchieved = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.SharedAchieved);
				this.m_bCheckTeammate = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CheckTeammate);
				this.m_bAllFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.AllFail);
				this.m_bCapFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CapFail);
				this.m_bCapSucc = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CapSucc);
				this.m_bDismAsSelfFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DismAsSelfFail);
				this.m_bRcvChckMem = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RcvChckMem);
				this.m_bCntByMemPos = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CntByMemPos);
				this.m_bAllSucc = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.AllSucc);
				this.m_bCoupleOnly = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CoupleOnly);
				this.m_bDistinguishedOcc = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DistinguishedOcc);
				this.m_bShowByTeam = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByTeam);
				this.m_bPremNeedComp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremNeedComp);
				if (version >= 178)
				{
					this.PremNeedCompPerson = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremNeedCompPerson);
				}
				this.m_bPremCheckForce = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremCheckForce);
				this.m_bShowByForce = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForce);
				this.m_bShowByForceReputation = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForceReputation);
				this.m_bShowByForceContribution = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForceContribution);
				this.m_bShowByForceExp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForceExp);
				this.m_bShowByForceSP = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForceSP);
				this.m_bShowByForceActivityLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByForceActivityLevel);
				this.m_bPremIsKing = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremIsKing);
				this.m_bShowByKing = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByKing);
				this.m_bPremNotInTeam = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremNotInTeam);
				this.m_bShowByNotInTeam = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByNotInTeam);
				this.m_bShowByTitle = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByTitle);
				this.m_bShowByHistoryStage = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHistoryStage);
				this.m_bShowByGeneralCard = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByGeneralCard);
				this.m_bShowByGeneralCardRank = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByGeneralCardRank);
				this.m_bShowByIconStateID = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByIconStateID);
				this.m_bShowByVIPLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByVIPLevel);
				this.PremNoHome = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremNoHome);
				this.m_bShowByHomeLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHomeLevel);
				this.m_bShowByHomeResourceLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHomeResourceLevel);
				this.m_bShowByHomeFactoryLevel = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHomeFactoryLevel);
				this.m_bShowByHomeFlourish = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHomeFlourish);
				this.m_bPremHomeStorageTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremHomeStorageTask);
				this.m_bShowByHomeStorageTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByHomeStorageTask);
				this.MonsterTotalCount = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.MonsterTotalCount);
				this.m_bFinNeedComp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.FinNeedComp);
				if (version >= 178)
				{
					this.FinNeedCompPerson = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.FinNeedCompPerson);
				}
				this.m_bIsLibraryTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.IsLibraryTask);
				this.m_bIsUniqueStorageTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.IsUniqueStorageTask);
				this.m_bHasSign = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.HasSign);
				this.m_bOfflineFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.OfflineFail);
				this.m_bItemNotTakeOff = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ItemNotTakeOff);
				this.m_bAbsTime = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.AbsTime);
				if (version >= 180)
				{
					this.MultiNpcTalk = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.MultiNpcTalk);
				}
				this.m_bChooseOne = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ChooseOne);
				this.m_bRandOne = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RandOne);
				this.m_bExeChildInOrder = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ExeChildInOrder);
				this.m_bParentAlsoFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ParentAlsoFail);
				this.m_bParentAlsoSucc = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ParentAlsoSucc);
				this.m_bCanGiveUp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CanGiveUp);
				this.m_bCanRedo = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CanRedo);
				this.m_bCanRedoAfterFailure = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CanRedoAfterFailure);
				this.m_bClearAsGiveUp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ClearAsGiveUp);
				this.m_bNeedRecord = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.NeedRecord);
				this.m_bFailAsPlayerDie = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.FailAsPlayerDie);
				this.m_bDelvInZone = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DelvInZone);
				this.m_bEnterRegionFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.EnterRegionFail);
				this.m_bLeaveRegionFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.LeaveRegionFail);
				this.m_bLeaveForceFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.LeaveForceFail);
				this.m_bTransTo = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.TransTo);
				this.m_bTrigCtrl = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.TrigCtrl);
				this.m_bAutoDeliver = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.AutoDeliver);
				this.m_bDisplayInExclusiveUI = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DisplayInExclusiveUI);
				this.m_bReadyToNotifyServer = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ReadyToNotifyServer);
				this.m_bUsedInTokenShop = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.UsedInTokenShop);
				this.m_bDeathTrig = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DeathTrig);
				this.m_bClearAcquired = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ClearAcquired);
				this.m_bShowPrompt = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowPrompt);
				this.m_bKeyTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.KeyTask);
				this.m_bSkillTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.SkillTask);
				this.m_bCanSeekOut = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CanSeekOut);
				this.m_bShowDirection = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowDirection);
				this.m_bMarriage = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.Marriage);
				this.m_bSwitchSceneFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.SwitchSceneFail);
				this.m_bHidden = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.Hidden);
				this.m_bDeliverySkill = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DeliverySkill);
				this.m_bShowGfxFinished = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowGfxFinished);
				this.m_bChangePQRanking = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ChangePQRanking);
				this.m_bCompareItemAndInventory = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CompareItemAndInventory);
				this.m_bTowerTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.TowerTask);
				this.m_bHomeTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.HomeTask);
				this.m_bDeliverInHostHome = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DeliverInHostHome);
				this.m_bFinishInHostHome = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.FinishInHostHome);
				this.m_bPQTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PQTask);
				this.m_bPQSubTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PQSubTask);
				this.m_bClearContrib = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ClearContrib);
				this.m_bShowByNeedRecordTasksNum = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByNeedRecordTasksNum);
				this.m_bShowByFactionContrib = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByFactionContrib);
				this.m_bAccountTaskLimit = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.AccountTaskLimit);
				this.m_bRoleTaskLimit = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RoleTaskLimit);
				this.m_bLeaveFactionFail = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.LeaveFactionFail);
				this.m_bNotIncCntWhenFailed = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.NotIncCntWhenFailed);
				this.m_bNotClearItemWhenFailed = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.NotClearItemWhenFailed);
				this.m_bDisplayInTitleTaskUI = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DisplayInTitleTaskUI);
				this.CanAwardOnCarrier = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CanAwardOnCarrier);
				if (version >= 137)
				{
					this.PreReachArenaWinCount = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PreReachArenaWinCount);
					this.ShowByReachArenaWinCount = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByReachArenaWinCount);
				}
				if (version >= 140)
				{
					this.WriteSpecialLog = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.WriteSpecialLog);
				}
				if (version >= 146)
				{
					this.ShowByPreFactionScore = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByPreFactionScore);
					this.ShowByPreFactionMoney = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByPreFactionMoney);
					this.ShowByPreFactionPersonScore = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByPreFactionPersonScore);
					this.CheckFactionMem = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.CheckFactionMem);
					this.ByFactionScore = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ByFactionScore);
					this.SpecailLogicTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.SpecailLogicTask);
				}
				if (version >= 153)
				{
					this.BecomeMentor = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.BecomeMentor);
					this.ShowMentorMorality = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowMentorMorality);
					this.ShowMentorStudent = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowMentorStudent);
					this.DiscardedTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DiscardedTask);
					this.NoCheckTitleGot = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.NoCheckTitleGot);
				}
				if (version >= 156)
				{
					this.ShowCoupleIntimacy = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowCoupleIntimacy);
				}
				if (version >= 158)
				{
					this.m_bShowByDeposit2 = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowByDeposit2);
					//this.RESERVED145 = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RESERVED145);
				}
				if (version >= 163)
				{
					this.RecordFinishCount = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RecordFinishCount);
				}
				if (version >= 167)
				{
					this.ShowCamp = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowCamp);
					this.ShowCampPower = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowCampPower);
					this.ReturnCampPower = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ReturnCampPower);
					this.TeamHaveRecaller = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.TeamHaveRecaller);
					this.BindedRecaller = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.BindedRecaller);
					this.ShowNeedFriendPoint = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.ShowNeedFriendPoint);
				}
				if (version >= 175)
				{
					this.HistoryVarTask = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.HistoryVarTask);
					this.PremRank = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.PremRank);
					this.DeliverByUI = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.DeliverByUI);
				}
				if (version >= 177)
				{
					this.WarTaskAward = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.WarTaskAward);
				}
				if (version >= 180)
				{
					this.HideOtherPlayer = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.HideOtherPlayer);
					//this.RESERVED158 = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RESERVED158);
					//this.RESERVED159 = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RESERVED159);
					//this.RESERVED160 = GlobalFunctions.CheckParam(version, this.CombinedSwitches, (int)GlobalData.TaskParameters.RESERVED160);
				}
			}
			if (version == 139)
			{
				this.WriteSpecialLog = br.ReadBoolean();
			}
			if (version >= 146)
			{
				this.SpecialParametersCount = br.ReadInt32();
				if (version < 176)
				{
					this.SpecialParametersPointer = br.ReadInt32();
				}
			}
			if (this.m_bHasSign)
			{
				this.m_pszSignature = GlobalFunctions.ReadNameChars(GlobalData.MAX_TASK_NAME_LEN, br);
			}
			this.m_tmStart = new task_tm[this.m_ulTimetable];
			this.m_tmEnd = new task_tm[this.m_ulTimetable];
			for (int i = 0; i < this.m_ulTimetable; i++)
			{
				this.m_tmStart[i] = new task_tm();
				task_tm.Read(version, br, this.m_tmStart[i]);
				this.m_tmEnd[i] = new task_tm();
				task_tm.Read(version, br, this.m_tmEnd[i]);
			}
			if (version >= 59)
			{
				this.m_plChangeKey = new int[this.m_ulChangeKeyCnt];
				this.m_plChangeKeyValue = new int[this.m_ulChangeKeyCnt];
				this.m_pbChangeType = new bool[this.m_ulChangeKeyCnt];
				for (int i = 0; i < this.m_ulChangeKeyCnt; i++)
				{
					this.m_plChangeKey[i] = br.ReadInt32();
					this.m_plChangeKeyValue[i] = br.ReadInt32();
					this.m_pbChangeType[i] = br.ReadBoolean();
				}
			}
			if (version >= 178)
			{
				this.PersonChangeKey = new int[this.PersonChangeKeyCnt];
				this.PersonChangeKeyValue = new int[this.PersonChangeKeyCnt];
				this.PersonChangeType = new bool[this.PersonChangeKeyCnt];
				for (int i = 0; i < this.PersonChangeKeyCnt; i++)
				{
					this.PersonChangeKey[i] = br.ReadInt32();
					this.PersonChangeKeyValue[i] = br.ReadInt32();
					this.PersonChangeType[i] = br.ReadBoolean();
				}
			}
			if (version >= 75)
			{
				this.m_pszPQExp = new char[this.m_ulPQExpCnt][];
				this.m_pPQExpArr = new TASK_EXPRESSION[this.m_ulPQExpCnt][];
				for (int i = 0; i < this.m_ulPQExpCnt; i++)
				{
					this.m_pszPQExp[i] = GlobalFunctions.ReadChars(GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN, br);
					this.m_pPQExpArr[i] = new TASK_EXPRESSION[GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN];
					for (int j = 0; j < this.m_pPQExpArr[i].Length; j++)
					{
						this.m_pPQExpArr[i][j] = new TASK_EXPRESSION();
						TASK_EXPRESSION.Read(version, br, this.m_pPQExpArr[i][j]);
					}
				}
				this.m_MonstersContrib = new MONSTERS_CONTRIB[this.m_ulMonsterContribCnt];
				for (int i = 0; i < this.m_ulMonsterContribCnt; i++)
				{
					this.m_MonstersContrib[i] = new MONSTERS_CONTRIB();
					MONSTERS_CONTRIB.Read(version, br, this.m_MonstersContrib[i]);
				}
			}
			if (version >= 80)
			{
				this.m_pDelvRegion = new Task_Region[this.m_ulDelvRegionCnt];
				for (int i = 0; i < this.m_ulDelvRegionCnt; i++)
				{
					this.m_pDelvRegion[i] = new Task_Region();
					Task_Region.Read(version, br, this.m_pDelvRegion[i]);
					if (version < 157)
						this.m_pDelvRegion[i].MapID = this.m_ulDelvWorld;
				}
				this.m_pEnterRegion = new Task_Region[this.m_ulEnterRegionCnt];
				for (int i = 0; i < this.m_ulEnterRegionCnt; i++)
				{
					this.m_pEnterRegion[i] = new Task_Region();
					Task_Region.Read(version, br, this.m_pEnterRegion[i]);
					if (version < 157)
						this.m_pEnterRegion[i].MapID = this.m_ulEnterRegionWorld;
				}
				this.m_pLeaveRegion = new Task_Region[this.m_ulLeaveRegionCnt];
				for (int i = 0; i < this.m_ulLeaveRegionCnt; i++)
				{
					this.m_pLeaveRegion[i] = new Task_Region();
					Task_Region.Read(version, br, this.m_pLeaveRegion[i]);
					if (version < 157)
						this.m_pLeaveRegion[i].MapID = this.m_ulLeaveRegionWorld;
				}
			}
			this.m_PremItems = new ITEM_WANTED[this.m_ulPremItems];
			for (int i = 0; i < this.m_ulPremItems; i++)
			{
				this.m_PremItems[i] = new ITEM_WANTED();
				ITEM_WANTED.Read(version, br, this.m_PremItems[i]);
			}
			this.m_GivenItems = new ITEM_WANTED[this.m_ulGivenItems];
			for (int i = 0; i < this.m_ulGivenItems; i++)
			{
				this.m_GivenItems[i] = new ITEM_WANTED();
				ITEM_WANTED.Read(version, br, this.m_GivenItems[i]);
			}
			this.m_TeamMemsWanted = new TEAM_MEM_WANTED[this.m_ulTeamMemsWanted];
			for (int i = 0; i < this.m_ulTeamMemsWanted; i++)
			{
				this.m_TeamMemsWanted[i] = new TEAM_MEM_WANTED();
				TEAM_MEM_WANTED.Read(version, br, this.m_TeamMemsWanted[i]);
			}
			if (version >= 109)
			{
				this.m_PremTitles = new int[this.m_iPremTitleNumTotal];
				for (int i = 0; i < this.m_iPremTitleNumTotal; i++)
				{
					this.m_PremTitles[i] = br.ReadInt32();
				}
			}
			this.m_MonsterWanted = new MONSTER_WANTED[this.m_ulMonsterWanted];
			for (int i = 0; i < this.m_ulMonsterWanted; i++)
			{
				this.m_MonsterWanted[i] = new MONSTER_WANTED();
				MONSTER_WANTED.Read(version, br, this.m_MonsterWanted[i]);
			}
			if (version >= 103)
			{
				this.m_PlayerWanted = new PLAYER_WANTED[this.m_ulPlayerWanted];
				for (int i = 0; i < this.m_ulPlayerWanted; i++)
				{
					this.m_PlayerWanted[i] = new PLAYER_WANTED();
					PLAYER_WANTED.Read(version, br, this.m_PlayerWanted[i]);
				}
			}
			this.m_ItemsWanted = new ITEM_WANTED[this.m_ulItemsWanted];
			for (int i = 0; i < this.m_ulItemsWanted; i++)
			{
				this.m_ItemsWanted[i] = new ITEM_WANTED();
				ITEM_WANTED.Read(version, br, this.m_ItemsWanted[i]);
			}
			if (version >= 63)
			{
				this.m_pszExp = new char[this.m_ulExpCnt][];
				this.m_pExpArr = new TASK_EXPRESSION[this.m_ulExpCnt][];
				for (int i = 0; i < this.m_ulExpCnt; i++)
				{
					this.m_pszExp[i] = GlobalFunctions.ReadChars(GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN, br);
					this.m_pExpArr[i] = new TASK_EXPRESSION[GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN];
					for (int j = 0; j < this.m_pExpArr[i].Length; j++)
					{
						this.m_pExpArr[i][j] = new TASK_EXPRESSION();
						TASK_EXPRESSION.Read(version, br, this.m_pExpArr[i][j]);
					}
				}
			}
			if (version >= 178)
			{
				this.PersonExp = new char[this.PersonExpCnt][];
				this.PersonExpArr = new TASK_EXPRESSION[this.PersonExpCnt][];
				for (int i = 0; i < this.PersonExpCnt; i++)
				{
					this.PersonExp[i] = GlobalFunctions.ReadChars(GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN, br);
					this.PersonExpArr[i] = new TASK_EXPRESSION[GlobalData.TASK_AWARD_MAX_DISPLAY_CHAR_LEN];
					for (int j = 0; j < this.PersonExpArr[i].Length; j++)
					{
						this.PersonExpArr[i][j] = new TASK_EXPRESSION();
						TASK_EXPRESSION.Read(version, br, this.PersonExpArr[i][j]);
					}
				}
			}
			if (version >= 63)
			{
				this.m_pTaskChar = new short[this.m_ulTaskCharCnt][];
				for (int i = 0; i < this.m_ulTaskCharCnt; i++)
				{
					this.m_pTaskChar[i] = GlobalFunctions.ReadNameChars(64, br);
				}
			}
			if (version >= 178)
			{
				this.PersonTaskChar = new short[this.PersonTaskCharCnt][];
				for (int i = 0; i < this.PersonTaskCharCnt; i++)
				{
					this.PersonTaskChar[i] = GlobalFunctions.ReadNameChars(64, br);
				}
			}
			if (version >= 80)
			{
				this.m_pReachSite = new Task_Region[this.m_ulReachSiteCnt];
				for (int i = 0; i < this.m_ulReachSiteCnt; i++)
				{
					this.m_pReachSite[i] = new Task_Region();
					Task_Region.Read(version, br, this.m_pReachSite[i]);
					if (version < 157)
						this.m_pReachSite[i].MapID = this.m_ulReachSiteId;
				}
				this.m_pLeaveSite = new Task_Region[this.m_ulLeaveSiteCnt];
				for (int i = 0; i < this.m_ulLeaveSiteCnt; i++)
				{
					this.m_pLeaveSite[i] = new Task_Region();
					Task_Region.Read(version, br, this.m_pLeaveSite[i]);
					if (version < 157)
						this.m_pLeaveSite[i].MapID = this.m_ulLeaveSiteId;
				}
			}
			if (version >= 126)
			{
				this.m_HomeItemsWanted = new HOME_ITEM_WANTED[this.m_ulHomeItemsWanted];
				for (int i = 0; i < this.m_ulHomeItemsWanted; i++)
				{
					this.m_HomeItemsWanted[i] = new HOME_ITEM_WANTED();
					HOME_ITEM_WANTED.Read(version, br, this.m_HomeItemsWanted[i]);
				}
			}
			if (version >= 140)
			{
				this.TaskEventMonsterData = new TaskEventData[this.TaskEventMonsterCount];
				for (int i = 0; i < this.TaskEventMonsterCount; i++)
				{
					this.TaskEventMonsterData[i] = new TaskEventData();
					TaskEventData.Read(version, br, this.TaskEventMonsterData[i]);
				}
				this.TaskEventMineData = new TaskEventData[this.TaskEventMineCount];
				for (int i = 0; i < this.TaskEventMineCount; i++)
				{
					this.TaskEventMineData[i] = new TaskEventData();
					TaskEventData.Read(version, br, this.TaskEventMineData[i]);
				}
				this.TaskEventTaskData = new TaskEventData[this.TaskEventTaskCount];
				for (int i = 0; i < this.TaskEventTaskCount; i++)
				{
					this.TaskEventTaskData[i] = new TaskEventData();
					TaskEventData.Read(version, br, this.TaskEventTaskData[i]);
				}
			}
			AWARD_DATA.Read(version, br, this.m_Award_S);
			AWARD_DATA.Read(version, br, this.m_Award_F);
			AWARD_RATIO_SCALE.Read(version, br, this.m_AwByRatio_S);
			AWARD_RATIO_SCALE.Read(version, br, this.m_AwByRatio_F);
			AWARD_ITEMS_SCALE.Read(version, br, this.m_AwByItems_S);
			AWARD_ITEMS_SCALE.Read(version, br, this.m_AwByItems_F);
			if (version >= 140)
			{
				AWARD_RATIO_SCALE.Read(version, br, this.AwByTaskEventRatio_S);
				AWARD_RATIO_SCALE.Read(version, br, this.AwByTaskEventRatio_F);
			}
			if (version >= 146)
			{
				AWARD_CARRIER_HP_SCALE.Read(version, br, this.AwByCarrierHp_S);
				AWARD_CARRIER_HP_SCALE.Read(version, br, this.AwByCarrierHp_F);
			}
			if (version >= 161)
			{
				AWARD_VAR_SCALE.Read(version, br, this.AwByVar_S);
				AWARD_VAR_SCALE.Read(version, br, this.AwByVar_F);
			}
			if (version >= 146)
			{
				SPECIAL_PARAMETERS.Read(version, br, this.SpecialParametersCount, this.SpecialParameters);
			}
		}

		public void WriteReadATaskTemplFixedData(int version, BinaryWriter bw)
		{
			uint combinedswitch5tmp = 0;
			if (version >= 153)
			{
				bw.Write(this.IDSpace);
			}
			bw.Write(this.m_ID);
			GlobalFunctions.WriteNameChars(bw, this.m_szName);
			if (version < 135)
			{
				bw.Write(this.m_bHasSign);
			}
			if (version < 176)
			{
				bw.Write(this.m_pszSignaturePointer);
			}
			bw.Write(this.m_ulType);
			bw.Write(this.m_ulTimeLimit);
			if (version >= 68)
			{
				if (version < 135)
				{
					bw.Write(this.m_bOfflineFail);
				}
				bw.Write(this.m_bAbsFail);
				task_tm.Write(version, bw, this.m_tmAbsFailTime);
				if (version >= 175)
				{
					bw.Write(this.NextFail);
					task_tm.Write(version, bw, this.NextFailTime);
				}
				if (version < 135)
				{
					bw.Write(this.m_bItemNotTakeOff);
				}
			}
			if (version >= 52 && version < 135)
			{
				bw.Write(this.m_bAbsTime);
			}
			int timetable_count = GlobalFunctions.GetMaxTimetableSize(version);
			if (this.m_ulTimetable > timetable_count)
			{
				bw.Write(timetable_count);
			}
			else
			{
				bw.Write(this.m_ulTimetable);
			}
			if (version >= 52)
			{
				for (int i = 0; i < timetable_count; i++)
				{
					bw.Write(this.m_tmType[i]);
				}
			}
			if (version < 176)
			{
				bw.Write(this.m_tmStartPointer);
				bw.Write(this.m_tmEndPointer);
			}
			if (version >= 52)
			{
				bw.Write(this.m_lAvailFrequency);
			}
			if (version >= 85)
			{
				bw.Write(this.m_lPeriodLimit);
			}
			if (version >= 175)
			{
				bw.Write(this.AvailFrequency);
				task_tm.Write(version, bw, this.AvailFrequencyTime);
			}
			if (version < 135)
			{
				bw.Write(this.m_bChooseOne);
				bw.Write(this.m_bRandOne);
				bw.Write(this.m_bExeChildInOrder);
				bw.Write(this.m_bParentAlsoFail);
				bw.Write(this.m_bParentAlsoSucc);
				bw.Write(this.m_bCanGiveUp);
				bw.Write(this.m_bCanRedo);
				bw.Write(this.m_bCanRedoAfterFailure);
				bw.Write(this.m_bClearAsGiveUp);
				bw.Write(this.m_bNeedRecord);
				bw.Write(this.m_bFailAsPlayerDie);
			}
			bw.Write(this.m_ulMaxReceiver);
			if (version < 135)
			{
				bw.Write(this.m_bDelvInZone);
			}
			bw.Write(this.m_ulDelvWorld);
			int delv_region_count = GlobalFunctions.GetMaxTaskRegion(version);
			if (version >= 80)
			{
				if (this.m_ulDelvRegionCnt > delv_region_count)
				{
					bw.Write(delv_region_count);
				}
				else
				{
					bw.Write(this.m_ulDelvRegionCnt);
				}
				if (version < 176)
				{
					bw.Write(this.m_pDelvRegionPointer);
				}
			}
			else
			{
				if (this.m_pDelvRegion.Length != 0)
				{
					Task_Region.Write(version, bw, this.m_pDelvRegion[0]);
				}
				else
				{
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
				}
			}
			int enter_region_count = GlobalFunctions.GetMaxTaskRegion(version);
			if (version >= 68)
			{
				if (version < 135)
				{
					bw.Write(this.m_bEnterRegionFail);
				}
				bw.Write(this.m_ulEnterRegionWorld);
				if (version >= 80)
				{
					if (this.m_ulEnterRegionCnt > enter_region_count)
					{
						bw.Write(enter_region_count);
					}
					else
					{
						bw.Write(this.m_ulEnterRegionCnt);
					}
					if (version < 176)
					{
						bw.Write(this.m_pEnterRegionPointer);
					}
				}
				else
				{
					if (this.m_pEnterRegion.Length != 0)
					{
						Task_Region.Write(version, bw, this.m_pEnterRegion[0]);
					}
					else
					{
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
					}
				}
			}
			int leave_region_count = GlobalFunctions.GetMaxTaskRegion(version);
			if (version >= 68)
			{
				if (version < 135)
				{
					bw.Write(this.m_bLeaveRegionFail);
				}
				bw.Write(this.m_ulLeaveRegionWorld);
				if (version >= 80)
				{
					if (this.m_ulLeaveRegionCnt > leave_region_count)
					{
						bw.Write(leave_region_count);
					}
					else
					{
						bw.Write(this.m_ulLeaveRegionCnt);
					}
					if (version < 176)
					{
						bw.Write(this.m_pLeaveRegionPointer);
					}
				}
				else
				{
					if (this.m_pLeaveRegion.Length != 0)
					{
						Task_Region.Write(version, bw, this.m_pLeaveRegion[0]);
					}
					else
					{
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
					}
				}
			}
			if (version < 135)
			{
				if (version >= 97)
				{
					bw.Write(this.m_bLeaveForceFail);
				}
				bw.Write(this.m_bTransTo);
			}
			bw.Write(this.m_ulTransWldId);
			ZONE_VERT.Write(version, bw, this.m_TransPt);
			if (version >= 52)
			{
				bw.Write(this.m_lMonsCtrl);
				if (version < 135)
				{
					bw.Write(this.m_bTrigCtrl);
				}
			}
			if (version < 135)
			{
				bw.Write(this.m_bAutoDeliver);
				if (version >= 84)
				{
					bw.Write(this.m_bDisplayInExclusiveUI);
				}
				if (version >= 89)
				{
					bw.Write(this.m_bReadyToNotifyServer);
				}
				if (version >= 116)
				{
					bw.Write(this.m_bUsedInTokenShop);
				}
				bw.Write(this.m_bDeathTrig);
				bw.Write(this.m_bClearAcquired);
			}
			bw.Write(this.m_ulSuitableLevel);
			if (version < 135)
			{
				bw.Write(this.m_bShowPrompt);
				bw.Write(this.m_bKeyTask);
			}
			bw.Write(this.m_ulDelvNPC);
			bw.Write(this.m_ulAwardNPC);
			if (version < 135)
			{
				bw.Write(this.m_bSkillTask);
				if (version >= 52)
				{
					bw.Write(this.m_bCanSeekOut);
					bw.Write(this.m_bShowDirection);
				}
				if (version >= 55)
				{
					bw.Write(this.m_bMarriage);
				}
			}
			if (version >= 59)
			{
				bw.Write(this.m_ulChangeKeyCnt);
				if (version < 176)
				{
					bw.Write(this.m_plChangeKeyPointer);
					bw.Write(this.m_plChangeKeyValuePointer);
					bw.Write(this.m_pbChangeTypePointer);
				}
			}
			if (version >= 178)
			{
				bw.Write(this.PersonChangeKeyCnt);
			}
			if (version >= 63 && version < 135)
			{
				bw.Write(this.m_bSwitchSceneFail);
				bw.Write(this.m_bHidden);
			}
			if (version >= 78)
			{
				if (version < 135)
				{
					bw.Write(this.m_bDeliverySkill);
				}
				bw.Write(this.m_iDeliveredSkillID);
				bw.Write(this.m_iDeliveredSkillLevel);
				if (version < 135)
				{
					bw.Write(this.m_bShowGfxFinished);
				}
			}
			if (version >= 79 && version < 135)
			{
				bw.Write(this.m_bChangePQRanking);
			}
			if (version >= 81)
			{
				if (version < 135)
				{
					bw.Write(this.m_bCompareItemAndInventory);
				}
				bw.Write(this.m_ulInventorySlotNum);
			}
			if (version < 135)
			{
				if (version >= 123)
				{
					bw.Write(this.m_bTowerTask);
				}
				if (version >= 126)
				{
					bw.Write(this.m_bHomeTask);
				}
				if (version >= 128)
				{
					bw.Write(this.m_bDeliverInHostHome);
					bw.Write(this.m_bFinishInHostHome);
				}
			}
			if (version >= 75)
			{
				if (version < 135)
				{
					bw.Write(this.m_bPQTask);
				}
				bw.Write(this.m_ulPQExpCnt);
				if (version < 176)
				{
					bw.Write(this.m_pszPQExpPointer);
					bw.Write(this.m_pPQExpArrPointer);
				}
				if (version < 135)
				{
					bw.Write(this.m_bPQSubTask);
					bw.Write(this.m_bClearContrib);
				}
				bw.Write(this.m_ulMonsterContribCnt);
				if (version < 176)
				{
					bw.Write(this.m_MonstersContribPointer);
				}
			}
			if (version >= 91)
			{
				bw.Write(this.m_iPremNeedRecordTasksNum);
				if (version < 135)
				{
					bw.Write(this.m_bShowByNeedRecordTasksNum);
				}
			}
			if (version >= 87)
			{
				bw.Write(this.m_iPremiseFactionContrib);
				if (version < 135)
				{
					bw.Write(this.m_bShowByFactionContrib);
				}
			}
			if (version < 135)
			{
				if (version >= 75)
				{
					bw.Write(this.m_bAccountTaskLimit);
				}
				if (version >= 115)
				{
					bw.Write(this.m_bRoleTaskLimit);
				}
			}
			if (version >= 75)
			{
				bw.Write(this.m_ulAccountTaskLimitCnt);
			}
			if (version < 135)
			{
				if (version >= 105)
				{
					bw.Write(this.m_bLeaveFactionFail);
				}
				if (version >= 111)
				{
					bw.Write(this.m_bNotIncCntWhenFailed);
				}
				if (version >= 108)
				{
					bw.Write(this.m_bNotClearItemWhenFailed);
				}
				if (version >= 110)
				{
					bw.Write(this.m_bDisplayInTitleTaskUI);
				}
			}
			if (version >= 146)
			{
				bw.Write(this.FactionMem);
			}
			if (version >= 161)
			{
				bw.Write(this.CrossServer);
				bw.Write(this.IconStateIDForAwardVar);
				bw.Write(this.GlobalKeyForAwardVar);
			}
			if (version >= 178)
			{
				bw.Write(this.PersonKeyForAwardVar);
			}
			if (version >= 175)
			{
				bw.Write(this.FailNeedComp);
				bw.Write(this.FailExp1AndOrExp2);
				COMPARE_KEY_VALUE.Write(version, bw, this.Fail1KeyValue);
				COMPARE_KEY_VALUE.Write(version, bw, this.Fail2KeyValue);
			}
			if (version >= 180)
			{
				bw.Write(this.HideOtherPlayerTime);
				bw.Write(this.PropMonsterSummonedCnt);
				AWARD_MONSTERS_SUMMONED.Write2(version, bw, this.PropMonsterSummoned);
			}
			if (version >= 181)
			{
				bw.Write(this.GfxType);
			}
			if (version >= 96)
			{
				bw.Write(this.m_ucPremiseTransformedForm);
				if (version < 135)
				{
					bw.Write(this.m_bShowByTransformed);
				}
			}
			bw.Write(this.m_ulPremise_Lev_Min);
			bw.Write(this.m_ulPremise_Lev_Max);
			if (version >= 113)
			{
				bw.Write(this.m_bPremCheckMaxHistoryLevel);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByLev);
			}
			if (version >= 113)
			{
				if (version < 135)
				{
					bw.Write(this.m_bPremCheckReincarnation);
				}
				bw.Write(this.m_ulPremReincarnationMin);
				bw.Write(this.m_ulPremReincarnationMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByReincarnation);
					bw.Write(this.m_bPremCheckRealmLevel);
				}
				bw.Write(this.m_ulPremRealmLevelMin);
				bw.Write(this.m_ulPremRealmLevelMax);
				if (version < 135)
				{
					bw.Write(this.m_bPremCheckRealmExpFull);
					bw.Write(this.m_bShowByRealmLevel);
				}
			}
			bw.Write(this.m_ulPremItems);
			if (version < 176)
			{
				bw.Write(this.m_PremItemsPointer);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByItems);
				if (version >= 98)
				{
					bw.Write(this.m_bPremItemsAnyOne);
				}
			}
			bw.Write(this.m_ulGivenItems);
			bw.Write(this.m_ulGivenCmnCount);
			bw.Write(this.m_ulGivenTskCount);
			if (version < 176)
			{
				bw.Write(this.m_GivenItemsPointer);
			}
			bw.Write(this.m_ulPremise_Deposit);
			if (version < 135)
			{
				bw.Write(this.m_bShowByDeposit);
			}
			bw.Write(this.m_lPremise_Reputation);
			if (version >= 53)
			{
				bw.Write(this.m_lPremise_RepuMax);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByRepu);
			}
			int premise_tasks_count = GlobalFunctions.GetMaxPremTaskCount(version);
			if (version < 90)
			{
				for (int i = premise_tasks_count; i < this.m_ulPremise_Tasks.Length; i++)
				{
					if (this.m_ulPremise_Tasks[i] > 0)
					{
						this.m_ulPremise_Task_Count--;
					}
				}
			}
			bw.Write(this.m_ulPremise_Task_Count);
			for (int i = 0; i < premise_tasks_count; i++)
			{
				bw.Write(this.m_ulPremise_Tasks[i]);
			}
			if (version >= 153)
			{
				for (int i = 0; i < premise_tasks_count; i++)
				{
					bw.Write(this.PremiseTaskSpace[i]);
				}
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByPreTask);
			}
			if (version >= 90)
			{
				bw.Write(this.m_ulPremise_Task_Least_Num);
			}
			bw.Write(this.m_ulPremise_Period);
			if (version < 135)
			{
				bw.Write(this.m_bShowByPeriod);
			}
			bw.Write(this.m_ulPremise_Faction);
			if (version >= 93)
			{
				bw.Write(this.m_iPremise_FactionRole);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByFaction);
			}
			bw.Write(this.m_ulGender);
			if (version < 135)
			{
				bw.Write(this.m_bShowByGender);
			}
			int occupations_cout = GlobalFunctions.GetMaxOccupations(version);
			for (int i = occupations_cout; i < this.m_Occupations.Length; i++)
			{
				if (this.m_Occupations[i] > 0)
				{
					this.m_ulOccupations--;
				}
			}
			bw.Write(this.m_ulOccupations);
			for (int i = 0; i < occupations_cout; i++)
			{
				bw.Write(this.m_Occupations[i]);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByOccup);
				bw.Write(this.m_bPremise_Spouse);
				bw.Write(this.m_bShowBySpouse);
				if (version >= 102)
				{
					bw.Write(this.m_bPremiseWeddingOwner);
					bw.Write(this.m_bShowByWeddingOwner);
				}
				if (version >= 52)
				{
					bw.Write(this.m_bGM);
				}
				if (version >= 68)
				{
					bw.Write(this.m_bShieldUser);
				}
			}
			if (version >= 75)
			{
				if (version < 135)
				{
					bw.Write(this.m_bShowByRMB);
				}
				bw.Write(this.m_ulPremRMBMin);
				bw.Write(this.m_ulPremRMBMax);
				if (version < 135)
				{
					bw.Write(this.m_bCharTime);
					bw.Write(this.m_bShowByCharTime);
				}
				bw.Write(this.m_iCharStartTime);
				bw.Write(this.m_iCharEndTime);
				task_tm.Write(version, bw, this.m_tmCharEndTime);
				bw.Write(this.m_ulCharTimeGreaterThan);
			}
			if (version >= 153)
			{
				bw.Write(this.PremiseCotaskSpace);
			}
			bw.Write(this.m_ulPremise_Cotask);
			bw.Write(this.m_ulCoTaskCond);
			bw.Write(this.m_ulMutexTaskCount);
			if (version >= 153)
			{
				for (int i = 0; i < this.MutexTaskSpace.Length; i++)
				{
					bw.Write(this.MutexTaskSpace[i]);
				}
			}
			for (int i = 0; i < this.m_ulMutexTasks.Length; i++)
			{
				bw.Write(this.m_ulMutexTasks[i]);
			}
			for (int i = 0; i < this.m_lSkillLev.Length; i++)
			{
				bw.Write(this.m_lSkillLev[i]);
			}
			bw.Write(this.m_DynTaskType);
			bw.Write(this.m_ulSpecialAward);
			if (version < 135)
			{
				bw.Write(this.m_bTeamwork);
				bw.Write(this.m_bRcvByTeam);
				bw.Write(this.m_bSharedTask);
				bw.Write(this.m_bSharedAchieved);
				bw.Write(this.m_bCheckTeammate);
			}
			bw.Write(this.m_fTeammateDist);
			if (version < 135)
			{
				bw.Write(this.m_bAllFail);
				bw.Write(this.m_bCapFail);
				bw.Write(this.m_bCapSucc);
			}
			bw.Write(this.m_fSuccDist);
			if (version < 135)
			{
				bw.Write(this.m_bDismAsSelfFail);
				bw.Write(this.m_bRcvChckMem);
			}
			bw.Write(this.m_fRcvMemDist);
			if (version < 135)
			{
				bw.Write(this.m_bCntByMemPos);
			}
			bw.Write(this.m_fCntMemDist);
			if (version < 135)
			{
				if (version >= 68)
				{
					bw.Write(this.m_bAllSucc);
				}
				if (version >= 75)
				{
					bw.Write(this.m_bCoupleOnly);
				}
				if (version >= 86)
				{
					bw.Write(this.m_bDistinguishedOcc);
				}
			}
			if (this.m_bTeamwork)
			{
				bw.Write(this.m_ulTeamMemsWanted);
			}
			else
			{
				bw.Write(0);
			}
			if (version < 176)
			{
				bw.Write(this.m_TeamMemsWantedPointer);
			}
			if (version < 135)
			{
				bw.Write(this.m_bShowByTeam);
			}
			if (version >= 59)
			{
				if (version < 135)
				{
					bw.Write(this.m_bPremNeedComp);
				}
				bw.Write(this.m_nPremExp1AndOrExp2);
				COMPARE_KEY_VALUE.Write(version, bw, this.m_Prem1KeyValue);
				COMPARE_KEY_VALUE.Write(version, bw, this.m_Prem2KeyValue);
			}
			if (version >= 178)
			{
				bw.Write(this.PremPersonExp1AndOrExp2);
				COMPARE_KEY_VALUE.Write(version, bw, this.PremPerson1KeyValue);
				COMPARE_KEY_VALUE.Write(version, bw, this.PremPerson2KeyValue);
			}
			if (version >= 97)
			{
				if (version < 135)
				{
					bw.Write(this.m_bPremCheckForce);
				}
				bw.Write(this.m_iPremForce);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForce);
				}
				bw.Write(this.m_iPremForceReputation);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForceReputation);
				}
				bw.Write(this.m_iPremForceContribution);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForceContribution);
				}
				bw.Write(this.m_iPremForceExp);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForceExp);
				}
				bw.Write(this.m_iPremForceSP);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForceSP);
				}
			}
			if (version >= 99)
			{
				bw.Write(this.m_iPremForceActivityLevel);
				if (version < 135)
				{
					bw.Write(this.m_bShowByForceActivityLevel);
				}
			}
			if (version < 135)
			{
				if (version >= 106)
				{
					bw.Write(this.m_bPremIsKing);
					bw.Write(this.m_bShowByKing);
				}
				if (version >= 107)
				{
					bw.Write(this.m_bPremNotInTeam);
					bw.Write(this.m_bShowByNotInTeam);
				}
			}
			if (version >= 109)
			{
				bw.Write(this.m_iPremTitleNumTotal);
				bw.Write(this.m_iPremTitleNumRequired);
				if (version < 176)
				{
					bw.Write(this.m_PremTitlesPointer);
				}
				if (version < 135)
				{
					bw.Write(this.m_bShowByTitle);
				}
			}
			if (version >= 112)
			{
				for (int i = 0; i < this.m_iPremHistoryStageIndex.Length; i++)
				{
					bw.Write(this.m_iPremHistoryStageIndex[i]);
				}
			}
			if (version >= 118 && version < 135)
			{
				bw.Write(this.m_bShowByHistoryStage);
			}
			if (version >= 114)
			{
				bw.Write(this.m_ulPremGeneralCardCount);
				if (version < 135)
				{
					bw.Write(this.m_bShowByGeneralCard);
				}
			}
			if (version >= 117)
			{
				bw.Write(this.m_iPremGeneralCardRank);
				bw.Write(this.m_ulPremGeneralCardRankCount);
				if (version < 135)
				{
					bw.Write(this.m_bShowByGeneralCardRank);
				}
			}
			if (version >= 122)
			{
				bw.Write(this.m_ulPremIconStateID);
				if (version < 135)
				{
					bw.Write(this.m_bShowByIconStateID);
				}
			}
			if (version >= 125)
			{
				bw.Write(this.m_iVIPLevelMin);
				bw.Write(this.m_iVIPLevelMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByVIPLevel);
				}
			}
			if (version >= 129 && version < 135)
			{
				bw.Write(this.PremNoHome);
			}
			if (version >= 126)
			{
				bw.Write(this.m_iPremHomeLevelMin);
				bw.Write(this.m_iPremHomeLevelMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByHomeLevel);
				}
				bw.Write(this.m_iPremHomeResourceLevelType);
				bw.Write(this.m_iPremHomeResourceLevelMin);
				bw.Write(this.m_iPremHomeResourceLevelMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByHomeResourceLevel);
				}
				bw.Write(this.m_iPremHomeFactoryLevelType);
				bw.Write(this.m_iPremHomeFactoryLevelMin);
				bw.Write(this.m_iPremHomeFactoryLevelMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByHomeFactoryLevel);
				}
				bw.Write(this.m_iPremHomeFlourishMin);
				bw.Write(this.m_iPremHomeFlourishMax);
				if (version < 135)
				{
					bw.Write(this.m_bShowByHomeFlourish);
					bw.Write(this.m_bPremHomeStorageTask);
					bw.Write(this.m_bShowByHomeStorageTask);
				}
			}
			if (version >= 137)
			{
				bw.Write(ArenaWinCount);
			}
			if (version >= 146)
			{
				bw.Write(this.PreFactionScore);
				bw.Write(this.PreFactionMoney);
				bw.Write(this.PreFactionPersonScore);
			}
			if (version >= 153)
			{
				bw.Write(this.PremMentorMorality);
				bw.Write(this.PremMentorStudent);
			}
			if (version >= 156)
			{
				bw.Write(this.PremCoupleIntimacy);
			}
			if (version >= 158)
			{
				bw.Write(this.m_ulPremise_Deposit2);
			}
			if (version >= 161)
			{
				bw.Write(this.NeededTaskCount);
				for (int i = 0; i < this.NeededTaskSpace.Length; i++)
				{
					bw.Write(this.NeededTaskSpace[i]);
				}
				for (int i = 0; i < this.NeededTask.Length; i++)
				{
					bw.Write(this.NeededTask[i]);
				}
				bw.Write(this.NeededTaskLeast);
			}
			if (version >= 167)
			{
				bw.Write(this.PremCamp);
				bw.Write(this.PremCampPower);
				bw.Write(this.NeedFriendPoint);
			}
			if (version >= 175)
			{
				bw.Write(this.RankType);
				bw.Write(this.RankGradeMin);
				bw.Write(this.RankGradeMax);
				bw.Write(this.RankGradeMinKey);
				bw.Write(this.RankGradeMaxKey);
			}
			bw.Write(this.m_enumMethod);
			bw.Write(this.m_enumFinishType);
			int player_wanted_count = GlobalFunctions.GetMaxPlayerWanted(version);
			if (version >= 103)
			{
				if (this.m_ulPlayerWanted > player_wanted_count)
				{
					bw.Write(player_wanted_count);
				}
				else
				{
					bw.Write(this.m_ulPlayerWanted);
				}
				if (version < 176)
				{
					bw.Write(this.m_PlayerWantedPointer);
				}
			}
			int monster_wanted_count = GlobalFunctions.GetMaxMonsterWanted(version);
			if (this.m_ulMonsterWanted > monster_wanted_count)
			{
				bw.Write(monster_wanted_count);
			}
			else
			{
				bw.Write(this.m_ulMonsterWanted);
			}
			if (version < 176)
			{
				bw.Write(this.m_MonsterWantedPointer);
			}
			bw.Write(this.m_ulItemsWanted);
			if (version < 176)
			{
				bw.Write(this.m_ItemsWantedPointer);
			}
			bw.Write(this.m_ulGoldWanted);
			if (version >= 88)
			{
				bw.Write(this.m_iFactionContribWanted);
			}
			if (version >= 89)
			{
				bw.Write(this.m_iFactionExpContribWanted);
			}
			bw.Write(this.m_ulNPCToProtect);
			bw.Write(this.m_ulProtectTimeLen);
			bw.Write(this.m_ulNPCMoving);
			bw.Write(this.m_ulNPCDestSite);
			int reach_site_count = GlobalFunctions.GetMaxTaskRegion(version);
			if (version >= 80)
			{
				if (version < 176)
				{
					bw.Write(this.m_pReachSitePointer);
				}
				if (this.m_ulReachSiteCnt > reach_site_count)
				{
					bw.Write(reach_site_count);
				}
				else
				{
					bw.Write(this.m_ulReachSiteCnt);
				}
			}
			else
			{
				if (this.m_pReachSite.Length != 0)
				{
					Task_Region.Write(version, bw, this.m_pReachSite[0]);
				}
				else
				{
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
					bw.Write(0);
				}
			}
			bw.Write(this.m_ulReachSiteId);
			bw.Write(this.m_ulWaitTime);
			if (version >= 94)
			{
				ZONE_VERT.Write(version, bw, this.m_TreasureStartZone);
				bw.Write(this.m_ucZonesNumX);
				bw.Write(this.m_ucZonesNumZ);
				bw.Write(this.m_ucZoneSide);
			}
			if (version >= 137)
			{
				bw.Write(this.treasureZoneMapID);
			}
			int leave_site_count = GlobalFunctions.GetMaxTaskRegion(version);
			if (version >= 69)
			{
				if (version >= 80)
				{
					if (version < 176)
					{
						bw.Write(this.m_pLeaveSitePointer);
					}
					if (this.m_ulLeaveSiteCnt > leave_site_count)
					{
						bw.Write(leave_site_count);
					}
					else
					{
						bw.Write(this.m_ulLeaveSiteCnt);
					}
				}
				else
				{
					if (this.m_pLeaveSite.Length != 0)
					{
						Task_Region.Write(version, bw, this.m_pLeaveSite[0]);
					}
					else
					{
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
						bw.Write(0);
					}
				}
				bw.Write(this.m_ulLeaveSiteId);
			}
			if (version >= 59)
			{
				if (version < 135)
				{
					bw.Write(this.m_bFinNeedComp);
				}
				bw.Write(this.m_nFinExp1AndOrExp2);
				COMPARE_KEY_VALUE.Write(version, bw, this.m_Fin1KeyValue);
				COMPARE_KEY_VALUE.Write(version, bw, this.m_Fin2KeyValue);
			}
			if (version >= 178)
			{
				bw.Write(this.FinPersonExp1AndOrExp2);
				COMPARE_KEY_VALUE.Write(version, bw, this.FinPerson1KeyValue);
				COMPARE_KEY_VALUE.Write(version, bw, this.FinPerson2KeyValue);
			}
			if (version >= 63)
			{
				bw.Write(this.m_ulExpCnt);
				if (version < 176)
				{
					bw.Write(this.m_pszExpPointer);
					bw.Write(this.m_pExpArrPointer);
				}
			}
			if (version >= 178)
			{
				bw.Write(this.PersonExpCnt);
			}
			if (version >= 63)
			{
				bw.Write(this.m_ulTaskCharCnt);
				if (version < 176)
				{
					bw.Write(this.m_pTaskCharPointer);
				}
			}
			if (version >= 178)
			{
				bw.Write(this.PersonTaskCharCnt);
			}
			if (version >= 104)
			{
				bw.Write(this.m_ucTransformedForm);
			}
			if (version >= 156 && version < 175)
			{
				bw.Write(this.TransformedDescID);
			}
			if (version >= 113)
			{
				bw.Write(this.m_ulReachLevel);
				bw.Write(this.m_ulReachReincarnationCount);
				bw.Write(this.m_ulReachRealmLevel);
				bw.Write(this.m_uiEmotion);
			}
			if (version >= 153)
			{
				bw.Write(this.GrowthTarget);
			}
			if (version >= 122)
			{
				bw.Write(this.m_ulTMIconStateID);
			}
			if (version >= 156 && version < 175)
			{
				bw.Write(this.TMIconStateDescID);
			}
			if (version >= 127)
			{
				bw.Write(this.m_ulTMHomeLevelType);
			}
			if (version >= 126)
			{
				bw.Write(this.m_ulTMReachHomeLevel);
				bw.Write(this.m_ulTMReachHomeFlourish);
				bw.Write(this.m_ulHomeItemsWanted);
				if (version < 176)
				{
					bw.Write(this.m_HomeItemsWantedPointer);
				}
			}
			if (version >= 135)
			{
				bw.Write(this.TMBindCarrierId);
				if (version >= 140)
				{
					bw.Write(Convert.ToInt16(this.TMReachArenaTime));
				}
				else
				{
					bw.Write(this.TMReachArenaTime);
				}
			}
			if (version >= 137)
			{
				if (version >= 140)
				{
					bw.Write(Convert.ToInt16(this.ReachArenaWinCount));
				}
				else
				{
					bw.Write(this.ReachArenaWinCount);
				}
			}
			if (version >= 156)
			{
				GlobalFunctions.WriteNameChars(bw, this.Dialog);
			}
			if (version >= 167)
			{
				bw.Write(this.SuccTriggerEvent);
			}
			if (version >= 175)
			{
				bw.Write(this.VerifyStateLayer);
				bw.Write(this.VerifyStateLayerID);
				bw.Write(this.KeyWordIndex);
			}
			if (version >= 140)
			{
				GlobalFunctions.WriteNameChars(bw, this.TaskEventChar);
				bw.Write(this.TaskEventType);
				bw.Write(this.TaskEventTime);
				bw.Write(this.TaskEventMonsterCount);
				if (version < 176)
				{
					bw.Write(this.TaskEventMonsterDataPointer);
				}
				bw.Write(this.TaskEventMineCount);
				if (version < 176)
				{
					bw.Write(this.TaskEventMineDataPointer);
				}
				bw.Write(this.TaskEventTaskCount);
				if (version < 176)
				{
					bw.Write(this.TaskEventTaskDataPointer);
				}
			}
			if (version >= 146)
			{
				bw.Write(this.FactionPersonScore);
			}
			if (version >= 153)
			{
				bw.Write(this.TMTinyGameType);
			}
			if (version >= 158)
			{
				bw.Write(this.m_ulGold2Wanted);
			}
			bw.Write(this.m_ulAwardType_S);
			bw.Write(this.m_ulAwardType_F);
			if (version < 176)
			{
				bw.Write(this.m_Award_SPointer);
				bw.Write(this.m_Award_FPointer);
				bw.Write(this.m_AwByRatio_SPointer);
				bw.Write(this.m_AwByRatio_FPointer);
				bw.Write(this.m_AwByItems_SPointer);
				bw.Write(this.m_AwByItems_FPointer);
				if (version >= 140)
				{
					bw.Write(this.AwByTaskEventRatio_SPointer);
					bw.Write(this.AwByTaskEventRatio_FPointer);
				}
				if (version >= 146)
				{
					bw.Write(this.AwByCarrierHp_SPointer);
					bw.Write(this.AwByCarrierHp_FPointer);
				}
				if (version >= 161)
				{
					bw.Write(this.AwByVar_SPointer);
					bw.Write(this.AwByVar_FPointer);
				}
			}
			bw.Write(this.m_ulParent);
			bw.Write(this.m_ulPrevSibling);
			bw.Write(this.m_ulNextSibling);
			bw.Write(this.m_ulFirstChild);
			if (version >= 83)
			{
				if (version < 135)
				{
					bw.Write(this.m_bIsLibraryTask);
				}
				bw.Write(this.m_fLibraryTasksProbability);
			}
			if (version >= 95 && version < 135)
			{
				bw.Write(this.m_bIsUniqueStorageTask);
			}
			if (version >= 119)
			{
				bw.Write(this.m_iWorldContribution);
			}
			if (version >= 135)
			{
				byte[] combinedswitchestmp = new byte[GlobalFunctions.GetCombinedSwitches(version)];

				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByTransformed, this.m_bShowByTransformed);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByLev, this.m_bShowByLev);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremCheckReincarnation, this.m_bPremCheckReincarnation);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByReincarnation, this.m_bShowByReincarnation);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremCheckRealmLevel, this.m_bPremCheckRealmLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremCheckRealmExpFull, this.m_bPremCheckRealmExpFull);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByRealmLevel, this.m_bShowByRealmLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByItems, this.m_bShowByItems);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremItemsAnyOne, this.m_bPremItemsAnyOne);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.NotOpenWithItem, this.NotOpenWithItem);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByDeposit, this.m_bShowByDeposit);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByRepu, this.m_bShowByRepu);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByPreTask, this.m_bShowByPreTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByPeriod, this.m_bShowByPeriod);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByFaction, this.m_bShowByFaction);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByGender, this.m_bShowByGender);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByOccup, this.m_bShowByOccup);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.Premise_Spouse, this.m_bPremise_Spouse);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowBySpouse, this.m_bShowBySpouse);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremiseWeddingOwner, this.m_bPremiseWeddingOwner);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByWeddingOwner, this.m_bShowByWeddingOwner);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.GM, this.m_bGM);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShieldUser, this.m_bShieldUser);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByRMB, this.m_bShowByRMB);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CharTime, this.m_bCharTime);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByCharTime, this.m_bShowByCharTime);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.Teamwork, this.m_bTeamwork);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RcvByTeam, this.m_bRcvByTeam);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.SharedTask, this.m_bSharedTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.SharedAchieved, this.m_bSharedAchieved);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CheckTeammate, this.m_bCheckTeammate);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.AllFail, this.m_bAllFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CapFail, this.m_bCapFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CapSucc, this.m_bCapSucc);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DismAsSelfFail, this.m_bDismAsSelfFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RcvChckMem, this.m_bRcvChckMem);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CntByMemPos, this.m_bCntByMemPos);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.AllSucc, this.m_bAllSucc);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CoupleOnly, this.m_bCoupleOnly);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DistinguishedOcc, this.m_bDistinguishedOcc);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByTeam, this.m_bShowByTeam);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremNeedComp, this.m_bPremNeedComp);
				if (version >= 178)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremNeedCompPerson, this.PremNeedCompPerson);
				}
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremCheckForce, this.m_bPremCheckForce);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForce, this.m_bShowByForce);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForceReputation, this.m_bShowByForceReputation);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForceContribution, this.m_bShowByForceContribution);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForceExp, this.m_bShowByForceExp);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForceSP, this.m_bShowByForceSP);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByForceActivityLevel, this.m_bShowByForceActivityLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremIsKing, this.m_bPremIsKing);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByKing, this.m_bShowByKing);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremNotInTeam, this.m_bPremNotInTeam);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByNotInTeam, this.m_bShowByNotInTeam);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByTitle, this.m_bShowByTitle);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHistoryStage, this.m_bShowByHistoryStage);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByGeneralCard, this.m_bShowByGeneralCard);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByGeneralCardRank, this.m_bShowByGeneralCardRank);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByIconStateID, this.m_bShowByIconStateID);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByVIPLevel, this.m_bShowByVIPLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremNoHome, this.PremNoHome);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHomeLevel, this.m_bShowByHomeLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHomeResourceLevel, this.m_bShowByHomeResourceLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHomeFactoryLevel, this.m_bShowByHomeFactoryLevel);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHomeFlourish, this.m_bShowByHomeFlourish);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremHomeStorageTask, this.m_bPremHomeStorageTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByHomeStorageTask, this.m_bShowByHomeStorageTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.MonsterTotalCount, this.MonsterTotalCount);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.FinNeedComp, this.m_bFinNeedComp);
				if (version >= 178)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.FinNeedCompPerson, this.FinNeedCompPerson);
				}
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.IsLibraryTask, this.m_bIsLibraryTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.IsUniqueStorageTask, this.m_bIsUniqueStorageTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.HasSign, this.m_bHasSign);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.OfflineFail, this.m_bOfflineFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ItemNotTakeOff, this.m_bItemNotTakeOff);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.AbsTime, this.m_bAbsTime);
				if (version >= 180)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.MultiNpcTalk, this.MultiNpcTalk);
				}
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ChooseOne, this.m_bChooseOne);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RandOne, this.m_bRandOne);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ExeChildInOrder, this.m_bExeChildInOrder);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ParentAlsoFail, this.m_bParentAlsoFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ParentAlsoSucc, this.m_bParentAlsoSucc);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CanGiveUp, this.m_bCanGiveUp);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CanRedo, this.m_bCanRedo);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CanRedoAfterFailure, this.m_bCanRedoAfterFailure);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ClearAsGiveUp, this.m_bClearAsGiveUp);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.NeedRecord, this.m_bNeedRecord);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.FailAsPlayerDie, this.m_bFailAsPlayerDie);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DelvInZone, this.m_bDelvInZone);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.EnterRegionFail, this.m_bEnterRegionFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.LeaveRegionFail, this.m_bLeaveRegionFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.LeaveForceFail, this.m_bLeaveForceFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.TransTo, this.m_bTransTo);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.TrigCtrl, this.m_bTrigCtrl);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.AutoDeliver, this.m_bAutoDeliver);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DisplayInExclusiveUI, this.m_bDisplayInExclusiveUI);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ReadyToNotifyServer, this.m_bReadyToNotifyServer);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.UsedInTokenShop, this.m_bUsedInTokenShop);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DeathTrig, this.m_bDeathTrig);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ClearAcquired, this.m_bClearAcquired);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowPrompt, this.m_bShowPrompt);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.KeyTask, this.m_bKeyTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.SkillTask, this.m_bSkillTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CanSeekOut, this.m_bCanSeekOut);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowDirection, this.m_bShowDirection);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.Marriage, this.m_bMarriage);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.SwitchSceneFail, this.m_bSwitchSceneFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.Hidden, this.m_bHidden);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DeliverySkill, this.m_bDeliverySkill);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowGfxFinished, this.m_bShowGfxFinished);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ChangePQRanking, this.m_bChangePQRanking);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CompareItemAndInventory, this.m_bCompareItemAndInventory);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.TowerTask, this.m_bTowerTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.HomeTask, this.m_bHomeTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DeliverInHostHome, this.m_bDeliverInHostHome);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.FinishInHostHome, this.m_bFinishInHostHome);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PQTask, this.m_bPQTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PQSubTask, this.m_bPQSubTask);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ClearContrib, this.m_bClearContrib);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByNeedRecordTasksNum, this.m_bShowByNeedRecordTasksNum);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByFactionContrib, this.m_bShowByFactionContrib);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.AccountTaskLimit, this.m_bAccountTaskLimit);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RoleTaskLimit, this.m_bRoleTaskLimit);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.LeaveFactionFail, this.m_bLeaveFactionFail);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.NotIncCntWhenFailed, this.m_bNotIncCntWhenFailed);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.NotClearItemWhenFailed, this.m_bNotClearItemWhenFailed);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DisplayInTitleTaskUI, this.m_bDisplayInTitleTaskUI);
				GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CanAwardOnCarrier, this.CanAwardOnCarrier);
				if (version >= 137)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PreReachArenaWinCount, this.PreReachArenaWinCount);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByReachArenaWinCount, this.ShowByReachArenaWinCount);
				}
				if (version >= 140)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.WriteSpecialLog, this.WriteSpecialLog);
				}
				if (version >= 146)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByPreFactionScore, this.ShowByPreFactionScore);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByPreFactionMoney, this.ShowByPreFactionMoney);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByPreFactionPersonScore, this.ShowByPreFactionPersonScore);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.CheckFactionMem, this.CheckFactionMem);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ByFactionScore, this.ByFactionScore);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.SpecailLogicTask, this.SpecailLogicTask);
				}
				if (version >= 153)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.BecomeMentor, this.BecomeMentor);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowMentorMorality, this.ShowMentorMorality);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowMentorStudent, this.ShowMentorStudent);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DiscardedTask, this.DiscardedTask);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.NoCheckTitleGot, this.NoCheckTitleGot);
				}
				if (version >= 156)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowCoupleIntimacy, this.ShowCoupleIntimacy);
				}
				if (version >= 158)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowByDeposit2, this.m_bShowByDeposit2);
					//GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RESERVED145, this.RESERVED145);
				}
				if (version >= 163)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RecordFinishCount, this.RecordFinishCount);
				}
				if (version >= 167)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowCamp, this.ShowCamp);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowCampPower, this.ShowCampPower);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ReturnCampPower, this.ReturnCampPower);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.TeamHaveRecaller, this.TeamHaveRecaller);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.BindedRecaller, this.BindedRecaller);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.ShowNeedFriendPoint, this.ShowNeedFriendPoint);
				}
				if (version >= 175)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.HistoryVarTask, this.HistoryVarTask);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.PremRank, this.PremRank);
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.DeliverByUI, this.DeliverByUI);
				}
				if (version >= 177)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.WarTaskAward, this.WarTaskAward);
				}
				if (version >= 180)
				{
					GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.HideOtherPlayer, this.HideOtherPlayer);
					//GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RESERVED158, this.RESERVED158);
					//GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RESERVED159, this.RESERVED159);
					//GlobalFunctions.SetParam(version, combinedswitchestmp, (int)GlobalData.TaskParameters.RESERVED160, this.RESERVED160);
				}
				bw.Write(combinedswitchestmp);
			}
			if (version == 139)
			{
				bw.Write(this.WriteSpecialLog);
			}
			if (version >= 146)
			{
				int SPParamTypeCount = 0;
				for (int i = 0; i < this.SpecialParameters.ParameterTypes.Length; i++)
				{
					if (SPECIAL_PARAMETERS.CheckParameter(version, this.SpecialParameters.ParameterTypes[i]))
						SPParamTypeCount++;
				}
				bw.Write(SPParamTypeCount);
				if (version < 176)
				{
					bw.Write(this.SpecialParametersPointer);
				}
			}
			if (this.m_bHasSign)
			{
				GlobalFunctions.WriteNameChars(bw, this.m_pszSignature);
			}
			for (int i = 0; i < this.m_ulTimetable && i < timetable_count; i++)
			{
				task_tm.Write(version, bw, this.m_tmStart[i]);
				task_tm.Write(version, bw, this.m_tmEnd[i]);
			}
			if (version >= 59)
			{
				for (int i = 0; i < this.m_ulChangeKeyCnt; i++)
				{
					bw.Write(this.m_plChangeKey[i]);
					bw.Write(this.m_plChangeKeyValue[i]);
					bw.Write(this.m_pbChangeType[i]);
				}
			}
			if (version >= 178)
			{
				for (int i = 0; i < this.PersonChangeKeyCnt; i++)
				{
					bw.Write(this.PersonChangeKey[i]);
					bw.Write(this.PersonChangeKeyValue[i]);
					bw.Write(this.PersonChangeType[i]);
				}
			}
			if (version >= 75)
			{
				for (int i = 0; i < this.m_ulPQExpCnt; i++)
				{
					GlobalFunctions.WriteChars(bw, this.m_pszPQExp[i]);
					for (int j = 0; j < this.m_pPQExpArr[i].Length; j++)
					{
						TASK_EXPRESSION.Write(version, bw, this.m_pPQExpArr[i][j]);
					}
				}
				for (int i = 0; i < this.m_ulMonsterContribCnt; i++)
				{
					MONSTERS_CONTRIB.Write(version, bw, this.m_MonstersContrib[i]);
				}
			}
			if (version >= 80)
			{
				for (int i = 0; i < this.m_ulDelvRegionCnt && i < delv_region_count; i++)
				{
					Task_Region.Write(version, bw, this.m_pDelvRegion[i]);
				}
				for (int i = 0; i < this.m_ulEnterRegionCnt && i < enter_region_count; i++)
				{
					Task_Region.Write(version, bw, this.m_pEnterRegion[i]);
				}
				for (int i = 0; i < this.m_ulLeaveRegionCnt && i < leave_region_count; i++)
				{
					Task_Region.Write(version, bw, this.m_pLeaveRegion[i]);
				}
			}
			for (int i = 0; i < this.m_ulPremItems; i++)
			{
				ITEM_WANTED.Write(version, bw, this.m_PremItems[i]);
			}
			for (int i = 0; i < this.m_ulGivenItems; i++)
			{
				ITEM_WANTED.Write(version, bw, this.m_GivenItems[i]);
			}
			if (this.m_bTeamwork)
			{
				for (int i = 0; i < this.m_ulTeamMemsWanted; i++)
				{
					TEAM_MEM_WANTED.Write(version, bw, this.m_TeamMemsWanted[i]);
				}
			}
			if (version >= 109)
			{
				for (int i = 0; i < this.m_iPremTitleNumTotal; i++)
				{
					bw.Write(this.m_PremTitles[i]);
				}
			}
			for (int i = 0; i < this.m_ulMonsterWanted && i < monster_wanted_count; i++)
			{
				MONSTER_WANTED.Write(version, bw, this.m_MonsterWanted[i]);
			}
			if (version >= 103)
			{
				for (int i = 0; i < this.m_ulPlayerWanted && i < player_wanted_count; i++)
				{
					PLAYER_WANTED.Write(version, bw, this.m_PlayerWanted[i]);
				}
			}
			for (int i = 0; i < this.m_ulItemsWanted; i++)
			{
				ITEM_WANTED.Write(version, bw, this.m_ItemsWanted[i]);
			}
			if (version >= 63)
			{
				for (int i = 0; i < this.m_ulExpCnt; i++)
				{
					GlobalFunctions.WriteChars(bw, this.m_pszExp[i]);
					for (int j = 0; j < this.m_pExpArr[i].Length; j++)
					{
						TASK_EXPRESSION.Write(version, bw, this.m_pExpArr[i][j]);
					}
				}
			}
			if (version >= 178)
			{
				for (int i = 0; i < this.PersonExpCnt; i++)
				{
					GlobalFunctions.WriteChars(bw, this.PersonExp[i]);
					for (int j = 0; j < this.PersonExpArr[i].Length; j++)
					{
						TASK_EXPRESSION.Write(version, bw, this.PersonExpArr[i][j]);
					}
				}
			}
			if (version >= 63)
			{
				for (int i = 0; i < this.m_ulTaskCharCnt; i++)
				{
					GlobalFunctions.WriteNameChars(bw, this.m_pTaskChar[i]);
				}
			}
			if (version >= 178)
			{
				for (int i = 0; i < this.PersonTaskCharCnt; i++)
				{
					GlobalFunctions.WriteNameChars(bw, this.PersonTaskChar[i]);
				}
			}
			if (version >= 80)
			{
				for (int i = 0; i < this.m_ulReachSiteCnt && i < reach_site_count; i++)
				{
					Task_Region.Write(version, bw, this.m_pReachSite[i]);
				}
				for (int i = 0; i < this.m_ulLeaveSiteCnt && i < leave_site_count; i++)
				{
					Task_Region.Write(version, bw, this.m_pLeaveSite[i]);
				}
			}
			if (version >= 126)
			{
				for (int i = 0; i < this.m_ulHomeItemsWanted; i++)
				{
					HOME_ITEM_WANTED.Write(version, bw, this.m_HomeItemsWanted[i]);
				}
			}
			if (version >= 140)
			{
				for (int i = 0; i < this.TaskEventMonsterCount; i++)
				{
					TaskEventData.Write(version, bw, this.TaskEventMonsterData[i]);
				}
				for (int i = 0; i < this.TaskEventMineCount; i++)
				{
					TaskEventData.Write(version, bw, this.TaskEventMineData[i]);
				}
				for (int i = 0; i < this.TaskEventTaskCount; i++)
				{
					TaskEventData.Write(version, bw, this.TaskEventTaskData[i]);
				}
			}
			AWARD_DATA.Write(version, bw, this.m_Award_S);
			AWARD_DATA.Write(version, bw, this.m_Award_F);
			AWARD_RATIO_SCALE.Write(version, bw, this.m_AwByRatio_S);
			AWARD_RATIO_SCALE.Write(version, bw, this.m_AwByRatio_F);
			AWARD_ITEMS_SCALE.Write(version, bw, this.m_AwByItems_S);
			AWARD_ITEMS_SCALE.Write(version, bw, this.m_AwByItems_F);
			if (version >= 140)
			{
				AWARD_RATIO_SCALE.Write(version, bw, this.AwByTaskEventRatio_S);
				AWARD_RATIO_SCALE.Write(version, bw, this.AwByTaskEventRatio_F);
			}
			if (version >= 146)
			{
				AWARD_CARRIER_HP_SCALE.Write(version, bw, this.AwByCarrierHp_S);
				AWARD_CARRIER_HP_SCALE.Write(version, bw, this.AwByCarrierHp_F);
			}
			if (version >= 161)
			{
				AWARD_VAR_SCALE.Write(version, bw, this.AwByVar_S);
				AWARD_VAR_SCALE.Write(version, bw, this.AwByVar_F);
			}
			if (version >= 146)
			{
				SPECIAL_PARAMETERS.Write(version, (int)combinedswitch5tmp, bw, this.SpecialParameters);
			}
		}
	}
}
//(c)Rey35
