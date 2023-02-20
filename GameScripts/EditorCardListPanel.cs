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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Clear()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCard(DiceCardXmlInfo info)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModifyInfo(DiceCardXmlInfo info)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditorCardListPanel()
	{
		throw null;
	}
}
