using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class DropBoxInfo : Savable
{
	public const string save_dropBookId = "dropBookId";

	public const string save_equipList = "equipList";

	public const string save_cardList = "cardList";

	public const string save_id = "id";

	public const string save_count = "count";

	public LorId dropBookId;

	public Dictionary<LorId, int> equipCountTable;

	public Dictionary<LorId, int> cardCountTable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEquipCount(LorId equipPageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentEquipCount(LorId equipPageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardCount(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetCurrentCardCount(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset()
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
	public DropBoxInfo()
	{
		throw null;
	}
}
