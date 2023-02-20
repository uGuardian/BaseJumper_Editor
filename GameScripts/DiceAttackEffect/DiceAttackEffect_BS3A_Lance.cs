using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

public class DiceAttackEffect_BS3A_Lance : DiceAttackEffect
{
	[SerializeField]
	private GameObject _lanceTrail;

	[SerializeField]
	private SpriteRenderer _lanceSprite;

	[SerializeField]
	private GameObject _damagedEffect;

	[SerializeField]
	private AnimationCurve _lanceSprieFadeCurve;

	[SerializeField]
	private _2dxFX_DesintegrationFX _lanceSpriteEffect;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetScale(float scaleFactor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayer(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DiceAttackEffect_BS3A_Lance()
	{
		throw null;
	}
}
