using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_XiaoPo : FarAreaEffect
{
	private float _dmgTime;

	[SerializeField]
	private AudioClip _sound;

	private float _elapsedGiveDmg;

	private float _elapsedDestroyTime;

	private string _PREFAB_PATH;

	[SerializeField]
	private float _createDelay;

	private float _elapsedCreateDelay;

	private bool _bCreateEffect;

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
	private void CreateEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_XiaoPo()
	{
		throw null;
	}
}
