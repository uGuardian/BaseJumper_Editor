using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Binah_ShockwaveAtk : FarAreaEffect
{
	[SerializeField]
	private float _filterSpeed;

	[SerializeField]
	private float _filterSize;

	[SerializeField]
	private float _filterTime;

	[SerializeField]
	private float _dmgTime;

	[SerializeField]
	private AudioClip _sound;

	private float _elapsedGiveDmg;

	private float _elapsedDestroyTime;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Binah_ShockwaveAtk()
	{
		throw null;
	}
}
