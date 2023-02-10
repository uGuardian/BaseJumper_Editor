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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitScriptLists()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectSlot(UICustomizeScriptSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnteredSlot(UICustomizeScriptSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartEditDialog()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndEditDialog()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void setInpuFieldHighlight(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeScriptPanel()
		{
			throw null;
		}
	}
}
