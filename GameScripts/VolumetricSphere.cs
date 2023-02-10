using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class VolumetricSphere : MonoBehaviour
{
	[Header("Parameters")]
	[Tooltip("The radius of the sphere")]
	[Range(0f, 50f)]
	public float radius;

	[Tooltip("The density of the sphere")]
	[Range(0f, 10f)]
	public float density;

	[Tooltip("The curve of the fade-out")]
	[Range(0.2f, 5f)]
	public float exponent;

	[Tooltip("The maximum pixelization size")]
	[Range(1f, 10f)]
	public int maxPixelizationLevel;

	[Tooltip("Enabled the interpolation between the layers of different pixels size")]
	public bool enableLayersInterpolation;

	[Header("Debug")]
	[Tooltip("Outputs the sphere mask")]
	public bool debugSphere;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public VolumetricSphere()
	{
		throw null;
	}
}
