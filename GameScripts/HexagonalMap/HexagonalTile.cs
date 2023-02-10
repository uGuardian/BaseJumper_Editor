using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HexagonalMap
{
	public class HexagonalTile
	{
		private TileType _tileType;

		private Vector2 _center;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HexagonalTile()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector2 GetCornerPos()
		{
			throw null;
		}
	}
}
