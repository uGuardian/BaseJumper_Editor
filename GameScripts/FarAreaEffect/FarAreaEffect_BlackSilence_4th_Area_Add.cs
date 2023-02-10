using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_BlackSilence_4th_Area_Add : FarAreaEffect
{
	private float _endDelay;

	private float _moveSpeed;

	private float _atkDelay;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private float _elapsedStart;

	private float _elapsedGiveDamage;

	private float _elapsedEndAction;

	private Vector3 _srcPosAtkOneTarget;

	private Vector3 _dstPosAtkOneTarget;

	private Vector3 _offset_Start;

	private Vector3 _offset_End;

	private BattleFarAreaPlayManager.VictimInfo _currentVictim;

	private BlackSilence4thMapManager _map;

	public override bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private BlackSilence4thMapManager Map
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
	private ActionDetail GetActionDetail()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetEffectSrc(ActionDetail act)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_BlackSilence_4th_Area_Add()
	{
		throw null;
	}
}
