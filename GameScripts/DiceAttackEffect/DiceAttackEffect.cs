using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.DiceAttackEffect
{
	[RequireComponent(typeof(SpriteRenderer), typeof(Animator))]
	public class DiceAttackEffect : MonoBehaviour
	{
		protected bool _bHasDamagedEffect;

		[SerializeField]
		protected Vector2 offset;

		[SerializeField]
		protected Vector3 additionalScale;

		[SerializeField]
		protected SpriteRenderer spr;

		[SerializeField]
		protected Animator animator;

		[SerializeField]
		protected float addedDestroyTime;

		protected float _destroyTime;

		protected BattleUnitModel _self;

		protected Transform _selfTransform;

		protected Transform _targetTransform;

		protected float _elapsed;

		protected Vector3 _initializedPos;

		public bool HasDamagedEffect
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetLayer(string layerName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetScale(float scaleFactor)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetDestroyTime(float destroyTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ResetLocalTransform(Transform t)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetAutoDestruction(GameObject go, float time, bool destroyWhenDisable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddFilter(Type filter)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAttackEffect()
		{
			throw null;
		}
	}
}
