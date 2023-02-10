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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitCustomData(UnitCustomizingData data, CharacterAppearance appearance)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshAppearanceByMotion(CharacterMotion motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetSpriteByGift(CharacterAppearanceType appearanceType, bool enable)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetOriginalColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetSkinColor()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetSortingOrder(SpriteRenderer renderer, int order)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
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
