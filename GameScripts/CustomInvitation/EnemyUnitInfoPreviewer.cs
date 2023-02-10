using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class EnemyUnitInfoPreviewer : MonoBehaviour
	{
		[SerializeField]
		private EnemyUnitInfoSummary _refSummaryUI;

		[SerializeField]
		private EnemyUnitEditor _enemyUnitEditor;

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
		private List<EnemyUnitInfoSummary> _summaryList;

		[SerializeField]
		private EnemyUnitInfoSummary _selectedSummary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadEnemyUnitInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void AddEnemyUnit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditEnemyUnit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteEnemyUnit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private EnemyUnitInfoSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleSummary(EnemyUnitInfoSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEnemyUnit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitInfoPreviewer()
		{
			throw null;
		}
	}
}
