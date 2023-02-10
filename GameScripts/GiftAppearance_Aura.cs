using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GiftAppearance_Aura : GiftAppearance
{
	[SerializeField]
	private BodyAura _aura;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void RefreshAppearance(CustomizedAppearance customized, CharacterMotion motion)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiftAppearance_Aura()
	{
		throw null;
	}
}
