﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterMotion : MonoBehaviour
{
	[SerializeField]
	public ActionDetail actionDetail;

	[SerializeField]
	public CharacterMotion.MotionDirection motionDirection;

	public Transform customPivot;

	public List<Transform> additionalPivotList;

	[Header("-------------- Original Area --------------")]
	public List<SpriteSet> motionSpriteSet;

	[Header("-------------- Gift Area --------------")]
	[SerializeField]
	public List<CharacterMotion.GiftPivotData> giftPivotList;

	private bool _layerSet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSkinSprite(bool enable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLibrarianOnlySprite(bool enable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableSpritesByType(CharacterAppearanceType t)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisableSpritesByCustomizing(bool isLibrarian)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CustomizeSkinColor(Color skinColor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CustomizeFrontHair(Sprite frontHairSpr)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CustomizeBackHair(Sprite rearHairSpr)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CustomizeFace(Sprite faceSpr)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterMotion()
	{
		throw null;
	}

	[Serializable]
	public struct GiftPivotData
	{
		public GiftPosition giftType;

		public Transform rootTransform;
	}

	public enum MotionDirection
	{
		FrontView,
		SideView
	}
}
