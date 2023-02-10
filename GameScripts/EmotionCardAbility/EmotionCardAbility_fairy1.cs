using System;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;

public class EmotionCardAbility_fairy1 : EmotionCardAbilityBase
{
	private const int _maxHeal = 18;

	private const float _healRate = 0.15f;

	private int _count;

	private int _takeDamageCount;

	private CreatureEffect_Anim _effect;

	private bool _hit;

	private bool _destroy;

	private int _hitCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSelectEmotion()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnPrintEffect(BattleDiceBehavior behavior)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnLayerChanged(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_fairy1()
	{
		throw null;
	}
}
