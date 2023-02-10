using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class LightRays2D : LightRays2DAbstract
{
	private MeshRenderer mr;

	[HideInInspector]
	public int sortingLayer;

	private int _sortingLayer;

	[HideInInspector]
	public int orderInLayer;

	private int _orderInLayer;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void GetReferences()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Material GetMaterial()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ApplyMaterial(Material material)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightRays2D()
	{
		throw null;
	}
}
