using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SpecialCustomHead
{
	public ActionDetail detail;

	public GameObject rootObject;

	public SpriteRenderer headRenderer;

	public SpriteRenderer faceRenderer;

	public SpriteRenderer frontHairRenderer;

	public SpriteRenderer rearHairRenderer;

	public List<SpriteRenderer> additionalFace;

	public List<SpriteRenderer> additionalFrontHair;

	public List<SpriteRenderer> additionalRearHair;

	public CharacterMotion.MotionDirection motionDirection;

	public GameObject replaceHead;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<SpriteRenderer> GetAllSpriteRenderers()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeAdditionalRendererLayer(string layerName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialCustomHead()
	{
		throw null;
	}
}
