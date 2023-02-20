using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[ImageEffectAllowedInSceneView]
[ExecuteInEditMode]
public class Pixelize : MonoBehaviour
{
	private Shader _screenAndMaskShader;

	private Material _screenAndMaskMaterial;

	private RenderTexture _temporaryRenderTexture;

	private Shader _combineLayersShader;

	private Material _combineLayersMaterial;

	private Shader ScreenAndMaskShader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private Material ScreenAndMaskMaterial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private RenderTexture TemporaryRenderTarget
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private Shader CombineLayersShader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private Material CombineLayersMaterial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture src, RenderTexture dest)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateTemporaryRenderTarget()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CheckTemporaryRenderTarget()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReleaseTemporaryRenderTarget()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pixelize()
	{
		throw null;
	}
}
