using System;
using System.Runtime.CompilerServices;
using Battle.CreatureEffect;

public class EmotionCardAbility_alriune3 : EmotionCardAbilityBase
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_alriune3()
	{
		throw null;
	}

	public class BattleUnitBuf_Emotion_Alriune : BattleUnitBuf
	{
		private const int _bDmgMin = 3;

		private const int _bDmgMax = 7;

		private const int _maxCnt = 4;

		private BattleUnitModel _target;

		private int cnt;

		private CreatureEffect _aura;

		private static int BDmg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Alriune(BattleUnitModel target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(BattleUnitModel owner)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDie()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Destroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DestroyAura()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnTakeDamageByAttack(BattleDiceBehavior atkDice, int dmg)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Curtain()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_Emotion_Alriune2 : BattleUnitBuf
	{
		private bool added;

		private bool effect;

		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool IsTargetable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundStart()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Curtain()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_Emotion_Alriune2()
		{
			throw null;
		}
	}
}
