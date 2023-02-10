using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	[RequireComponent(typeof(Animator))]
	public class UIAnimationEventHandler : MonoBehaviour
	{
		private Dictionary<string, UIAnimationEventHandler.EventMethod> events;

		public Animator Anim
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddEvent(string key, UIAnimationEventHandler.EventMethod method)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveEvent(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCalled(string key)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAnimationEventHandler()
		{
			throw null;
		}

		public delegate void EventMethod();
	}
}
