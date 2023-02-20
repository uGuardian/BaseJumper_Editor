using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_EffectSettingProjectile : MonoBehaviour
{
	public float FlyDistanceForProjectiles;

	public float SpeedMultiplier;

	public LayerMask CollidesWith;

	private float startSpeed;

	private const string particlesAdditionalName = "Distance";

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_EffectSettingProjectile()
	{
		throw null;
	}
}
