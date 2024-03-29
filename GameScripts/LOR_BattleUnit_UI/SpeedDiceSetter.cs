﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;
using UnityEngine.UI;

namespace LOR_BattleUnit_UI
{
	public class SpeedDiceSetter : MonoBehaviour
	{
		[Header("Reference Resources")]
		[SerializeField]
		private SpeedDiceUI refSpeedDiceUI;

		[SerializeField]
		private Color color_allyDice;

		[SerializeField]
		private Color color_allydiceLine;

		[SerializeField]
		private Material mat_allyDiceLineGlow;

		[SerializeField]
		private Color color_enemyDice;

		[SerializeField]
		private Color color_enemydiceLine;

		[SerializeField]
		private Material mat_enemyDiceLineGlow;

		[SerializeField]
		private Color color_clickedSlot;

		[SerializeField]
		private Color color_clickedLine;

		[SerializeField]
		private Color color_BreakSlot;

		[SerializeField]
		private Color color_BreakLine;

		[Header("Reference Objects")]
		[SerializeField]
		private BattleUnitView _view;

		[SerializeField]
		private GraphicRaycaster _canvasRayCaster;

		[SerializeField]
		private RectTransform _switchTargetRoot;

		[Header("ControllerGuide")]
		[SerializeField]
		private CanvasGroup GuideRootCG;

		[SerializeField]
		private RectTransform GuideBGRect;

		[SerializeField]
		private GameObject Guide_selectbattlepage;

		[SerializeField]
		private GameObject Guide_cancelbattlepage;

		[SerializeField]
		private GameObject Guide_unitinfo;

		[SerializeField]
		private GameObject Guide_selectTarget;

		private List<SpeedDiceUI> _speedDices;

		private int _actiavedSpeedDicesCount;

		private bool _isEnabled;

		private int switchingIdx;

		public int SpeedDicesCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color ClickedColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color clickedLineColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color AllyDiceColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color EnemyDiceColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeedDiceUI GetSpeedDiceByIndex(int order)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpeedDicesAfterRoll(List<SpeedDice> diceResult)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSpeedDicesBeforeRoll(List<SpeedDice> diceInfo, Faction faction)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetNavigations()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivatedCharacters(List<BattleUnitModel> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSelection()
		{
			
		}

		public bool IsEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlockDiceAll(bool active, bool forcely = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BreakDiceAll(bool active)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectAll()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnableSwitchTargetButton(bool b, int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSwitchTargetButton(bool isController)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetControllerGuide(SpeedDiceSetter.DiceGuidePhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpeedDiceSetter()
		{
			throw null;
		}

		public enum DiceGuidePhase
		{
			None,
			SelectEmpty,
			SelectEquiped,
			InfoOnly,
			Targeting,
			SelectOnly
		}
	}
}
