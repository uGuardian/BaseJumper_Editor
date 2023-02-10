using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UICustomTabsController : MonoBehaviour
	{
		public GameObject TabsRoot;

		public UICustomTabButton[] CustomTabs;

		public UICustomTabPanel[] CustomPanels;

		private int currentIndex;

		public UnityEvent OnTabChanged;

		[Header("xbox")]
		public UnityEvent XEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectTab(int _index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCurrentIndex()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateTabs(bool activate)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomTabsController()
		{
			throw null;
		}
	}
}
