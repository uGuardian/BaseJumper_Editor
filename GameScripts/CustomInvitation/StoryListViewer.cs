using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using StoryScene;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StoryListViewer : MonoBehaviour
	{
		[SerializeField]
		private StoryRoot _storyRoot;

		[SerializeField]
		private StorySummary _storyBtnRef;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private Button _createButton;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private GameObject _createStoryPopup;

		[SerializeField]
		private Text _createStoryPopupMessageText;

		[SerializeField]
		private Button _doneBtnCreatingStory;

		[SerializeField]
		private Button _cancelBtnCreatingStory;

		[SerializeField]
		private InputField _inputStoryFileName;

		private List<StorySummary> _storyList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenStoryViewer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitUI()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitStoryFile()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneCreatingStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelCreatingStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseStoryEditor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenStory(string storyPath, string effectPath)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EndStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryListViewer()
		{
			throw null;
		}
	}
}
