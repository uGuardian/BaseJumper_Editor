using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;
using LOR_DiceSystem;
using UnityEngine;

public class BookModel : Savable
{
	public const string save_id = "id";

	public const string save_level = "level";

	public const string save_ver2level = "ver2level";

	public const string save_exp = "exp";

	public const string save_invenlock = "invenlock";

	public const string save_passiveList = "passiveList";

	public const string save_instanceId = "instanceId";

	public const string save_deck = "deck";

	public const string save_deck2 = "deck2";

	public const string save_deck3 = "deck3";

	public const string save_deck4 = "deck4";

	public const string save_equipedpassivebookInstanceId = "equipedpassivebookinstanceid";

	public const string save_equipedbookList = "equipedbooklist";

	public const string save_bookmark = "bookmark";

	private BookXmlInfo _classInfo;

	private List<DiceCardXmlInfo> _onlyCards;

	private List<DiceCardXmlInfo> _soulCards;

	private List<PassiveModel> _activatedAllPassives;

	public BookModel.BookEquipedBookSavedData originData;

	public BookModel.BookEquipedBookSavedData reservedData;

	private DeckModel _deck;

	private List<DeckModel> _deckList;

	private int isBookMark;

	public int instanceId;

	public AtkResist sHpResist;

	public AtkResist pHpResist;

	public AtkResist hHpResist;

	public AtkResist sBpResist;

	public AtkResist pBpResist;

	public AtkResist hBpResist;

	private int isLockInventory;

	private string _selectedOriginalSkin;

	private string _characterSkin;

	private int _startPlayPoint;

	private int _maxPlayPoint;

	private int _maxHp;

	private int _maxBp;

	private int _speedMin;

	private int _speedMax;

	private int _speedDiceNum;

	public UnitDataModel owner;

	public UnitDataModel basicBookOwner;

	private readonly string save_NewPassive;

	public BookXmlInfo ClassInfo
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public LorId BookId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsWorkshop
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel(BookXmlInfo classInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetXmlInfo(BookXmlInfo classInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMultiDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsFixedDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetCardListFromCurrentDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetCardListFromAllDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetCardListByIndex(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardItemModel> GetDeckCardModelAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCardCount(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DeckModel> GetDeckAll_nocopy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeckModel CopyCurrentDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardEquipState AddCardFromInventoryToCurrentDeck(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool MoveCardFromCurrentDeckToInventory(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsLockByBluePrimary()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEmptyDeckAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEmptyDeck(int idx = 0)
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
	public bool IsDeckLocked()
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
	public void ChangeDeck(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentDeckIndex()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LorId GetBookClassInfoId()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ContainsCategory(BookCategory category)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookCategory> GetBookCategories()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Rarity GetRarity()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetRarityText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetLimit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCharacterName(string s)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalCharacterName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetOriginalCharcterName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetCharacterName()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite GetThumbSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalResists()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalSpeedNum()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalSpeed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOriginalStat()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResistHP(BehaviourDetail detail, AtkResist resist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetResistBP(BehaviourDetail detail, AtkResist resist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistHP(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public AtkResist GetResistBP(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeedDiceMin(int minValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeedDiceMax(int maxValue)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSpeedDiceNum(int num)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetStartPlayPoint(int playPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetStartPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxPlayPoint(int maxPoint)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxPlayPoint()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHp(int maxHp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBp(int maxBp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float GetResistRate(AtkResist atkResist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistHP_Text(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistHP_Text(BehaviourDetail detail, AtkResist atkResist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistBP_Text(BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetResistBP_Text(BehaviourDetail detail, AtkResist atkResist)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsBasicBook()
	{
		throw null;
	}

	public string Name
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int HpReduction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int DeadLine
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int HP
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

	public int AddedStartDraw
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int EmotionLevel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int SpeedMin
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int SpeedMax
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int SpeedDiceNum
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Rarity Rarity
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsRandomFace
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Sprite bookIcon
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Sprite bookIconGlow
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public BookEquipEffect equipeffect
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOwner(UnitDataModel newOwner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetBasicBookOwner(UnitDataModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetOnlyCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DiceCardXmlInfo> GetSoulCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel CreateSoulCard(int emotionLevel)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpeedDiceRule GetSpeedDiceRule(BattleUnitModel unit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetSpeedDiceText()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxLevel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateDeckByDeckInfo()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGainPassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryGainUniquePassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SortPassive(List<PassiveModel> passivelist = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckExistCurrentPassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckOverPassiveCost(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckOverlapPassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckDeletePassiveOtherBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PassiveAbilityBase> CreatePassiveList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookPassiveInfo> GetPassiveInfoList(bool onlyActivated = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitReservedDataForPassiveSuccession()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyPassiveSuccession()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PassiveModel> GetPassiveModelList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool isExistGivePassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangePassive(PassiveModel currentBookPassive, PassiveModel changeBookPassive)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleasePassive(PassiveModel passive, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanEquipBookByGivePassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsNotFullEquipPassiveBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanToGivePassiveBook(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEquipedPassiveBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool EquipGivePassiveBook(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnEquipGivePassiveBook(BookModel unequipbook, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleaseAllEquipedPassiveBooks(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<PassiveModel> GetSuccessionPassivesByBook(BookModel book, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIPassiveBookEquipType GetPassiveBookState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetGiveBookModel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetEquipedBookList(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLockInventory(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResisterBookMark(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetBookMarkState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool GetLockInventoryState()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckExistPassiveBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Test2()
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
	public void LoadFromSaveDataExceptId(SaveData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckCustomCoreBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSuccessionPassive(PassiveModel targetpassive, out GivePassiveState haspassiveState)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static BookModel CreateBookForWorkshop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentPassiveCost(bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExistReceivedPassive()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetMaxPassiveCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsMaxCost()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanSuccessionPassiveByCost(PassiveModel prevpassive, PassiveModel nextpassive, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPossibleRemainCost(PassiveModel ownequipedPassive, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReleasePassiveAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SephirahType IsCanUsingEquipPageWhenBlueReverberation()
	{
		throw null;
	}

	public class BookEquipedBookSavedData
	{
		public List<int> equipedBookIdListInPassive;

		public int equipedPassiveBookInstanceId;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookEquipedBookSavedData()
		{
			throw null;
		}
	}
}
