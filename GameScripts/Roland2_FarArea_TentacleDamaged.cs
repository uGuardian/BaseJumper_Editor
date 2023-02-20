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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(BattleUnitModel self, BattleUnitModel target)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Roland2_FarArea_TentacleDamaged()
	{
		throw null;
	}
}
