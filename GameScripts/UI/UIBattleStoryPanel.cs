﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIBattleStoryPanel : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup canvasGroup;

		public UIStoryProgressPanel progressPanel;

		public UIBattleStoryInfoPanel storyInfoPanel;

		private UIStoryProgressIconSlot currentSlot;

		private int currentIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectedStory(UIStoryProgressIconSlot slot, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleStoryPanel()
		{
			throw null;
		}
	}
}
