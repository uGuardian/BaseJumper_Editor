using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect_Teddy : CreatureEffect
	{
		private float _elap;

		private float _max;

		private bool _smokeEnabled;

		public Animator stackAnim;

		public SpriteRenderer stackSprite;

		public ParticleSystem smokeEffect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime = -1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnHit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_Teddy()
		{
			throw null;
		}
	}
}
