using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_TwistedArgalia_Music : FarAreaEffect
{
	[SerializeField]
	private GameObject _backgroundEffectRes;

	[SerializeField]
	private GameObject _damagedEffectRes;

	[SerializeField]
	private UIAnimationEventHandler _handler;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private float _activateBgEffectDelay;

	[SerializeField]
	private AudioClip _startSound;

	[SerializeField]
	private AudioClip _paperStartSound;

	[SerializeField]
	private AudioClip _paperExplosionSound;

	[SerializeField]
	private GameObject _musicEffect;

	[SerializeField]
	private UIAnimationEventHandler _foregroundHandler;

	private float _elapsed;

	private GameObject _bgEffect;

	private string _defaultCharacterLayerName;

	private string _defaultCharacterUILayerName;

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
	private void GiveDamage(BattleUnitModel attacker, BattleFarAreaPlayManager.VictimInfo v)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void PrintDamagedEffect(BattleUnitView view)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnChangeLayer()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_TwistedArgalia_Music()
	{
		throw null;
	}
}
