using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class CreatureAppearance : CharacterAppearance
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitCustomData(UnitCustomizingData customizeData, LorId defaultBookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitGiftDataAll(List<GiftModel> equippedGiftList)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetDamagedSprite(int dmg, float curHp)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ChangeMotion(ActionDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GiftAppearance CreateGiftData(GiftModel gift, string resPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CreatureAppearance()
	{
		throw null;
	}
}
