using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class projectileActor : MonoBehaviour
{
	public Transform spawnLocator;

	public Transform spawnLocatorMuzzleFlare;

	public Transform shellLocator;

	public Animator recoilAnimator;

	public Transform[] shotgunLocator;

	public projectileActor.projectile[] bombList;

	private string FauxName;

	public Text UiText;

	public bool UImaster;

	public bool CameraShake;

	public float rapidFireDelay;

	public CameraShakeProjectile CameraShakeCaller;

	private float firingTimer;

	public bool firing;

	public int bombType;

	public bool swarmMissileLauncher;

	private int projectileSimFire;

	public bool Torque;

	public float Tor_min;

	public float Tor_max;

	public bool MinorRotate;

	public bool MajorRotate;

	private int seq;

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
	public void Switch(int value)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RandomizeRotation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Major_RandomizeRotation()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public projectileActor()
	{
		throw null;
	}

	[Serializable]
	public class projectile
	{
		public string name;

		public Rigidbody bombPrefab;

		public GameObject muzzleflare;

		public float min;

		public float max;

		public bool rapidFire;

		public float rapidFireCooldown;

		public bool shotgunBehavior;

		public int shotgunPellets;

		public GameObject shellPrefab;

		public bool hasShells;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public projectile()
		{
			throw null;
		}
	}
}
