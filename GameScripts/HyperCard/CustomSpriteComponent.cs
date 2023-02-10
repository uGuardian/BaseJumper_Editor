using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HyperCard
{
	[Serializable]
	public class CustomSpriteComponent : CardComponent
	{
		[SerializeField]
		public SpriteRenderer Renderer;

		[SerializeField]
		public string Key;

		[SerializeField]
		public Texture2D Texture;

		[SerializeField]
		public Vector3 Position;

		[SerializeField]
		public Vector2 Scale;

		[SerializeField]
		public float Zoom;

		[SerializeField]
		public Color Color;

		[SerializeField]
		public float Exposure;

		[SerializeField]
		public bool IsActive;

		[SerializeField]
		public bool ShowAdvancedSettings;

		[SerializeField]
		public int RenderQueue;

		[SerializeField]
		public bool RestrictToArtwork;

		[SerializeField]
		public Texture2D DistortionMask;

		[SerializeField]
		public Vector2 MaskPosition;

		[SerializeField]
		public Vector2 MaskScale;

		[SerializeField]
		public float DistortionFrequency;

		[SerializeField]
		public float DistortionAmplitude;

		[SerializeField]
		public float DistortionSpeed;

		[SerializeField]
		public Vector2 DistortionDirection;

		[SerializeField]
		public Vector2 MoveDirection;

		[SerializeField]
		public bool IsAffectedByFilters;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Compute()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomSpriteComponent()
		{
			throw null;
		}
	}
}
