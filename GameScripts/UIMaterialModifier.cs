using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class UIMaterialModifier : MonoBehaviour, IMaterialModifier
{
	private Matrix4x4 maskMatrix;

	private Vector4 tilingAndOffset;

	private bool screenSpaceEnabled;

	private Texture alphaTexture;

	private bool maskingEnabled;

	private bool isTextMaterial;

	private bool clampHorizontal;

	private bool clampVertical;

	private float clampingBorder;

	private bool useAlphaChannel;

	[SerializeField]
	[HideInInspector]
	private Material modifiedMaterial;

	private Material lastBaseMaterial;

	[SerializeField]
	[HideInInspector]
	private int instanceID;

	private Image image;

	private Text text;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ApplyMaterialProperties(Material target = null)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Material GetModifiedMaterial(Material baseMaterial)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAlphaTex(Texture alphaTexture)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaskToMaskee(Matrix4x4 maskMatrix, Vector4 tilingAndOffset, float clampingBorder, bool maskingEnabled, bool screenSpaceEnabled, bool clampHor, bool clampVert, bool useAlphaChannel, bool isTextMaterial)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIMaterialModifier()
	{
		throw null;
	}
}
