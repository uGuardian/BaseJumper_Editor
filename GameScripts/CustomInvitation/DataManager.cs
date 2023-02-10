using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class DataManager
	{
		private static DataManager _instance;

		public const string VERSION = "1.1";

		private const string STAGE_INFO_LOCAL_PATH = "Data\\StageInfo.xml";

		private const string ENEMYUNIT_INFO_LOCAL_PATH = "Data\\EnemyUnitInfo.xml";

		private const string ENEMY_KEYPAGE_INFO_LOCAL_PATH = "Data\\EquipPage_Enemy.xml";

		private const string DIALOG_INFO_LOCAL_PATH = "Data\\Combat_Dialog.xml";

		private const string KEYPAGE_STORY_LOCAL_PATH = "Data\\BookStory.xml";

		private const string ENEMY_DECK_INFO_LOCAL_PATH = "Data\\Deck_Enemy.xml";

		private const string LIBRARIAN_KEYPAGE_INFO_LOCAL_PATH = "Data\\EquipPage_Librarian.xml";

		private const string DROPBOOK_LOCAL_PATH = "Data\\Dropbook.xml";

		private const string CARDDROPTABLE_LOCAL_PATH = "Data\\CardDropTable.xml";

		private const string COMBATPAGE_LOCAL_PATH = "Data\\CardInfo.xml";

		private const string PASSIVE_LOCAL_PATH = "Data\\PassiveList.xml";

		public const string ARTWORK_PATH = "Resource\\CombatPageArtwork";

		public const string CHARACTERSKIN_PATH = "Resource\\CharacterSkin";

		public const string STORY_EFFECT_PATH = "Data\\StoryEffect";

		public const string STORY_PATH = "Data\\StoryText";

		public const string MOTION_SOUND_PATH = "Resource\\MotionSound";

		private NormalInvitation _invitationInfo;

		private StageXmlRoot _stageInfoRoot;

		private EnemyUnitClassRoot _enemyUnitInfoRoot;

		private DiceCardXmlRoot _cardInfoRoot;

		private BookUseXmlRoot _dropbookRoot;

		private CardDropTableXmlRoot _dropCardRoot;

		private BookXmlRoot _enemyKeyPageRoot;

		private DeckXmlRoot _enemyDeckRoot;

		private BookXmlRoot _librarianKeyPageRoot;

		private BattleDialogRoot _dialogRoot;

		private BookDescRoot _bookStoryRoot;

		private PassiveXmlRoot _passiveRoot;

		public const int LIBRARIAN_KEYPAGE_ID_ADDER = 10000000;

		public static DataManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int ConvertModVer(string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DataManager()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SaveToLocalFile(string curWorkingDir, bool isNew = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadFromLocalFile(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWorkshopPackageId(string packageId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWorkshopTitle(string title)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWorkshopDesc(string desc)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetWorkshopPreviewPath(string path)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NormalInvitation GetInvitationMetaData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<ValueInfo> CheckValideWorkshopInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteCardInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeletePassiveInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyKeyPageInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyUnitInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SerializeStageModInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeStageModInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private InvitationFile CreateInvitationFileInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private FileInfo CreateFileInfo(string curWorkingDir, string additionalPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetNewId(List<int> existingIdList, int startId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckFiles()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckStageInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckEnemyUnitInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckEnemyKeyPageInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckLibrarianKeyPageInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckDropBookInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckCombatPageInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckDialogInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckKeyPageStoryInfo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceCardXmlInfo> GetCombatPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo GetCombatPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteCombatPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceCardXmlInfo AddCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeCombatPageInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeCombatPageInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogCharacter SetDialog(int id, Dictionary<DialogType, List<string>> dialogDict)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogCharacter GetDialog(int characterID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleDialogCharacter AddDialogPreset(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteDialogPreset(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyKeyPageInfo_Dialog(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeDialogInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeDialogInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DropBookXmlInfo> GetDropBookList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookXmlInfo GetDropBook(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookXmlInfo AddDropBook()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteDropBook(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteCardInfo_DropbookInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyUnitInfo_Dropbook(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<CardDropTableXmlInfo> GetCardDropList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardDropTableXmlInfo GetDropCard(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeDropBookInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeDropBookInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeCardDropTableInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeCardDropTableInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DeckXmlInfo> GetEnemyDeckList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckXmlInfo GetEnemyDeck(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckXmlInfo AddEnemyDeck(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteEnemyDeck(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteCardInfo_EnemyDeck(int cardId)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyKeyPageInfo_EnemyDeck(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeEnemyDeckInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeEnemyDeckInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetEnemyKeyPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlInfo GetEnemyKeyPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlInfo AddEnemyKeyPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteEnemyKeyPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeletePassiveInfo_EnemyKeyPageInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConvertBookRootVer10toVer11(BookXmlRoot root)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeEnemyKeyPageInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeEnemyKeyPageInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<EnemyUnitClassInfo> GetEnemyUnitList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitClassInfo GetEnemyUnit(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitClassInfo AddEnemyUnit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteEnemyUnit(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyKeyPageInfo_EnemyUnitInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeEnemyUnitInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeEnemyUnitInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKeyPageStory(int id, string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetKeypageStoryText(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookDesc AddKeyPageStory(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteKeyPageStory(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyKeyPageInfo_KeyPageStory(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeKeyPageStory(string curWorkinDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeKeyPageStory(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookXmlInfo> GetLibrarianKeyPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlInfo GetLibrarianKeyPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookXmlInfo AddLibrarianKeyPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteLibrarianKeyPage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeletePassiveInfo_LibrarianKeyPageInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeLibrarianKeyPageInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeLibrarianKeyPageInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<PassiveXmlInfo> GetPassiveList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveXmlInfo GetPassive(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeletePassive(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveXmlInfo AddPassive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializePassiveInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializePassiveInfo(string absolutePath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<StageClassInfo> GetStageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageClassInfo AddStage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool DeleteStage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeleteEnemyUnitInfo_StageInfo(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageClassInfo GetStage(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshStageID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private string SerializeStageInfo(string curWorkingDir)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool DeserializeStageInfo(string absolutePath)
		{
			throw null;
		}
	}
}
