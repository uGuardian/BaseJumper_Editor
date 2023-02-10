using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UICardListFilter : MonoBehaviour
	{
		[SerializeField]
		private UICostFilterPanel costFilterPanel;

		[SerializeField]
		private UISearchFilterPanel SearchFilterPanel;

		public UICustomGraphicObject DetailButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private UnityEvent onChangeFilter;

		[Header("controller")]
		public UICustomSelectable ParentSelectablePanel;

		[SerializeField]
		private UnityEvent XEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDetailFilterIsActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> CheckCardCostFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CheckSearchKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListDetailFilterPopup GetDetailFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetailButtonHighlighted()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetailButtonDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDetailButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListFilter()
		{
			throw null;
		}
	}
}
