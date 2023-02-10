using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Distortion")]
[Serializable]
public class _2dxFX_Distortion : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	private string shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	[Range(0f, 128f)]
	public float _OffsetX;

	[HideInInspector]
	[Range(0f, 128f)]
	public float _OffsetY;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _DistanceX;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _DistanceY;

	[HideInInspector]
	[Range(0f, 6.28f)]
	public float _WaveTimeX;

	[HideInInspector]
	[Range(0f, 6.28f)]
	public float _WaveTimeY;

	[HideInInspector]
	public bool AutoPlayWaveX;

	[HideInInspector]
	[Range(0f, 5f)]
	public float AutoPlaySpeedX;

	[HideInInspector]
	public bool AutoPlayWaveY;

	[HideInInspector]
	[Range(0f, 50f)]
	public float AutoPlaySpeedY;

	[HideInInspector]
	public bool AutoRandom;

	[HideInInspector]
	[Range(0f, 50f)]
	public float AutoRandomRange;

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
	public _2dxFX_Distortion()
	{
		throw null;
	}
}
