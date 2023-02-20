using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LOR_Input
{
	internal static class ListPool<T>
	{
		private static readonly ObjectPool<List<T>> s_ListPool;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void Clear(List<T> l)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static List<T> Get()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Release(List<T> toRelease)
		{
			
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static ListPool()
		{
			throw null;
		}
	}
}
