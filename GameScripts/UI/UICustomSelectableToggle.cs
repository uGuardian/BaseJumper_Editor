using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
	public class UICustomSelectableToggle : MonoBehaviour
	{
		[Header("Reference")]
		public UICustomGraphicObject CustomGraphicObject;

		public GameObject HighlightObject;

		public UICustomSelectable Selectable;

		public bool IsOn;

		public UnityEventBasedata OnClickEvent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitToggle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIsOn(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelected(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeselected(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomSelectableToggle()
		{
			throw null;
		}
	}
}
