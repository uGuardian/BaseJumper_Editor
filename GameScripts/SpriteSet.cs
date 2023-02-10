using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class SpriteSet
{
	public SpriteRenderer sprRenderer;

	public CharacterAppearanceType sprType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SpriteSet(SpriteRenderer spr, CharacterAppearanceType t)
	{
		throw null;
	}
}
