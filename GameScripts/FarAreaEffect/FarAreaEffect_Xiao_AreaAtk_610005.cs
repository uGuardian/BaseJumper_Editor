using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Xiao_AreaAtk_610005 : FarAreaEffect
{
	[SerializeField]
	private AudioClip _soundStart;

	[SerializeField]
	private AudioClip _soundDmg;

	[SerializeField]
	private GameObject _particle;

	[SerializeField]
	private float _dmgDelay;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private float _earthquakeTime;

	[SerializeField]
	private float _earthquakeSpeed;

	[SerializeField]
	private float _earthquakePowerX;

	[SerializeField]
	private float _earthquakePowerY;

	private float _elapsedDmg;

	private float _elapsedEnd;

	private bool _bGiveDmg;

	private bool _bDone;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void EarthQuake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerator FilterCoroutine(CameraFilterPack_FX_EarthQuake q)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Xiao_AreaAtk_610005()
	{
		throw null;
	}
}
