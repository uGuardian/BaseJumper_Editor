using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect : MonoBehaviour
	{
		[SerializeField]
		protected Vector2 offset;

		[SerializeField]
		protected Vector3 additionalScale;

		protected BattleUnitModel _self;

		protected Transform _selfTransform;

		protected Transform _targetTransform;

		protected bool _permanent;

		protected float _destroyTime;

		protected float _elapsed;

		protected EmotionCardAbilityBase _abilityBase;

		protected BattleDiceBehavior _behavior;

		public string SoundSrc;

		protected SoundEffectPlayer _sound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmotionCardAbility(EmotionCardAbilityBase abilityBase)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBattleDiceBehavior(BattleDiceBehavior behavior)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime = -1f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayer(string layerName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ManualDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPrintEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AttachEffectLayer()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartAudioClip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect()
		{
			throw null;
		}
	}
}
