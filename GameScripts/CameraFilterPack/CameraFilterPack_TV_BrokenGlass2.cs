using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Broken Glass2")]
public class CameraFilterPack_TV_BrokenGlass2 : MonoBehaviour
{
	public Shader SCShader;

	private float TimeX;

	[Range(0f, 1f)]
	public float Bullet_1;

	[Range(0f, 1f)]
	public float Bullet_2;

	[Range(0f, 1f)]
	public float Bullet_3;

	[Range(0f, 1f)]
	public float Bullet_4;

	[Range(0f, 1f)]
	public float Bullet_5;

	[Range(0f, 1f)]
	public float Bullet_6;

	[Range(0f, 1f)]
	public float Bullet_7;

	[Range(0f, 1f)]
	public float Bullet_8;

	[Range(0f, 1f)]
	public float Bullet_9;

	[Range(0f, 1f)]
	public float Bullet_10;

	[Range(0f, 1f)]
	public float Bullet_11;

	[Range(0f, 1f)]
	public float Bullet_12;

	private Material SCMaterial;

	private Texture2D Texture2;

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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture sourceTexture, RenderTexture destTexture)
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
	public CameraFilterPack_TV_BrokenGlass2()
	{
		throw null;
	}
}
