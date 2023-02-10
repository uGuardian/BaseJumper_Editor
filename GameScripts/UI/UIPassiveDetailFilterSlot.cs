using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIPassiveDetailFilterSlot : MonoBehaviour
	{
		[SerializeField]
		private UICustomSelectableToggle SelectableToggle;

		[HideInInspector]
		public int detailNum;

		private UIPassiveDetailFilterPanel panel;

		public bool IsOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UIPassiveDetailFilterPanel parent, int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleOn(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveDetailFilterSlot()
		{
			throw null;
		}
	}
}
