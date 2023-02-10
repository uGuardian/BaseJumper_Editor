using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyTeamStageManager_FinalFinal : EnemyTeamStageManager
{
	public const string geburahEnterEffect = "Battle/FinalEpisode/FinalEpisode_GeburahEnter";

	public const string bindingEffect = "Battle/FinalEpisode/FinalEpisode_Binding";

	public const string binahEnterEffect = "Battle/FinalEpisode/FinalEpisode_BinahEnter";

	public const string finalEarthquakeEffect = "Battle/FinalEpisode/FinalEpisode_FinalEarthquakeEffect";

	public const string finalEndEffect = "Battle/FinalEpisode/FinalEpisode_FinalEnd";

	public const string loseEffect = "Battle/FinalEpisode/FinalEpisode_Lose";

	private EnemyTeamStageManager_FinalFinal.FinalPhase _currentPhase;

	private int _turnCount;

	private int _geburahTurnCount;

	private int _finalTurnCount;

	private FinalEpisode_FinalEarthquakeEffect _finalEarthquakeEffect;

	private List<MonoBehaviour> _effectList;

	private int rolandId;

	private int geburahId;

	private int binahId;

	private int arbiterId;

	private int clawId;

	public EnemyTeamStageManager_FinalFinal.FinalPhase CurrentPhase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int TurnCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int GeburahTurnCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int FinalTurnCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEndTheLast()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool CanExitRoundEndPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EnterGeburah()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateGeburah()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayGeburahEnterEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayGeburahEnterStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayGeburahEnterStory2()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayBindingEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateBinah()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayBinahEnterStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayBinahEnterEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayBinahStory2()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayEndBattleStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PlayEndBattleEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndBattle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GameOver()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckEnterGeburahPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckBindingPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckEnterBinahPhase()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckBattleEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool CheckLose()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_GeburahEnter CreateGeburahEnterEffect(Action callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_Binding CreateBindingEffect(Action callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_BinahEnter CreateBinahEnterEffect(Action callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_FinalEarthquakeEffect CreateFinalEarthquakeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_FinalEnd CreateFinalEndEffect(Action callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FinalEpisode_Lose CreateLoseEffect(Action callback)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetArbiterUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetClawUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetRolandUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetGeburahUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitModel GetBinahUnit()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyTeamStageManager_FinalFinal()
	{
		throw null;
	}

	public enum FinalPhase
	{
		RolandOnly,
		GeburahEnterStory1,
		GeburahEnterEffect,
		GeburahEnterStory2,
		GeburahEnterBattle,
		Binding,
		BinahEnterStory1,
		BinahEnterEffect,
		BinahEnterStory2,
		BinahEnterBattle,
		FinalEndStory,
		FinalEndEffect,
		TheEnd,
		Lose
	}

	private class RealStat : PassiveAbilityBase
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnWaveStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RealStat()
		{
			throw null;
		}
	}
}
