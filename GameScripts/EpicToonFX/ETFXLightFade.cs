﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EpicToonFX
{
	public class ETFXLightFade : MonoBehaviour
	{
		[Header("Seconds to dim the light")]
		public float life;

		public bool killAfterLife;

		private Light li;

		private float initIntensity;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETFXLightFade()
		{
			throw null;
		}
	}
}
