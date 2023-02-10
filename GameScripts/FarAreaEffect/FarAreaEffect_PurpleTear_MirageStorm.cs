using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_PurpleTear_MirageStorm : FarAreaEffect
{
	[SerializeField]
	private AudioClip _sound_J;

	[SerializeField]
	private AudioClip _sound_H;

	[SerializeField]
	private AudioClip _sound_Z;

	private const string _TRAIL_PREFAB_PATH = "Battle/SpecialEffect/PurpleTearSpecialAreaEffect";

	private static int _motionCount;

	private List<BattleFarAreaPlayManager.VictimInfo> _victimList;

	private float _elapsedEndAtk;

	private float _elapsedAtkOneTarget;

	private GameObject _trailObject;

	private GameObject _ATKEffect_Z;

	private GameObject _ATKEffect_H;

	private GameObject _ATKEffect_J;

	private const string _Effect_Z = "Battle/DiceAttackEffects/New/FX/Mon/PurpleTear/FX_Mon_PurpleTear_Z";

	private const string _Effect_H = "Battle/DiceAttackEffects/New/FX/Mon/PurpleTear/FX_Mon_PurpleTear_H";

	private const string _Effect_J = "Battle/DiceAttackEffects/New/FX/Mon/PurpleTear/FX_Mon_PurpleTear_J";

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
	public FarAreaEffect_PurpleTear_MirageStorm()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FarAreaEffect_PurpleTear_MirageStorm()
	{
		throw null;
	}
}
