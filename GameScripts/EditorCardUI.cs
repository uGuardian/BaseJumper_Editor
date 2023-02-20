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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadXmlData(string path)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectCardSummary(EditorCardSummary summary)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickSave()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ModifiyCardSummaryInfo(DiceCardXmlInfo cardInfo)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickAddCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EditorCardUI()
	{
		throw null;
	}
}
