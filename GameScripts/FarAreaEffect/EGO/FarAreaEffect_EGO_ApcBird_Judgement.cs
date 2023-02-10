using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ApcBird_Judgement : FarAreaEffect
{
	[SerializeField]
	private GameObject _judgementStartRes;

	[SerializeField]
	private GameObject _judgementEndRes;

	[SerializeField]
	private float _effectScaleFactor;

	[SerializeField]
	private float _startDelay;

	[SerializeField]
	private float _endDelay;

	private List<FarAreaEffect_EGO_ApcBird_Judgement.DamagedEffectInfo> _startEffectInfoList;

	private float _elapsedStart;

	private float _elapsedEnd;

	private float _elapsedPredelay;

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
	public FarAreaEffect_EGO_ApcBird_Judgement()
	{
		throw null;
	}

	public class DamagedEffectInfo
	{
		public GameObject startEffectObj;

		public BattleFarAreaPlayManager.VictimInfo victim;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DamagedEffectInfo()
		{
			throw null;
		}
	}
}
