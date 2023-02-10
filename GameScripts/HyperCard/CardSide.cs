using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace HyperCard
{
	[Serializable]
	public class CardSide : CardComponent
	{
		private Material _currentMaterial;

		[SerializeField]
		public Renderer Renderer;

		[SerializeField]
		public bool IsEnabled;

		[SerializeField]
		public Texture2D FrameMap;

		[SerializeField]
		public Texture2D FrameDiffuse;

		[SerializeField]
		public Color FrameDiffuseColor;

		[SerializeField]
		public Texture2D Artwork;

		[SerializeField]
		public Vector2 ArtworkOffset;

		[SerializeField]
		public Vector2 ArtworkScale;

		[SerializeField]
		public float ArtworkScaleFactor;

		[SerializeField]
		public bool IsDistortionEnabled;

		[SerializeField]
		public Texture2D DistortionMap;

		[SerializeField]
		public float DistortionRedFrequency;

		[SerializeField]
		public float DistortionRedAmplitude;

		[SerializeField]
		public float DistortionRedSpeed;

		[SerializeField]
		public Vector2 DistortionRedDirection;

		[SerializeField]
		public float DistortionGreenFrequency;

		[SerializeField]
		public float DistortionGreenAmplitude;

		[SerializeField]
		public float DistortionGreenSpeed;

		[SerializeField]
		public Vector2 DistortionGreenDirection;

		[SerializeField]
		public float DistortionBlueFrequency;

		[SerializeField]
		public float DistortionBlueAmplitude;

		[SerializeField]
		public float DistortionBlueSpeed;

		[SerializeField]
		public Vector2 DistortionBlueDirection;

		private int _spriteSheetIndex;

		private float _spriteSheetFxTime;

		private float _spriteSheetNextFxTime;

		[SerializeField]
		public bool IsSpriteSheetEnabled;

		[SerializeField]
		public Texture2D SpriteSheetTexture;

		[SerializeField]
		public Vector2 SpriteSheetSize;

		[SerializeField]
		public float SpriteSheetSpeed;

		[SerializeField]
		public float SpriteSheetOffsetX;

		[SerializeField]
		public float SpriteSheetOffsetY;

		[SerializeField]
		public Vector2 SpriteSheetScale;

		[SerializeField]
		public Color SpriteSheetColor;

		[SerializeField]
		public bool SpriteSheetRemoveBlack;

		[SerializeField]
		public bool IsHoloFxEnabled;

		[SerializeField]
		public bool HoloUseArtworkCoords;

		[SerializeField]
		public Texture2D HoloMask;

		[SerializeField]
		public Texture2D HoloMap;

		[SerializeField]
		public Vector2 HoloMapScale;

		[SerializeField]
		public Cubemap HoloCube;

		[SerializeField]
		public Color HoloCubeColor;

		[SerializeField]
		public float HoloCubeContrast;

		[SerializeField]
		public float HoloCubeRotation;

		[SerializeField]
		public Vector3 HoloCubeBoundingBoxScale;

		[SerializeField]
		public Vector3 HoloCubeBoundingBoxOffset;

		[SerializeField]
		public float HoloPower;

		[SerializeField]
		public float HoloAlpha;

		[SerializeField]
		public bool ShowHoloGuizmo;

		[SerializeField]
		public bool IsGlitterFxEnabled;

		[SerializeField]
		public bool GlitterUseArtworkCoords;

		[SerializeField]
		public Color GlitterColor;

		[SerializeField]
		public float GlitterContrast;

		[SerializeField]
		public float GlitterPower;

		[SerializeField]
		public float GlitterSize;

		[SerializeField]
		public float GlitterSpeed;

		[SerializeField]
		public Texture2D GlitterMask;

		[SerializeField]
		public Vector2 GlitterMaskScale;

		[SerializeField]
		public Texture2D GlitterBackTex;

		[SerializeField]
		public Vector2 GlitterBackTexScale;

		[SerializeField]
		public float GlitterBackPower;

		[SerializeField]
		public float GlitterBackContrast;

		[SerializeField]
		public float GlitterLight;

		[SerializeField]
		public Color GlitterLightColor;

		[SerializeField]
		public float GlitterLightRadius;

		[SerializeField]
		public float GlitterOpacity;

		[SerializeField]
		public bool IsSideColorEnabled;

		[SerializeField]
		public Color SideColor;

		[SerializeField]
		public bool SideColorOverrideTextTags;

		public bool OverrideTextTag
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardSide(Card card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Redraw()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawFrame()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DrawOutline()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeDissolve()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeDistortion()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeSpriteSheet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSpriteSheet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeHoloCubemapFx()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeGlitterFx()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ComputeSideColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrawGizmos()
		{
			throw null;
		}
	}
}
