﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace BattleCharacterProfile
{
	public class EmotionBar : MonoBehaviour
	{
		[SerializeField]
		private int level;

		[SerializeField]
		private List<EmotionCoin> emotionCoins;

		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_Bg;

		private BattleUnitModel _unitModel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitModel(BattleUnitModel unitModel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EmotionBar()
		{
			throw null;
		}
	}
}
