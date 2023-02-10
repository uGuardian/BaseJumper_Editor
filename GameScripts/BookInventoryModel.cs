using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class BookInventoryModel : Singleton<BookInventoryModel>, Savable
{
	public const int blackSilenceBookId = 102;

	public readonly int blackSilenceBookInstanceId;

	public const string save_bookList = "bookList";

	public const string save_blackSilence = "blackSilence";

	public const int inventorySpace = 2147483647;

	private List<BookModel> _bookList;

	private BookModel _blackSilenceBook;

	private int _nextInstanceId;

	private BookCountCache _countCache;

	private Dictionary<int, List<BookModel>> testdic;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBookCount(int bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBookCount(LorId bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel CreateBook(LorId bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel CreateBook(BookXmlInfo bookClassInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ClearBookList(int capacity = 0)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddBook(BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool RemoveBook(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBookByFeed(BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SwapBook(BookModel removebook, BookModel addbook)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetBookByXmlId(int bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetBookByInstanceId(int bookInstanceId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetAllBookByInstanceId(int bookInstanceId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetBlackSilenceBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetBookByInstanceIdInAllBookEquiped(int bookInstanceId, int equipedbook, bool origin = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetBookList_feed()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetBookList_equip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetBookList_equipWithOutEquipedBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetBookList_PassiveEquip(BookModel booktobeEquiped)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetEquipCount(SephirahType sephirah, LorId equipId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HashSet<LorId> GetIdList_noDuplicate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookModel> GetBookListAll()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BookCardOwnResult> GetInventoryBookListByCard(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookModel GetEquipbookByInstanceId(int instanceid)
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ValidateInstnaceId()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveAllCardToCardInventory()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveLimitedEquips()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllErrorBookWithUnequip()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBookWithUnequip(BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBooksTypeCount()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookInventoryModel()
	{
		throw null;
	}
}
