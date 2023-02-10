using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class FogEllipsoid : MonoBehaviour
{
	public FogEllipsoid.Blend m_Blend;

	public float m_Density;

	[MinValue(0f)]
	public float m_Radius;

	[MinValue(0f)]
	public float m_Stretch;

	[Range(0f, 1f)]
	public float m_Feather;

	[Range(0f, 1f)]
	public float m_NoiseAmount;

	public float m_NoiseSpeed;

	[MinValue(0f)]
	public float m_NoiseScale;

	private bool m_AddedToLightManager;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddToLightManager()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FogEllipsoid()
	{
		throw null;
	}

	public enum Blend
	{
		Additive,
		Multiplicative
	}
}
