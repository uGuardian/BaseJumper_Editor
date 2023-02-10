using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[ExecuteAlways]
[RequireComponent(typeof(Image))]
[DisallowMultipleComponent]
public class UIMask : UIBehaviour
{
	private Shader _maskShader;

	private Material _material;

	public int stencilId;

	public bool isMask;

	[SerializeField]
	private bool m_ShowMaskGraphic;

	public float cutoff;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIMask()
	{
		throw null;
	}
}
