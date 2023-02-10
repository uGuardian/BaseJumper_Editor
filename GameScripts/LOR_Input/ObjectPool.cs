using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace LOR_Input
{
	internal class ObjectPool<T> where T : new()
	{
		private readonly Stack<T> m_Stack;

		private readonly UnityAction<T> m_ActionOnGet;

		private readonly UnityAction<T> m_ActionOnRelease;

		public int countAll
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		public int countActive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int countInactive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ObjectPool(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public T Get()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Release(T element)
		{
			throw null;
		}
	}
}
