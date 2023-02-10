using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DropBookCombatPageListViewer : MonoBehaviour
	{
		[SerializeField]
		private CombatPageSummary _refUI;

		[SerializeField]
		private ToggleListFilter _searchFilter;

		[SerializeField]
		private LayoutGroup _combatPageLayout;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		private List<CombatPageSummary> _combatPageSummaryList;

		private Action<List<CombatPageSummary>> _callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenWindow(Action<List<CombatPageSummary>> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneCombatPageRewardsSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelCombatPageRewardsSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookCombatPageListViewer()
		{
			throw null;
		}
	}
}
