using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaeffect_LongBird_Simpan_Final : FarAreaEffect
{
	[SerializeField]
	private GameObject _judgementStartRes;

	[SerializeField]
	private GameObject _judgementEndRes;

	[SerializeField]
	private float _effectScaleFactor;

	private const float _atkDelay = 1f;

	private const float _simpanTime = 3.5f;

	private const float _endDelay = 0.5f;

	private const int _simpanStack = 3;

	private float _elapsedStart;

	private float _elapsedEnd;

	private float _elapsed;

	private bool _attacked;

	private bool _simpan;

	private bool _isRunning;

	private List<FarAreaeffect_LongBird_Simpan_Final.DamagedEffectInfo> _startEffectInfoList;

	private LongBirdMapManager _map;

	public override bool HasIndependentAction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private LongBirdMapManager Map
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
	private void ChangeMotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGiveDamage_1()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleUnitModel> GetSimpanTargets()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GiveDamage(BattleUnitModel attacker, BattleFarAreaPlayManager.VictimInfo v)
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
	public FarAreaeffect_LongBird_Simpan_Final()
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
