using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPagePreviewer : MonoBehaviour
	{
		[SerializeField]
		private KeyPageSummary _refSummaryUI;

		[SerializeField]
		private bool _isEnemyKeyPages;

		[SerializeField]
		private KeyPageEditor _keyPageEditor;

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
		private List<KeyPageSummary> _summaryList;

		[SerializeField]
		private KeyPageSummary _selectedSummary;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadKeyPage()
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
		private void AddKeyPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditKeyPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteKeyPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private KeyPageSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleKeyPageSummary(KeyPageSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetKeyPage()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPagePreviewer()
		{
			throw null;
		}
	}
}
