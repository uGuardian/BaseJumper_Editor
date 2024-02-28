using System;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;
using UnityEngine;

public class BattleManagerUI : SingletonBehavior<BattleManagerUI>
{
	public BattleUnitInformationUI ui_unitInformation;

	public BattleUnitInformationUI ui_unitInformationPlayer;

	public BattleUnitCardsInHandUI ui_unitCardsInHand;

	public BattleEmotionInfoManagerUI ui_emotionInfoBar;

	public BattleUnitInfoManagerUI ui_unitListInfoSummary;

	public BattleUnitTargetArrowManagerUI ui_TargetArrow;

	public LevelUpUI ui_levelup;

	public BattleEmotionCoinUI ui_battleEmotionCoinUI;

	public BattleStoryUI ui_battleStory;

	public Color negativeCoinColor;

	public Color positiveCoinColor;

	public Color negativeTextColor;

	public Color positiveTextColor;

	public Transform EffectLayer;

	public bool isEndBattle;

	private SpeedDiceUI _selectedAllyDice;

	private SpeedDiceUI _selectedEnemyDice;

	public SpeedDiceUI focusedDice;

	protected BattleManagerUI()
	{
	}

	public SpeedDiceUI selectedAllyDice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	public SpeedDiceUI selectedEnemyDice
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnEndBattle()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ClearEffects()
	{

	}
}
