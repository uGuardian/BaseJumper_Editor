using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect_Stack : CreatureEffect
	{
		private int _stackCount;

		public Sprite[] StackSprites;

		public Sprite DefaultSprite;

		private Sprite _lastSprite;

		public SpriteRenderer SpriteRenderer;

		[SerializeField]
		protected int _maxStackCount;

		public int StackCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int MaxStackCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitByCode(int max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStack()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubStack()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitStack()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStack(int stackValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPrintEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_Stack()
		{
			throw null;
		}
	}
}
