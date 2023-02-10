using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect_Spore : CreatureEffect
	{
		public GameObject EffectObject;

		public Vector3 localScale;

		private Dictionary<Vector3, CreatureEffect_Spore.TileEffect> tilePos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddTileEffect(Vector3 globalPos)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearEffects()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_Spore()
		{
			throw null;
		}

		public class TileEffect
		{
			public Vector3 pos;

			public GameObject particle;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TileEffect()
			{
				throw null;
			}
		}
	}
}
