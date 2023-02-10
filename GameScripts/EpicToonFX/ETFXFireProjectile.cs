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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void nextEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void previousEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AdjustSpeed(float newSpeed)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ETFXFireProjectile()
		{
			throw null;
		}
	}
}
