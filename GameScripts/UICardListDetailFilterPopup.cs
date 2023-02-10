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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(UICardListFilter cardFilter)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Open()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Close()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateFilterSlots()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickApplyButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickResetButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetDetailFilterData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetDetailFilterData()
	{
		throw null;
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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOn(int group)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICardListDetailFilterPopup()
	{
		throw null;
	}
}
