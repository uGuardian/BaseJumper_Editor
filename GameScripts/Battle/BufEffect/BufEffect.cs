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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLayer(string layerName)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartAudioClip()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BufEffect()
		{
			throw null;
		}
	}
}
