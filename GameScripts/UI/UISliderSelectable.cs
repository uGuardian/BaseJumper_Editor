using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISliderSelectable : Slider
	{
		[Header("STEP")]
		[Range(0f, 1f)]
		public float step;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnMove(AxisEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISliderSelectable()
		{
			throw null;
		}
	}
}
