using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class CameraFilterCustom_tomerryWhip : MonoBehaviour
{
	public Shader SCShader;

	[Range(0f, 1f)]
	public float value;

	private float TimeX;

	private Material SCMaterial;

	[SerializeField]
	private Texture2D texture2;

	private Material material
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CameraFilterCustom_tomerryWhip()
	{
		throw null;
	}
}
