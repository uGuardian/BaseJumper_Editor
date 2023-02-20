using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BS3_Combo_R_DurandalDown : BS3_Combo_Common
{
	[SerializeField]
	private AnimationCurve _movingCurve;

	[SerializeField]
	private float _movingSpeed;

	private Vector3 _src;

	private Vector3 _dst;

	private float _elapsedMove;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Vector3 src, Vector3 dst)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BS3_Combo_R_DurandalDown()
	{
		throw null;
	}
}
