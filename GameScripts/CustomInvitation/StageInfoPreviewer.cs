using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StageInfoPreviewer : MonoBehaviour
	{
		[SerializeField]
		private StageInfoSummary _refSummaryUI;

		[SerializeField]
		private StageInfoEditor _stageInfoEditor;

		[SerializeField]
		private Transform _summaryRoot;

		[SerializeField]
		private GameObject blockObj;

		[SerializeField]
		private Button _addButton;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private Button _deleteButton;

		[Header("Runtime")]
		[SerializeField]
		private List<StageInfoSummary> _summaryList;

		[SerializeField]
		private StageInfoSummary _selectedSummary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadStageInfo()
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
		private void AddStageInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditStageInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteStageInfo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetStageSummary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private StageInfoSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleStageSummary(StageInfoSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageInfoPreviewer()
		{
			throw null;
		}
	}
}
