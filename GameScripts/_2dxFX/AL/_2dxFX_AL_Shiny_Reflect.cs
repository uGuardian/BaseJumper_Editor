using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/Shiny Reflect")]
[Serializable]
public class _2dxFX_AL_Shiny_Reflect : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	[HideInInspector]
	public bool AddShadow;

	[HideInInspector]
	public bool ReceivedShadow;

	[HideInInspector]
	public int BlendMode;

	[HideInInspector]
	public Texture2D __MainTex2;

	private string shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	[Range(-0.5f, 1.5f)]
	public float Light;

	[HideInInspector]
	[Range(0.05f, 1f)]
	public float LightSize;

	[HideInInspector]
	public bool UseShinyCurve;

	[HideInInspector]
	public AnimationCurve ShinyLightCurve;

	[HideInInspector]
	[Range(0f, 32f)]
	public float AnimationSpeedReduction;

	[HideInInspector]
	[Range(0f, 2f)]
	public float Intensity;

	[HideInInspector]
	[Range(0f, 1f)]
	public float OnlyLight;

	[HideInInspector]
	[Range(-1f, 1f)]
	public float LightBump;

	private float ShinyLightCurveTime;

	[HideInInspector]
	public int ShaderChange;

	private Material tempMaterial;

	private Material defaultMaterial;

	private Image CanvasImage;

	private SpriteRenderer CanvasSpriteRenderer;

	[HideInInspector]
	public bool ActiveUpdate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _2dxFX_AL_Shiny_Reflect()
	{
		throw null;
	}
}
