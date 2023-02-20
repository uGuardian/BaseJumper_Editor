using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIModPopup : UIPopup
	{
		[Header("Mod Info")]
		[SerializeField]
		private Text _nameText;

		[SerializeField]
		private Text _makerText;

		[SerializeField]
		private Text _infoText;

		[SerializeField]
		private Image _previewImage;

		[Header("Scroll")]
		public RectTransform contentRect;

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

		private List<ModSlotData> dataList;

		private List<UIModSlot> slotList;

		private int curRow;

		private Action closeCallback;

		private ModSlotData selectedData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInEntryScene(Action callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(List<ModSlotData> data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateList()
		{
			
		}

		public ModSlotData SelectedData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlot(ModSlotData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeModSetting(ModSlotData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetInfo(ModSlotData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
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
		public void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIModPopup()
		{
			throw null;
		}
	}
}
