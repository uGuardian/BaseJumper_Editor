﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Battle.CameraFilter
{
	[ExecuteInEditMode]
	public class CameraFilterCustom_universe : MonoBehaviour
	{
		public Shader SCShader;

		private float TimeX;

		private Material SCMaterial;

		[Range(0f, 100f)]
		public float Distortion;

		[Range(0f, 32f)]
		public float Speed;

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
		public CameraFilterCustom_universe()
		{
			throw null;
		}
	}
}
