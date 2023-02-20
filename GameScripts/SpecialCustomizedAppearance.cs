using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpecialCustomizedAppearance : CustomizedAppearance
{
	[SerializeField]
	private Color skinColor;

	public int sephirahID;

	public int height;

	public List<SpecialCustomHead> list;

	private UnitCustomizingData _customData;

	private SpecialCustomHead _currentHead;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeLayer(string layerName)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitCustomData(UnitCustomizingData data, CharacterAppearance appearance)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshAppearanceByMotion(CharacterMotion motion)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpriteByGift(CharacterAppearanceType appearanceType, bool enable)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetColor(Color c)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetOriginalColor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetSkinColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSortingOrder(SpriteRenderer renderer, int order)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetRendererOrder(CharacterAppearanceType type, ActionDetail action)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpecialCustomizedAppearance()
	{
		throw null;
	}
}
