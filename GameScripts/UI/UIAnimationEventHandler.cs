using System;
using System.Collections.Generic;
using UnityEngine;

namespace UI
{
	[RequireComponent(typeof(Animator))]
	public class UIAnimationEventHandler : MonoBehaviour
	{
		private Dictionary<string, UIAnimationEventHandler.EventMethod> events = new Dictionary<string, UIAnimationEventHandler.EventMethod>();

		public Animator Anim
		{
			get
			{
				return base.gameObject.GetComponent<Animator>();
			}
		}

		public void AddEvent(string key, UIAnimationEventHandler.EventMethod method)
		{
			if (this.events.ContainsKey(key))
			{
				this.events[key] = method;
				return;
			}
			this.events.Add(key, method);
		}

		public void RemoveEvent(string key)
		{
			if (this.events.ContainsKey(key))
			{
				this.events.Remove(key);
			}
		}

		public void OnCalled(string key)
		{
			UIAnimationEventHandler.EventMethod eventMethod;
			if (this.events.TryGetValue(key, out eventMethod))
			{
				eventMethod();
			}
		}

		public delegate void EventMethod();
	}
}
