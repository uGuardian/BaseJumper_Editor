﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class CustomCoreBookInventoryModel : Singleton<CustomCoreBookInventoryModel>, Savable
{
	public const string save_customcorebookList = "customcorebookList";

	public const string save_customcorebookListV2 = "customcorebookListV2";

	public const int inventorySpace = 300;

	private List<int> CustomCoreBookIdListV2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBook(LorId bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddBook(int bookid)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<int> GetBookIdList_CustomCoreBook(SephirahType sep, bool issep)
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
	public void AddDefaultBook()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CustomCoreBookInventoryModel()
	{
		throw null;
	}
}
