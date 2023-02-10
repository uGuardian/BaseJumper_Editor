using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class DropBookInventoryModel : Singleton<DropBookInventoryModel>, Savable
{
	public const string save_bookList = "bookList";

	public const string save_id = "id";

	public const string save_num = "numm";

	private List<OwnDropBookModel> _bookList;

	private Dictionary<LorId, OwnDropBookModel> _bookDictionary;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OwnDropBookModel AddBook(int bookId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OwnDropBookModel AddBook(LorId bookId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveAllErrorBookBook()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveBook(LorId bookId, int num = 1)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OwnDropBookModel GetBook(LorId bookId)
	{
		throw null;
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
	public List<OwnDropBookModel> GetBookList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<LorId> GetBookList_invitationBookList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<OwnDropBookModel> GetBookList_usable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<LorId> GetBookIdList_usable()
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
	public DropBookInventoryModel()
	{
		throw null;
	}
}
