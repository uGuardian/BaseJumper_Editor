using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CameraFilter
{
	[ExecuteInEditMode]
	public class CameraFilterCustom_mhz : MonoBehaviour
	{
		public Shader SCShader;

		private float TimeX;

		private Material SCMaterial;

		[Range(0f, 1f)]
		public float Fade;

		[Range(0f, 10f)]
		private float Value2;

		[Range(0f, 10f)]
		private float Value3;

		[Range(0f, 10f)]
		private float Value4;

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
		public CameraFilterCustom_mhz()
		{
			throw null;
		}
	}
}
