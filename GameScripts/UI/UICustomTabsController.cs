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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectTab(int _index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateState()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetCurrentIndex()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateTabs(bool activate)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomTabsController()
		{
			throw null;
		}
	}
}
