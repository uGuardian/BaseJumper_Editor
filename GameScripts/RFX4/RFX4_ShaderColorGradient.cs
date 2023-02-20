using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_ShaderColorGradient : MonoBehaviour
{
	public RFX4_ShaderProperties ShaderColorProperty;

	public Gradient Color;

	public float TimeMultiplier;

	public bool IsLoop;

	public bool UseSharedMaterial;

	[HideInInspector]
	public float HUE;

	[HideInInspector]
	public bool canUpdate;

	private Material mat;

	private int propertyID;

	private float startTime;

	private Color startColor;

	private bool isInitialized;

	private string shaderProperty;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
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
	public RFX4_ShaderColorGradient()
	{
		throw null;
	}
}
