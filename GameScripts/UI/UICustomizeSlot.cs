using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICustomizeSlot : MonoBehaviour
	{
		public TextMeshProUGUI text;

		public GameObject highlight;

		public GameObject glow;

		public UICustomSelectable selectable;

		private bool isActive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlight(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetGlow(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Activate(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeSlot()
		{
			throw null;
		}
	}
}
