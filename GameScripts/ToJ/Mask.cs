using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ToJ
{
	[ExecuteInEditMode]
	[AddComponentMenu("Alpha Mask")]
	[RequireComponent(typeof(MeshRenderer))]
	public class Mask : MonoBehaviour
	{
		[SerializeField]
		private bool _isMaskingEnabled;

		[SerializeField]
		private bool _clampAlphaHorizontally;

		[SerializeField]
		private bool _clampAlphaVertically;

		[SerializeField]
		private float _clampingBorder;

		[SerializeField]
		private bool _useMaskAlphaChannel;

		[SerializeField]
		private Texture mainTex;

		[SerializeField]
		private Vector2 mainTexTiling;

		[SerializeField]
		private Vector2 mainTexOffset;

		private bool fullMaskRefresh;

		private Matrix4x4 oldWorldToMask;

		private Shader defaultMaskedSpriteShader;

		private Shader defaultMaskedUnlitShader;

		private MeshRenderer meshRenderer;

		private Material spritesAlphaMaskWorldCoords;

		private const string SPRITES_RESOURCE_ADDRESS = "Materials/Sprites-Alpha-Mask-WorldCoords";

		public const string MASKED_SPRITE_SHADER = "Alpha Masked/Sprites Alpha Masked - World Coords";

		public const string MASKED_UNLIT_SHADER = "Alpha Masked/Unlit Alpha Masked - World Coords";

		private Material maskMaterial;

		private const string MASK_RESOURCE_ADDRESS = "Materials/Mask-Material";

		private MaterialPropertyBlock maskeePropertyBlock;

		private MaterialPropertyBlock maskPropertyBlock;

		public List<Material> createdMatsStorage;

		public bool IsMaskingEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool ClampAlphaHorizontally
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool ClampAlphaVertically
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public float ClampingBorder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public bool UseMaskAlphaChannel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Texture MainTex
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Vector2 MainTexTiling
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Vector2 MainTexOffset
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ScheduleFullMaskRefresh()
		{
			throw null;
		}

		private Matrix4x4 OldWorldToMask
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		private Shader DefaultMaskedSpriteShader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		private Shader DefaultMaskedUnlitShader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		private MeshRenderer MeshRenderer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Material SpritesAlphaMaskWorldCoords
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public Material MaskMaterial
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public MaterialPropertyBlock MaskeePropertyBlock
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		public MaterialPropertyBlock MaskPropertyBlock
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
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
		public bool IsMaskeeMaterial(Material material)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearShaders()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitializeMeshRenderer(MeshRenderer target)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateInstanciatedMaterials(List<Material> differentMaterials, Matrix4x4 worldToMask)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateUIMaterials(List<Graphic> differentGraphics, Matrix4x4 worldToMask, Vector4 tilingAndOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateSpriteMaterials(List<SpriteRenderer> differentSpriteRenderers, Matrix4x4 worldToMask, Vector4 tilingAndOffset)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateMasking()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ValidateShader(Material material)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshMaskPropertyBlock()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void GetMaskQuad(Mesh mesh, Rect r)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool BasicArrayCompare<T>(T[] one, T[] two)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private List<Material> CollectDifferentMaterials()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeMaskTexture(Texture texture)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMaskRendererActive(bool value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DuplicateMaskedMaterials()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Mask()
		{
			throw null;
		}
	}
}
