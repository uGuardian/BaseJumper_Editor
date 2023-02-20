using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIMainTree : SingletonBehavior<UIMainTree>
	{
		public SpriteRenderer sprite_defaultbg;

		public GameObject ob_blueEffectBg;

		public GameObject[] ob_blueImage;

		public SpriteRenderer sprite_citynight;

		public Animator zoomAnim;

		public GameObject ob_BlackBg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnEnableZoomAnim(string trigger)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffEnableZoomAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveBlueEffect(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveCityNight(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainTree()
		{
			throw null;
		}
	}
}
