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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddCombatPageToEnemyDeck()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneAddingCombatPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageCombatPageListViewer()
		{
			throw null;
		}
	}
}
