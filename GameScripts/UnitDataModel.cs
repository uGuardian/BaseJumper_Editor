using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_DiceSystem;

public class UnitDataModel : Savable
{
	public const string save_name = "name";

	public const string save_nameID = "nameID";

	public const string save_prefixID = "prefixID";

	public const string save_postfixID = "postfixID";

	public const string save_appearance = "appearance";

	public const string save_workshopSkin = "workshopSkin";

	public const string save_script = "script";

	public const string save_bookInstanceId = "bookInstanceId";

	public const string save_customcorebookInstanceId = "customcorebookInstanceId";

	public const string save_defaultBook = "defaultBook";

	public const string save_giftInventory = "giftInventory";

	public const string save_deck = "deck";

	public const string save_history = "history";

	public const string save_AppearanceType = "appearanceType";

	private BookModel _defaultBook;

	private BookModel _blackSilenceBook;

	private string _name;

	private string _tempName;

	private int _nameID;

	public int prefixID;

	public int postfixID;

	public UnitGradeType grade;

	private BookModel _bookItem;

	private BookModel _CustomBookItem;

	public string workshopSkin;

	public GiftInventory giftInventory;

	private UnitCustomizingData _customizeData;

	public int size;

	public BattleDialogueModel battleDialogModel;

	private UnitHistoryModel _history;

	private float _dropBonus;

	private Dictionary<int, DropTable> _dropTable;

	private List<EmotionSetInfo> _emotionList;

	public int textureIndex;

	private int _expDrop;

	private LorId _enemyUnitId;

	public string aiScript;

	public int bonusHp;

	public int bonusBreak;

	public bool isSephirah;

	private SephirahType _ownerSephirah;

	public Gender gender;

	public Gender appearanceType;

	public bool isUnknownBattleSetting;

	public bool forceItemChangeLock;

	public BookModel defaultBook
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BookModel blackSilenceBook
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public string name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int nameID
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BookModel bookItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetCustomBookItemData()
	{
		throw null;
	}

	public BookModel CustomBookItem
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UnitCustomizingData customizeData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UnitHistoryModel history
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public float DropBonus
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Dictionary<int, DropTable> DropTable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int ExpDrop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public LorId EnemyUnitId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int StartHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxHp
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int Break
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int MaxEmotionLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public SephirahType OwnerSephirah
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitDataModel(int defaultBook = 31, SephirahType sephirah = SephirahType.None, bool isSephirahChar = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitDataModel(LorId defaultBook, SephirahType sephirah = SephirahType.None, bool isSephirahChar = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init(LorId defaultBook, SephirahType sephirah = SephirahType.None, bool isSephirahChar = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTemporaryPlayerUnitByBook(int bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTemporaryPlayerUnitByBook(LorId bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetByEnemyUnitClassInfo(EnemyUnitClassInfo classInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EquipBookForUI(BookModel newBook, bool isEnemySetting = false, bool force = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EquipBook(BookModel newBook, bool isEnemySetting = false, bool force = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EquipCustomCoreBook(BookModel custombook)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCustomName(string txt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTempName(string txt)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetTempName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetNameId(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitBattleDialogByDefaultBook(LorId lorId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetDeckSize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStartDraw()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnemyDropTable(EnemyUnitClassInfo classInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEnemyEmotionList(List<EmotionSetInfo> emotionList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlInfo GetEmotionCardInfo(MentalState state, int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> GetEquippedGiftList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetDeckList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetDeckForBattle(int index = 0)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardEquipState AddCardInDeckFromInventory(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveCardInDeck(DiceCardXmlInfo card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetForBlackSilence()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCustomizingData(UnitCustomizingData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetDeckAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetDeckAllList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<DiceCardXmlInfo> GetCardList(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardItemModel> GetDeckCardModelAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardEquipState AddCardFromInventory(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCardToInventory(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmptyDeckToInventoryAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EmptyDeckToInventory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReEquipDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDeckByDeckInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBasicBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLockUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isLockUnitForBluePrimary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsChangeItemLock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBinahChangeItemLock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBlackSilenceChangeItemLock()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsGebura()
	{
		throw null;
	}
}
