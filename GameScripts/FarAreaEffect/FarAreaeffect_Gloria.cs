using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaeffect_Gloria : FarAreaEffect
{
	private static int _motionCount;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private List<FarAreaeffect_Gloria.ChainEffectInfo> _victimeLoserList;

	private FarAreaeffect_Gloria.GloriaPhase _phase;

	private float _elapedTime;

	private float _elapsedEndAtk;

	private float _elapsedAtkOneTarget;

	private GameObject _trailObject;

	private int _sign;

	private Vector3 _srcPosAtkOneTarget;

	private Vector3 _dstPosAtkOneTarget;

	private Coroutine _coroutine;

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
	private IEnumerator MotionChanger(BattleUnitModel attacker)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPositionWithCheckWall(BattleUnitModel unit, Vector3 pos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaeffect_Gloria()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FarAreaeffect_Gloria()
	{
		throw null;
	}

	public enum GloriaPhase
	{
		ChainAttack,
		ChainAttackWait,
		ChainPull,
		ChainEat,
		ChainSpit
	}

	public class ChainEffectInfo
	{
		public BattleFarAreaPlayManager.VictimInfo victim;

		public Vector3 originPos;

		public Vector3 originChainPos;

		public LinePatternRenderer chainRenderer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChainEffectInfo()
		{
			throw null;
		}
	}
}
