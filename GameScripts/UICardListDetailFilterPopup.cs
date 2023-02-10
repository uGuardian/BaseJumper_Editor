using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UICardListDetailFilterPopup : UIPopup
{
	private static UICardListDetailFilterPopup _instance;

	[SerializeField]
	private RectTransform GroupsContent;

	[SerializeField]
	private ScrollRect scrollRect;

	private List<UICardListDetailFilterGroup> Groups;

	public bool isValid;

	private UICardListFilter panel;

	[Header("Selectables")]
	public UICustomSelectablePanel selectablePanel;

	[SerializeField]
	private List<GameObject> controllerGuides;

	private CardListDetailFilterData detailFilterData;

	public static UICardListDetailFilterPopup Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(UICardListFilter cardFilter)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Open()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Close()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFilterSlots()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickApplyButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickResetButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDetailFilterData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDetailFilterData()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> CheckRarityDetailFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> CheckDiceDetailFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> CheckBufDetailFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<string> CheckAbilityDetailFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<int> CheckDiceCountDetailFilter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOn(int group)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICardListDetailFilterPopup()
	{
		throw null;
	}
}
