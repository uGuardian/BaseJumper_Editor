using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(Image))]
public class UIShapeRaycastMask : MonoBehaviour, ICanvasRaycastFilter
{
	public Image m_Image;

	private Sprite m_Sprite;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsRaycastLocationValid(Vector2 screenPosition, Camera eventCamera)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIShapeRaycastMask()
	{
		throw null;
	}
}
