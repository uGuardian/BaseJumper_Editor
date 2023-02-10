using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_SnowWhiteStrongVine : FarAreaEffect
{
	public static int count;

	[SerializeField]
	private AudioClip _atkSound;

	[SerializeField]
	private AudioClip _atkFinalSound;

	[SerializeField]
	private SpriteRenderer _vineFilter;

	[SerializeField]
	private float _atkDelay;

	[SerializeField]
	private float _endDelay;

	[SerializeField]
	private GameObject _bllodEffectRes;

	private CameraFilterPack_TV_BrokenGlass _camFilter1;

	private CameraFilterPack_TV_BrokenGlass2 _camFilter2;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnGiveDamage()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DestroyFilters()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_SnowWhiteStrongVine()
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FarAreaEffect_SnowWhiteStrongVine()
	{
		throw null;
	}
}
