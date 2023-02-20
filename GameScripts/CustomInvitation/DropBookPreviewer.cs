using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DropBookPreviewer : MonoBehaviour
	{
		private static DropBookPreviewer _instance;

		[SerializeField]
		private DropBookSummary _refSummaryUI;

		[SerializeField]
		private DropBookEditor _dropBookEditor;

		[SerializeField]
		private LayoutGroup _summaryRootLayout;

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
		private List<DropBookSummary> _summaryList;

		[SerializeField]
		private DropBookSummary _selectedSummary;

		public static DropBookPreviewer instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadDropBookInfo()
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
		private void AddDropBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditDropBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteDropBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private DropBookSummary CreateSummaryUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleDropBookSummary(DropBookSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDropBook()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookPreviewer()
		{
			throw null;
		}
	}
}
