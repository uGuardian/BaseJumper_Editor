using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CreatureEffect
{
	public class CreatureEffect_FaceAttacher : CreatureEffect
	{
		private const string _faceTag = "face";

		protected Transform appearanceTarget;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform FindFace(Transform transform)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize(BattleUnitView self, BattleUnitView target, float destroyTime = -1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AttachTarget(BattleUnitView target, float destroyTime = -1f)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureEffect_FaceAttacher()
		{
			throw null;
		}
	}
}
