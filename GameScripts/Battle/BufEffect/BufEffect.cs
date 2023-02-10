using System;
using System.Runtime.CompilerServices;
using Sound;
using UnityEngine;

namespace Battle.BufEffect
{
	public class BufEffect : MonoBehaviour
	{
		[SerializeField]
		protected Vector2 offset;

		[SerializeField]
		protected Vector3 additionalScale;

		protected BattleUnitModel _self;

		protected Transform _selfTransform;

		protected Transform _targetTransform;

		protected float _destroyTime;

		protected float _elapsed;

		public string SoundSrc;

		protected SoundEffectPlayer _sound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize(BattleUnitView self)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayer(string layerName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualDestroy()
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
		public BufEffect()
		{
			throw null;
		}
	}
}
