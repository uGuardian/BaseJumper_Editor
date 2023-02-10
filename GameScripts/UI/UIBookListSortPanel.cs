using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UIBookListSortPanel : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private UICustomTabsController bookListFilterTabsController;

		[SerializeField]
		private UnityEvent onChangeFilter;

		[Header("controller")]
		public UICustomSelectable ParentSelectablePanel;

		[SerializeField]
		private UnityEvent XEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookFilterState CheckBookListFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBookListSortPanel()
		{
			throw null;
		}
	}
}
