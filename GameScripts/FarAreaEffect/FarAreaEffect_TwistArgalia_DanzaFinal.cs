using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_TwistArgalia_DanzaFinal : FarAreaEffect
{
	[SerializeField]
	private GameObject _slashEffect;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private GameObject _damagedEffectRes;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private AudioClip _lastSound;

	private float _elapsed;

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
	private void OnStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnLastCutEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnBackgroundOff()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamageToVictims(BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamage(BattleUnitModel attacker, BattleFarAreaPlayManager.VictimInfo v)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisableBgEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyLineEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamagedEffect(BattleUnitView view)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TwistArgalia_DanzaFinal()
	{
		throw null;
	}
}
