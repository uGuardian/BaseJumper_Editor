using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ModInfo
{
	public Dictionary<FaceCustomType, Sprite> faceCustomInfo;

	public Dictionary<CustomActionDetail, SpriteCustomizeData> clothCustomInfo;

	public StageInfo StageInfoDetail;

	public string bookName;

	public bool isFaceCustom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isClothCustom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isStageCustom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddModInfo(FaceCustomType type, Sprite sprite)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddModInfo(CustomActionDetail motion, SpriteCustomizeData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public ModInfo()
	{
		throw null;
	}
}
