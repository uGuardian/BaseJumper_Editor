using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/RFX4_Bloom")]
	[ImageEffectAllowedInSceneView]
	public class Bloom_RFX4 : MonoBehaviour
	{
		[SerializeField]
		public Bloom_RFX4.Settings settings;

		[SerializeField]
		[HideInInspector]
		private Shader m_Shader;

		private Material m_Material;

		private const int kMaxIterations = 16;

		private RenderTexture[] m_blurBuffer1;

		private RenderTexture[] m_blurBuffer2;

		private int m_Threshold;

		private int m_Curve;

		private int m_PrefilterOffs;

		private int m_SampleScale;

		private int m_Intensity;

		private int m_DirtTex;

		private int m_DirtIntensity;

		private int m_BaseTex;

		public Shader shader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Material material
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bloom_RFX4()
		{
			throw null;
		}

		[Serializable]
		public struct Settings
		{
			[SerializeField]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			[SerializeField]
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual.")]
			public float softKnee;

			[SerializeField]
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			[SerializeField]
			[Tooltip("Blend factor of the result image.")]
			public float intensity;

			[SerializeField]
			[Tooltip("Controls filter quality and buffer resolution.")]
			public bool highQuality;

			[SerializeField]
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;

			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture dirtTexture;

			[MinAttribute_RFX4(0f)]
			[Tooltip("Amount of lens dirtiness.")]
			public float dirtIntensity;

			public float thresholdGamma
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

			public float thresholdLinear
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

			public static Bloom_RFX4.Settings defaultSettings
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}
		}
	}
}
