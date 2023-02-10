using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect_BloodDrain : CreatureEffect
	{
		[SerializeField]
		private GameObject _absorbEffect;

		[SerializeField]
		private GameObject _absorbDoneEffect;

		[SerializeField]
		private AudioClip _absorbDoneSound;

		private AbsorbEffectInfo ae;

		private float _absorbDelay;

		private float _elapsedAbsorb;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime = -1f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPrintEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_BloodDrain()
		{
			throw null;
		}
	}
}
