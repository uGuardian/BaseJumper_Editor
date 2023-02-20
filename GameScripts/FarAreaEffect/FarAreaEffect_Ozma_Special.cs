using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_Ozma_Special : FarAreaEffect
{
	[SerializeField]
	private GameObject _readyEffect;

	[SerializeField]
	private AudioClip _sound1;

	[SerializeField]
	private AudioClip _sound2;

	[SerializeField]
	private GameObject _particleRoot;

	private float _elapsed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_Ozma_Special()
	{
		throw null;
	}
}
