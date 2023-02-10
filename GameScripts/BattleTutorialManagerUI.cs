using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_BattleUnit_UI;
using UI;
using UnityEngine;

public class BattleTutorialManagerUI : SingletonBehavior<BattleTutorialManagerUI>
{
	[Header("Start Tutorial")]
	public GameObject ob_tutorialFrameSpace;

	[SerializeField]
	private UITutorialAutoAlarmTemplate tutorialTemplate;

	private SpeedDiceUI speeddice;

	public BattleTutorialManagerUI.OnSelectCardTutorial selectCardFuncForTutorial;

	[SerializeField]
	private UITutorialAutoAlarmTemplate tutorialTemplateForSelectCard;

	public BattleTutorialManagerUI.OnSelectEnemyDiceTutorial selectEnemySpeedDiceFuncForTutorial;

	[SerializeField]
	private UITutorialAutoAlarmTemplate tutorialTemplateForAutoBattle;

	public BattleTutorialManagerUI.OnEndTutorial endFuncForTutorial;

	private bool _isRunningTutorial;

	[Header("Creature Tutorial")]
	[SerializeField]
	private UITutorialAutoAlarmTemplate tutorialTemplateForCreaturePassive;

	public BattleTutorialManagerUI.OnSelectEnemyCreatureTutorial onSelectEnemyFuncForCreatureTutorial;

	private bool _isRunningCreatureTutorial;

	public readonly int BloodBathStageID;

	public readonly int BloodBathEnemyID;

	public List<GameObject> ob_Frames;

	public List<GameObject> enemyDiceHighlightObjectList;

	public UITutorialAutoAlarmTemplate DiceInfoTutorialTemplate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public UITutorialAutoAlarmTemplate TutorialTemplateForSelectCard
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsRunningTutorial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool IsRunningCreatureTutorial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForcelyExitStartTutorial()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialSpeedDiceStop()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CloseTutorialFrame(UIAutoTooltipType type)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialBattleStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialSelectCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CreateUnitDiceHighlight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DestroyUnitDiceHighlightFrame()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialSelectEnemyDice()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialAlarmAutoBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTutorialBattleStartButton()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartCreatureTutorial(BattleUnitView target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartPassiveAlarmTutorial()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleTutorialManagerUI()
	{
		throw null;
	}

	[HideInInspector]
	public delegate void OnSelectCardTutorial();

	[HideInInspector]
	public delegate void OnSelectEnemyDiceTutorial();

	[HideInInspector]
	public delegate void OnEndTutorial();

	public delegate void OnSelectEnemyCreatureTutorial();
}
