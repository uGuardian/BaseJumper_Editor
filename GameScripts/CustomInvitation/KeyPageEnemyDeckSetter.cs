using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageEnemyDeckSetter : MonoBehaviour
	{
		[SerializeField]
		private CombatPageSummary _refUI;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private KeyPageCombatPageListViewer _combatPageListViewer;

		[SerializeField]
		private Text _curDeckCountText;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private Button _deleteButton;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageSummary> _equipList;

		[SerializeField]
		private List<CombatPageSummary> _selectedList;

		private BookXmlInfo _curEnemyKeyPage;

		private const int _MAX_DECK_COUNT = 9;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(BookXmlInfo enemyKeyPageInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> GetEnemyDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEmpty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditEnemyDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteSelectedCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDeck(List<CombatPageSummary> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleCombatPageSummary(CombatPageSummary summary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageEnemyDeckSetter()
		{
			throw null;
		}
	}
}
