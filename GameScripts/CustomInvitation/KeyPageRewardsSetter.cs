using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageRewardsSetter : MonoBehaviour
	{
		[SerializeField]
		private KeyPageSummary _refUI;

		[SerializeField]
		private DropBookKeyPageListViewer _keyPageListViewer;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private LayoutGroup _layout;

		[Header("Runtime")]
		[SerializeField]
		private List<KeyPageSummary> _rewardList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<BookDropItemInfo> GetDropKeyPageList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEditing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<BookDropItemInfo> keyPageDropList)
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
		private void EditKeyPageRewards()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetRewards(List<BookXmlInfo> keyPageList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageRewardsSetter()
		{
			throw null;
		}
	}
}
