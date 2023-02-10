using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageCombatPageListViewer : MonoBehaviour
	{
		[SerializeField]
		private CombatPageSummary _refUI;

		[SerializeField]
		private ToggleListFilter _searchFilter;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private Button _addButton;

		[SerializeField]
		private Button _doneButton;

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
		private void AddCombatPageToEnemyDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneAddingCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageCombatPageListViewer()
		{
			throw null;
		}
	}
}
