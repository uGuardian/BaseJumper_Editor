using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaeffect_EGO_Helper_Charge : FarAreaEffect
{
	private const string _TRAIL_PREFAB_PATH = "Battle/CreatureEffect/FinalBattle/EGO_Helper_SpecialAtkTrail";

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private float _elapsedEndAtk;

	private float _elapsedAtkOneTarget;

	private GameObject _trailObject;

	private int _sign;

	private Vector3 _srcPosAtkOneTarget;

	private Vector3 _dstPosAtkOneTarget;

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
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaeffect_EGO_Helper_Charge()
	{
		throw null;
	}
}
