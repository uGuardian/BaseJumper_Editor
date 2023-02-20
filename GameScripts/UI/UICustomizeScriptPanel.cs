using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICustomizeScriptPanel : UICustomPanel
	{
		[Header("InputField")]
		[SerializeField]
		private TMP_InputField inputField;

		[SerializeField]
		private GraphicBundle inputFieldGraphics;

		[Header("Slots")]
		public UICustomSelectable listSelectable;

		[SerializeField]
		private UICustomizeScriptSlot model;

		[SerializeField]
		private GameObject slotParent;

		[SerializeField]
		private UIScrollbarController scrollBar;

		[HideInInspector]
		public UICustomizeScriptSlot currentSelectedSlot;

		private int currentDialogType;

		private List<UICustomizeScriptSlot> slotData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(UICustomizePopup parent)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitScriptLists()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectSlot(UICustomizeScriptSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnteredSlot(UICustomizeScriptSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartEditDialog()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndEditDialog()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void setInpuFieldHighlight(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeScriptPanel()
		{
			throw null;
		}
	}
}
