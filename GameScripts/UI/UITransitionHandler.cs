using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[RequireComponent(typeof(Animator))]
	public class UITransitionHandler : MonoBehaviour
	{
		public UITransitionHandler.TransitionEvent StartEvent;

		public UITransitionHandler.TransitionEvent EndEvent;

		private Animator _anim;

		private UITransitionHandler.AnimationState _currentAnimationState;

		public Animator Anim
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStartEvent(UITransitionHandler.TransitionEvent @event)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEndEvent(UITransitionHandler.TransitionEvent @event)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveStartEevent(UITransitionHandler.TransitionEvent @event)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveEndEvent(UITransitionHandler.TransitionEvent @event)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartTransition(UITransitionHandler.AnimationTrigger triggerType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartTransition()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndTransition()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITransitionHandler()
		{
			throw null;
		}

		public enum AnimationState
		{
			Open,
			Close,
			Enabled,
			Disabled
		}

		public enum AnimationTrigger
		{
			Open,
			Closed
		}

		public delegate void TransitionEvent();
	}
}
