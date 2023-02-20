using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_ShaderFloatCurve : MonoBehaviour
{
	public RFX4_ShaderProperties ShaderFloatProperty;

	public AnimationCurve FloatCurve;

	public float GraphTimeMultiplier;

	public float GraphIntensityMultiplier;

	public bool IsLoop;

	public bool UseSharedMaterial;

	private bool canUpdate;

	private float startTime;

	private Material mat;

	private float startFloat;

	private int propertyID;

	private string shaderProperty;

	private bool isInitialized;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
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
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_ShaderFloatCurve()
	{
		throw null;
	}
}
