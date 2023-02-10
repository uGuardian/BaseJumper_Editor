using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIBgScreenChangeAnim : SingletonBehavior<UIBgScreenChangeAnim>
	{
		[SerializeField]
		public Animator anim;

		[SerializeField]
		private AudioSource revealaudio;

		private UIPhase EnterPhase;

		[SerializeField]
		private UICustomSelectable DummySelectable;

		[SerializeField]
		private Canvas canvas;

		private UIScreenChangeType changeType;

		private UICustomSelectable prevSelectable;

		public bool isStartReturnTitle;

		public bool endAnim;

		[SerializeField]
		private GameObject ob_blockimage;

		private UIBgScreenChangeAnim.StoryFunc _storyFunc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBg(UIScreenChangeType cType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeVisual()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStoryFunc(UIBgScreenChangeAnim.StoryFunc func)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBgScreenChangeAnim()
		{
			throw null;
		}

		public delegate void StoryFunc();
	}
}
