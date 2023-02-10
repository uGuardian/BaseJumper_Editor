using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Binah_ShockwaveAtk_Up : FarAreaEffect
{
	private string _PREFAB_NAME;

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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Binah_ShockwaveAtk_Up()
	{
		throw null;
	}
}
