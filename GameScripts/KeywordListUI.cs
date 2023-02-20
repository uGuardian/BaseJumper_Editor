using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class KeywordListUI : MonoBehaviour
{
	public KeywordUI[] keywordList;

	private Dictionary<string, int> keywordDict;

	[Header("Battle Hand UI Keword")]
	[SerializeField]
	private bool isBattleHandUI;

	private readonly float CHANGE_Height;

	private readonly float ChangeNumber;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(DiceCardXmlInfo cardInfo, List<DiceBehaviour> behaviourList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deactivate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KeywordListUI()
	{
		throw null;
	}
}
