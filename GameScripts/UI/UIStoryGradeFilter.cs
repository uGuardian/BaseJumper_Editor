using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UIStoryGradeFilter : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private List<UIStoryGradeFilterSlot> gradeSlots;

		[SerializeField]
		private UnityEvent onChangeFilter;

		[Header("controller")]
		public UICustomSelectable FirstSelectable;

		public UICustomSelectable ParentSelectablePanel;

		[SerializeField]
		private UnityEvent XEvent;

		private UIStoryGradeFilterSlot currentSlot;

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
		public void OnChangeFilter(UIStoryGradeFilterSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<Grade> GetStoryGradeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIStoryGradeFilter()
		{
			throw null;
		}
	}
}
