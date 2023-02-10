using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 5")]
public class CameraFilterPack_Oculus_NightVision5 : MonoBehaviour
{
	private string ShaderName;

	public Shader SCShader;

	[Range(0f, 1f)]
	public float FadeFX;

	[Range(0f, 1f)]
	public float _Size;

	[Range(0f, 1f)]
	public float _Smooth;

	[Range(0f, 1f)]
	public float _Dist;

	private float TimeX;

	private Material SCMaterial;

	private float[] Matrix9;

	private Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ChangeFilters()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
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
	public CameraFilterPack_Oculus_NightVision5()
	{
		throw null;
	}
}
