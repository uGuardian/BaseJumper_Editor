using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EpicToonFX
{
	public class ETFXFireProjectile : MonoBehaviour
	{
		[SerializeField]
		public GameObject[] projectiles;

		[Header("Missile spawns at attached game object")]
		public Transform spawnPosition;

		[HideInInspector]
		public int currentProjectile;

		public float speed;

		private ETFXButtonScript selectedProjectileButton;

		private RaycastHit hit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void nextEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void previousEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AdjustSpeed(float newSpeed)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETFXFireProjectile()
		{
			throw null;
		}
	}
}
