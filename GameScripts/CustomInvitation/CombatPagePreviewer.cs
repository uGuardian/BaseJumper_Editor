using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPagePreviewer : MonoBehaviour
	{
		private static CombatPagePreviewer _instance;

		[SerializeField]
		private CombatPageSummary _refSummaryUI;

		[SerializeField]
		private CombatPageEditor _combatPageEditor;

		[SerializeField]
		private LayoutGroup _summaryRoot;

		[SerializeField]
		private GameObject _blockObj;

		[SerializeField]
		private Button _addButton;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private Button _deleteButton;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageSummary> _summaryList;

		[SerializeField]
		private CombatPageSummary _selectedSummary;

		public static CombatPagePreviewer instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadCombatPage()
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
		private void AddCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private CombatPageSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleCombatPageSummary(CombatPageSummary summary)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCombatPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPagePreviewer()
		{
			throw null;
		}
	}
}
