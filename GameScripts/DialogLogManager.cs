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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetFont(Font font)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickDialogLogButton(BaseEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickExitButton()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnVoice(Dialog d)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OffVoice(Dialog d)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Hide()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Show()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateList()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddDialog(Dialog _dialog)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddExtraLog(string text, bool isRed)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetMaxRow()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnChangeScrollValue()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnExitScrollBar()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdatePageButtons()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectUpSelectableObject(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectDownSelectableObject(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnSelectSlot(CharacterDialogLog slot)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSlotsNavigation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DialogLogManager()
	{
		throw null;
	}
}
