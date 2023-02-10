using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class FarAreaEffect_WhiteNight_Confess : FarAreaEffect
{
	private const int _WHITE_NIGHT_ID = 9090521;

	private FarAreaEffect_WhiteNight_Confess.Timing _timing;

	private float _elapsedStart;

	private float _elapsedGiveDamage;

	private float _elapsedAfterGiveDamage;

	private float _elapsedDone;

	private float _elapsedEnd;

	private WhiteNightMapManager _map;

	public override bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_WhiteNight_Confess()
	{
		throw null;
	}

	public enum Timing
	{
		Start,
		GiveDamage,
		AfterGiveDamage,
		Done,
		End
	}
}
