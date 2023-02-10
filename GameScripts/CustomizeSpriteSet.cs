using System;
using UnityEngine;

[Serializable]
public class CustomizeSpriteSet : SpriteSet {
	public Color customColor;

	public CustomizeSpriteSet(SpriteRenderer spr, CharacterAppearanceType t, Color c)
		: base(spr, t)
	{
		this.customColor = c;
	}
}
