using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class Roland2_FarArea_TentacleDamaged : FarAreaEffect
{
	[SerializeField]
	private Vector3 additionalScale;

	[SerializeField]
	private Vector2 offset;

	[SerializeField]
	private GameObject effectob;

	[SerializeField]
	private UIAnimationEventHandler animEventHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(BattleUnitModel self, BattleUnitModel target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2_FarArea_TentacleDamaged()
	{
		throw null;
	}
}
