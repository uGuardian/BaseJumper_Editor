using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FarAreaEffect_RedMist_BigSeveringHori : FarAreaEffect
{
	[SerializeField]
	private FarareaEffect_RedMist_BigSeveringHori_Canvas _cutSceneObj;

	[SerializeField]
	private SpriteRenderer _effectSprite;

	[SerializeField]
	private AnimationCurve _effectSpriteAlphaCurve;

	private float _elapsedEffectSpriteDestroy;

	private float _elapsedDestroy;

	private bool _bAnimStarted;

	private bool _bEndCutscene;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel self, params object[] args)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeMotion()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GiveDamage()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndCutScene()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndEffect()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnEffectEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FarAreaEffect_RedMist_BigSeveringHori()
	{
		throw null;
	}
}
