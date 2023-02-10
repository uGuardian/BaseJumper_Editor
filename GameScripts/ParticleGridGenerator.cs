using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleGridGenerator : MonoBehaviour
{
	public bool rewriteVertexStreams;

	public float particleSize;

	public Color particleColor;

	public Vector3 particleRotation3D;

	public bool randomColorAlpha;

	public float xDistance;

	public float yDistance;

	public float zDistance;

	public int xSize;

	public int ySize;

	public int zSize;

	public float OffsetEven;

	public bool updateEveryFrame;

	private float even;

	private Vector3[] positions;

	private ParticleSystem ps;

	private ParticleSystem.Particle[] particles;

	private List<Vector4> customData;

	private List<Vector4> customData2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateGrid()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateGrid()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void GenerateParticles()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateOffsetVector()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ParticleGridGenerator()
	{
		throw null;
	}
}
