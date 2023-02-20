using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class PassiveInfoPreviewer : MonoBehaviour
	{
		private static PassiveInfoPreviewer _instance;

		[SerializeField]
		private PassiveSummary _refSummaryUI;

		[SerializeField]
		private PassiveEditor _passiveEditor;

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
		private List<PassiveSummary> _summaryList;

		[SerializeField]
		private PassiveSummary _selectedSummary;

		public static PassiveInfoPreviewer instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadPassiveList()
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
		private void AddPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeletePassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPassive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private PassiveSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void TogglePassiveSummary(PassiveSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveInfoPreviewer()
		{
			throw null;
		}
	}
}
