using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class SpecificCharacterInfo
	{
		public int enemyid;

		public Vector3 movestandingpos;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SpecificCharacterInfo(int enemyid, Vector2 movestandingpos)
		{
			throw null;
		}
	}
}
