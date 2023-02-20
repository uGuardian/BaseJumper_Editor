using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_Galaxy_FarewellAtk : FarAreaEffect
{
	[SerializeField]
	private FarAreaEffect_EGO_Galaxy_Farewell_DamagedEffect _damagedEffectPrefab;

	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private float _waitStartTime;

	[SerializeField]
	private float _waitEndTime;

	private float _elapsedStart;

	private float _elapsedEnd;

	private List<FarAreaEffect_EGO_Galaxy_Farewell_DamagedEffect> _damagedEffectList;

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
	public FarAreaEffect_EGO_Galaxy_FarewellAtk()
	{
		throw null;
	}
}
