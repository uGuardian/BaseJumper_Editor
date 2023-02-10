using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class SpriteGhostEffect : MonoBehaviour
{
	[HideInInspector]
	public Material ForceMaterial;

	[HideInInspector]
	public bool ActiveChange;

	public Shader shader;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _Alpha;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _offset;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _ClipLeft;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _ClipRight;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _ClipUp;

	[HideInInspector]
	[Range(0f, 1f)]
	public float _ClipDown;

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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CallUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void XUpdate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteGhostEffect()
	{
		throw null;
	}
}
