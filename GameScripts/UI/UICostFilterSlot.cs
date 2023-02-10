using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICostFilterSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UICostFilterPanel panel;

		[SerializeField]
		private UICustomSelectableToggle SelectableToggle;

		public int cost;

		private RectTransform rect;

		public bool IsOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParentSelectable(UICustomSelectable parent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleOn(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICostFilterSlot()
		{
			throw null;
		}
	}
}
