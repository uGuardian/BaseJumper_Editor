using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIDeckList : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private GameObject root_CardList;

	[SerializeField]
	private RectTransform slotsContent;

	[SerializeField]
	private ScrollRect slotsScrollRect;

	[SerializeField]
	private List<UIDeckSlot> slots;

	[SerializeField]
	private UILibrarianEquipDeckPanel rootdeckPanel;

	[SerializeField]
	private UIDeckInfoPopup deckInfoPopup;

	[SerializeField]
	private UICustomGraphicObject CloseButton;

	[Header("Controller")]
	public UICustomSelectablePanel listSelectablePanel;

	private List<DeckSlotModel> deckListData;

	[Header("Frame")]
	public Image img_DeckFrame;

	private int curIndex;

	public UIDeckState currentPanelState;

	public bool isDeckInfoPopupOpened
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int CurIndex
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialized()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurIndex(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenInit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCloseInfoPopup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeSlotModel(int id, DeckSlotModel deckslotdata)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSlot(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeckSelectList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeckSaveList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenDeckInfoPopup(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseDeckInfoPopup()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenDeckInfoEditor(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshDeckInfoEditor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOn(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSlotsNavigation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIDeckList()
	{
		throw null;
	}
}
