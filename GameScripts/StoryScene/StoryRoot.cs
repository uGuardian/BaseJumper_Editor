using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StoryScene
{
	public class StoryRoot : MonoBehaviour
	{
		private static StoryRoot _instance;

		public Camera storyCamera;

		public GameObject storyUI;

		public StoryManager storyManager;

		public StoryEditor storyEditor;

		public bool inGame;

		private StoryRoot.OnEndStoryFunc _onEndStoryFunc;

		public static StoryRoot Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenStory(StoryRoot.OnEndStoryFunc endFunc, bool justreadstory = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndStory(bool forcely = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnLeftMenuEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryRoot()
		{
			throw null;
		}

		public delegate void OnEndStoryFunc();
	}
}
