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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddStack()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SubStack()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitStack()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStack(int stackValue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActive()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPrintEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_Stack()
		{
			throw null;
		}
	}
}
