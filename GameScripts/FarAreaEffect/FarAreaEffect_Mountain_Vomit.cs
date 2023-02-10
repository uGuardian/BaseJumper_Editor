using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Mountain_Vomit : FarAreaEffect
{
	[SerializeField]
	private float _runningTime;

	[SerializeField]
	private float _destroyTime;

	[SerializeField]
	private AudioClip _sound;

	[SerializeField]
	private GameObject _corpseEffect;

	[SerializeField]
	private GameObject _liquidEffect;

	[SerializeField]
	private GameObject _radialEffect;

	private float _elapsedBeforeGiveDmg;

	private float _elapsedDestroy;

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
	public FarAreaEffect_Mountain_Vomit()
	{
		throw null;
	}
}
