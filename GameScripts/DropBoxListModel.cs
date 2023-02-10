﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class DropBoxListModel : Singleton<DropBoxListModel>, Savable
{
	public const string save_dropBoxList = "dropBoxList";

	public const string save_id = "id";

	public const string save_dropBox = "dropBox";

	private Dictionary<LorId, DropBoxInfo> _dropBoxTable;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<DropBoxCount> GetEquipDropBoxCountInfoTable(LorId dropBookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddEquipCount(LorId dropBookId, LorId equipPageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardCount(LorId dropBookId, LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEmptyBox(LorId dropBookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reset(LorId dropBookId)
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
	public DropBoxListModel()
	{
		throw null;
	}
}
