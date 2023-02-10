using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.DiceAttackEffect
{
	[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]
	public class DiceAttackEffectWithActionDetail : DiceAttackEffect
	{
		[SerializeField]
		private ActionDetail actionDetail;

		[SerializeField]
		private float _minScaleFactor;

		[SerializeField]
		private float _maxScaleFactor;

		[SerializeField]
		private float _defaultScaleFactor;

		[SerializeField]
		private bool _hasDamagedEffect;

		[SerializeField]
		private GameObject _damagedEffect;

		[SerializeField]
		private bool _bZeroPosition;

		protected GameObject _damagedEffectObj;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLayer(string layerName)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetScale(float scaleFactor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAttackEffectWithActionDetail()
		{
			throw null;
		}
	}
}
