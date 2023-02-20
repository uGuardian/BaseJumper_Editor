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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCurIndex(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenInit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCancel()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCloseInfoPopup()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeSlotModel(int id, DeckSlotModel deckslotdata)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DeleteSlot(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeckSelectList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetDeckSaveList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenDeckInfoPopup(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseDeckInfoPopup()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OpenDeckInfoEditor(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RefreshDeckInfoEditor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOn(int id)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData data)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSlotsNavigation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIDeckList()
	{
		throw null;
	}
}
