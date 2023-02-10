using System;
using System.Runtime.CompilerServices;
using GameSave;
using UnityEngine;

public class UnitCustomizingData : Savable
{
	private static Color[] HairColorTable;

	private static Color[] EyeColorTable;

	private static Color[] SkinColorTable;

	public const string save_frontHairID = "frontHairID";

	public const string save_backHairID = "backHairID";

	public const string save_eyeID = "eyeID";

	public const string save_browID = "browID";

	public const string save_mouthID = "mouthID";

	public const string save_headID = "headID";

	public const string save_hairColor = "hairColor";

	public const string save_eyeColor = "eyeColor";

	public const string save_skinColor = "skinColor";

	public const string save_size = "size";

	private bool _bUseCustomData;

	public LorId specialCustomID;

	public int frontHairID;

	public int backHairID;

	public int eyeID;

	public int browID;

	public int mouthID;

	public int headID;

	public Color hairColor;

	public Color eyeColor;

	public Color skinColor;

	private int _height;

	public bool UseCustomData
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public int height
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Copy(UnitCustomizingData origin)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitCustomizingData(LorId id, bool useCustomdata = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitCustomizingData(int sephirahID = 0, bool useCustomdata = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init(LorId sephirahID, bool useCustomdata)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCustomData(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static SaveData ColorToSaveData(Color32 c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color32 SaveDataToColor(SaveData data)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UnitCustomizingData()
	{
		throw null;
	}
}
