using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_EGO_ApcBird_Laser : FarAreaEffect
{
	[SerializeField]
	private ApocalypseBirdObjectController _birdObject;

	[SerializeField]
	private FarAreaEffect_EGO_ApcBird_LaserObj _laserObject;

	[SerializeField]
	private float _castingDelay;

	private float _elapsedCasting;

	private ApocalypseBirdObjectController _tempBirdObjInstance;

	private List<Transform> _pivotList;

	private List<FarAreaEffect_EGO_ApcBird_LaserObj> _laserObjList;

	private float _elapsedEnd;

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
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_EGO_ApcBird_Laser()
	{
		throw null;
	}
}
