using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class EditorCardListPanel : MonoBehaviour
{
	[SerializeField]
	private GameObject cardSummaryPrefab;

	[SerializeField]
	private Transform cardListParent;

	private List<EditorCardSummary> _summaryList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitList(List<DiceCardXmlInfo> list)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(DiceCardXmlInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModifyInfo(DiceCardXmlInfo info)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditorCardListPanel()
	{
		throw null;
	}
}
