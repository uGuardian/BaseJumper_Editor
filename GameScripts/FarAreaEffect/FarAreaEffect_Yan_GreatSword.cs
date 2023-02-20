using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class FarAreaEffect_Yan_GreatSword : FarAreaEffect
{
	[SerializeField]
	private UIAnimationEventHandler _animHandler;

	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private AudioClip _castingSound;

	[HideInInspector]
	private AudioClip _castingDoneSound;

	[SerializeField]
	private AudioClip _damageSound;

	[SerializeField]
	private float _castingTime;

	[SerializeField]
	private Vector3 _effectPos;

	private float _elapsedCasting;

	private FarAreaEffect_Yan_GreatSword.State _state;

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
	public void OnDamageEvent()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
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
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Yan_GreatSword()
	{
		throw null;
	}

	public enum State
	{
		Casting,
		Shoot,
		Damage
	}
}
