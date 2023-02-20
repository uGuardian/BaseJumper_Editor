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
		private void InitStoryFile()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneCreatingStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelCreatingStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseStoryEditor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenStory(string storyPath, string effectPath)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EndStory()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryListViewer()
		{
			throw null;
		}
	}
}
