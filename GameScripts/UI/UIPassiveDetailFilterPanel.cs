using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UIPassiveDetailFilterPanel : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private UISearchFilterPanel bookSearchFilter;

		[SerializeField]
		private UISearchFilterPanel passiveSearchFilter;

		[SerializeField]
		private UICostFilterPanel costFilterPanel;

		[SerializeField]
		private List<UIPassiveDetailFilterSlot> detailSlots;

		[SerializeField]
		private Animator anim;

		[Header("events")]
		[SerializeField]
		private UnityEvent onChangeFilterEvent;

		[SerializeField]
		private UnityEvent onXEvent;

		[Header("Controller")]
		public UICustomSelectablePanel selectablePanel;

		private PassiveDetailFilterData detailFilterData;

		private bool _isValid;

		private bool _isOpened;

		public bool isValid
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool isOpened
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
		public void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDetailFilterData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetDetailFilterData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateFilterSlots()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> CheckCardCostFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<string> CheckKeywordFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CheckPassiveSearchKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string CheckBookSearchKey()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickResetButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveDetailFilterPanel()
		{
			throw null;
		}
	}
}
