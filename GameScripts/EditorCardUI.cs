using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

public class EditorCardUI : MonoBehaviour
{
	private static EditorCardUI _instance;

	public EditorCardListPanel cardListPanel;

	public EditorCardInfoPanel cardInfoPanel;

	private const string path = "Xml/Card/CardInfoAGF_V2";

	private DiceCardXmlRoot cardXmlRoot;

	public static EditorCardUI Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadXmlData(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectCardSummary(EditorCardSummary summary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSave()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModifiyCardSummaryInfo(DiceCardXmlInfo cardInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditorCardUI()
	{
		throw null;
	}
}
