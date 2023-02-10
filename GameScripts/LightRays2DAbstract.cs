using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class LightRays2DAbstract : MonoBehaviour
{
	private Material mat;

	public Color color1;

	private Color _color1;

	public Color color2;

	private Color _color2;

	[Range(0f, 5f)]
	public float speed;

	private float _speed;

	[Range(1f, 30f)]
	public float size;

	private float _size;

	[Range(-1f, 1f)]
	public float skew;

	private float _skew;

	[Range(0f, 5f)]
	public float shear;

	private float _shear;

	[Range(0f, 1f)]
	public float fade;

	private float _fade;

	[Range(0f, 50f)]
	public float contrast;

	private float _contrast;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitializeReferences()
	{
		throw null;
	}

	protected abstract void GetReferences();

	protected abstract Material GetMaterial();

	protected abstract void ApplyMaterial(Material material);

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool AnythingChanged()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected LightRays2DAbstract()
	{
		throw null;
	}
}
