using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DropBookKeyPageListViewer : MonoBehaviour
	{
		[SerializeField]
		private KeyPageSummary _refUI;

		[SerializeField]
		private VerticalLayoutGroup _layout;

		[SerializeField]
		protected ToggleListFilter _toggleFilter;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		private List<KeyPageSummary> _keyPageList;

		private Action<List<BookXmlInfo>> _callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenWindow(Action<List<BookXmlInfo>> callback)
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
		private void DoneKeyPageRewardsSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelKeyPageRewardsSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DropBookKeyPageListViewer()
		{
			throw null;
		}
	}
}
