using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Elena : FarAreaEffect
{
	[Header("Prefab")]
	[SerializeField]
	private GameObject _castingEffectRes;

	[SerializeField]
	private GameObject _floorEffectRes;

	[SerializeField]
	private GameObject _damagedEffectRes;

	[Header("Sound")]
	[SerializeField]
	private AudioClip _castingSound;

	[SerializeField]
	private AudioClip _floorSound;

	[SerializeField]
	private AudioClip _damageSound;

	[Header("Scale Factor")]
	[SerializeField]
	private float _castingEffectScaleFactor;

	[SerializeField]
	private float _floorEffectScaleFactor;

	[SerializeField]
	private float _damagedEffectScaleFactor;

	[Header("Delay")]
	[SerializeField]
	private float _castingDelay;

	[SerializeField]
	private float _floorDelay;

	[SerializeField]
	private float _endDelay;

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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override bool ActionPhase(float deltaTime, BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims, ref List<BattleFarAreaPlayManager.VictimInfo> defenseVictims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamage(BattleUnitModel attacker, BattleFarAreaPlayManager.VictimInfo v)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitFloorEffect(BattleUnitModel attacker, List<BattleFarAreaPlayManager.VictimInfo> victims)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Elena()
	{
		throw null;
	}
}
