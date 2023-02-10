using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Advanced Lightning/EnergyBar")]
[Serializable]
public class _2dxFX_AL_EnergyBar : MonoBehaviour
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

	private string shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	[Range(0f, 1f)]
	public float BarProgress;

	[HideInInspector]
	[Range(0.9f, 1f)]
	public float _Value2;

	[HideInInspector]
	[Range(0f, 0.5f)]
	public float _Value3;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Value4;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Value5;

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
	public _2dxFX_AL_EnergyBar()
	{
		throw null;
	}
}
