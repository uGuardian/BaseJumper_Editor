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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDetailFilterIsActive()
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetailButtonHighlighted()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDetailButtonDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDetailButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICardListFilter()
		{
			throw null;
		}
	}
}
