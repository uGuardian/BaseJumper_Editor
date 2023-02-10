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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnEnableZoomAnim(string trigger)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffEnableZoomAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveBlueEffect(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveCityNight(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainTree()
		{
			throw null;
		}
	}
}
