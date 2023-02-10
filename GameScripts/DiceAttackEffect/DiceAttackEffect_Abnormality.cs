using System;
using System.Runtime.CompilerServices;

namespace Battle.DiceAttackEffect
{
	public class DiceAttackEffect_Abnormality : DiceAttackEffect
	{
		public float lifeTime;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAttackEffect_Abnormality()
		{
			throw null;
		}
	}
}
