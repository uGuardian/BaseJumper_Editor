using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleFarAreaPlayManager : Singleton<BattleFarAreaPlayManager>
{
	public BattleUnitModel attacker;

	public ActionDetail attackerMotionBeforePlay;

	private BattleUnitView.SkinInfo _originalAttackerSkin;

	public List<BattleFarAreaPlayManager.VictimInfo> victims;

	public List<BattleFarAreaPlayManager.VictimInfo> defenseVictims;

	public bool isRunning;

	private BattleFarAreaPlayManager.Phase _phase;

	private FarAreaEffect _attackerEffect;

	private float _elapsed;

	private float _elapsedPrintRolledDiceUI;

	private float _elapsedActionDelay;

	private float _actionPreDelay;

	private float _actionPostDelay;

	private float _uiDelay;

	private float _rollDicePhaseDelay;

	private float _printRollDicePhaseDelay;

	private float _endDelay;

	private float _elapsedEndDelay;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActionDelay(float preDelay = 1f, float postDelay = 0.5f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUIDelay(float uiDelay = 0.5f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRollDiceDelay(float rollDicePhaseDelay = 0.2f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPrintRollDiceDelay(float printRollDicePhaseDelay = 0.3f)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartFarAreaPlay(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FixedUpdate(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RollDicePhase(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RollVictimsDice(BattleFarAreaPlayManager.VictimInfo v, CardRange range)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool PrintRolledDiceUI(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EffectPhase(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ActionPhase(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EndFarAreaPlay(float deltaTime)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleFarAreaPlayManager()
	{
		throw null;
	}

	public enum Phase
	{
		None,
		RollDice,
		Effect,
		Action,
		End
	}

	public class VictimInfo
	{
		public BattleUnitModel unitModel;

		public BattlePlayingCardDataInUnitModel playingCard;

		public ActionDetail motionBeforePlay;

		public List<int> destroyedDicesIndex;

		public bool cardDestroyed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public VictimInfo()
		{
			throw null;
		}
	}
}
