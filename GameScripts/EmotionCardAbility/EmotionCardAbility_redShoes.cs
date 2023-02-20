using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;

public class EmotionCardAbility_redShoes : EmotionCardAbilityBase
{
	private int value;

	private const int _powMin = 1;

	private const int _powMax = 2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void BeforeRollDice(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnSucceedAttack(BattleDiceBehavior behavior)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureEffect_FaceAttacher MakeFaceEffect(BattleUnitView target)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_redShoes()
	{
		throw null;
	}

	public class BattleUnitBuf_redshoes : BattleUnitBuf
	{
		private BattleUnitModel _target;

		private BattleEmotionCardModel _emotionCard;

		private EmotionCardAbility_redShoes _script;

		private List<CreatureEffect_FaceAttacher> _faceEffect;

		private int value;

		private const int _dmgMin = 2;

		private const int _dmgMax = 4;

		public override KeywordBuf bufType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_redshoes(BattleEmotionCardModel emotionCard, BattleUnitModel owner, BattleUnitModel target, EmotionCardAbility_redShoes script)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void BeforeRollDice(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSuccessAttack(BattleDiceBehavior behavior)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override BattleUnitModel ChangeAttackTarget(BattleDiceCardModel card, int currentSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnLayerChanged(string layerName)
		{
			
		}
	}
}
