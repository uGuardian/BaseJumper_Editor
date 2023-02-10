using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[AddComponentMenu("2DxFX/Standard/Black Hole")]
[Serializable]
public class _2dxFX_BlackHole : MonoBehaviour
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
	public Color _Color;

	[HideInInspector]
	[Range(-1f, 1f)]
	public float Distortion;

	[HideInInspector]
	[Range(0f, 0.5f)]
	public float _Hole;

	[HideInInspector]
	[Range(-10f, 10f)]
	public float Speed;

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
	public _2dxFX_BlackHole()
	{
		throw null;
	}
}
