using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TextMeshProMaterialSetter : MonoBehaviour
{
	public bool validate;

	public bool independentSetting;

	public bool activeUpdate;

	[Range(-1f, 1f)]
	[Header("Face")]
	public float faceDilate;

	public Color faceColor;

	[Range(-1f, 1f)]
	public float faceSoftness;

	[Space]
	[Header("Outline")]
	public Color outlineColor;

	[Range(0f, 1f)]
	public float outlineThickness;

	[Space]
	[Header("Underlay")]
	public bool underlayOn;

	public Color underlayColor;

	[Range(-1f, 1f)]
	public float underlayDilate;

	[Range(0f, 1f)]
	public float underlaySoftness;

	[Range(-1f, 1f)]
	public float underlayOffsetX;

	[Range(-1f, 1f)]
	public float underlayOffsetY;

	[Space]
	[Header("Glow")]
	public bool glowOn;

	public Color glowColor;

	[Range(-1f, 1f)]
	public float glowOffset;

	[Range(0f, 1f)]
	public float glowInner;

	[Range(0f, 1f)]
	public float glowOuter;

	[Range(0f, 1f)]
	public float glowPower;

	[SerializeField]
	private TextMeshProUGUI tm;

	public Material defaultMat;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetProperty()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitMaterialProperty()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CopyMaterialProperty()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateMaterialProperty()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public TextMeshProMaterialSetter()
	{
		throw null;
	}
}
