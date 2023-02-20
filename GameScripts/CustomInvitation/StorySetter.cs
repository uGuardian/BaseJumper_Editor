using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StorySetter : MonoBehaviour
	{
		public const string NO_STORY = "__No Story__";

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private StoryFileSummary _refStory;

		[SerializeField]
		private ToggleListFilter _searchFilter;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		private List<StoryFileSummary> _storyList;

		private Action<string> _callback;

		private StoryFileSummary _selectedStory;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEditing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenStorySettingPopup(string story, Action<string> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitStoryList(string storySelectedBefore)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectStoryFile(StoryFileSummary selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Activate(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneStorySetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelStorySetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StorySetter()
		{
			throw null;
		}
	}
}
