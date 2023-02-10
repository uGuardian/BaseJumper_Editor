using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EpicToonFX
{
	public class ETFXMouseOrbit : MonoBehaviour
	{
		public Transform target;

		public float distance;

		public float xSpeed;

		public float ySpeed;

		public float yMinLimit;

		public float yMaxLimit;

		public float distanceMin;

		public float distanceMax;

		public float smoothTime;

		private float rotationYAxis;

		private float rotationXAxis;

		private float velocityX;

		private float velocityY;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static float ClampAngle(float angle, float min, float max)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETFXMouseOrbit()
		{
			throw null;
		}
	}
}
