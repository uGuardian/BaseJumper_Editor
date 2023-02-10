using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StoryScene;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using WorkParser;

public class DialogLogManager : MonoBehaviour
{
	public RectTransform DialogContentRect;

	public CanvasGroup canvasGroup;

	private Font localizedFont;

	public GameObject controllerGuide;

	public GameObject ExitGuide;

	[SerializeField]
	public StoryManager storyManager;

	[Header("Scroll")]
	[SerializeField]
	private UICustomScrollBar scrollBar;

	[SerializeField]
	private float slotWidth;

	[SerializeField]
	private float slotHeight;

	[SerializeField]
	private int row;

	[SerializeField]
	private int column;

	[Header("controller")]
	public UICustomSelectablePanel SelectablePanel;

	[SerializeField]
	private UICustomSelectable UpSelectableObject;

	[SerializeField]
	private UICustomSelectable DownSelectableObject;

	public List<CharacterDialogLogData> dialogDataList;

	private List<CharacterDialogLog> slotList;

	private int curRow;

	private CharacterDialogLog curVoiceLog;

	private UICustomSelectable prevSelectable;

	public bool IsLogOpened
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFont(Font font)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDialogLogButton(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickExitButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnVoice(Dialog d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OffVoice(Dialog d)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Hide()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Show()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateList()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDialog(Dialog _dialog)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddExtraLog(string text, bool isRed)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetMaxRow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeScrollValue()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitScrollBar()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePageButtons()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectUpSelectableObject(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectDownSelectableObject(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectSlot(CharacterDialogLog slot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSlotsNavigation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogLogManager()
	{
		throw null;
	}
}
