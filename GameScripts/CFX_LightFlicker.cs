using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class CFX_LightFlicker : MonoBehaviour
{
	public bool loop;

	public float smoothFactor;

	public float addIntensity;

	private float minIntensity;

	private float maxIntensity;

	private float baseIntensity;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CFX_LightFlicker()
	{
		throw null;
	}
}
