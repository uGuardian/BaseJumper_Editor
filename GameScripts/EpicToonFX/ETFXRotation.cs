using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EpicToonFX
{
	public class ETFXRotation : MonoBehaviour
	{
		[Header("Rotate axises by degrees per second")]
		public Vector3 rotateVector;

		public ETFXRotation.spaceEnum rotateSpace;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETFXRotation()
		{
			throw null;
		}

		public enum spaceEnum
		{
			Local,
			World
		}
	}
}
