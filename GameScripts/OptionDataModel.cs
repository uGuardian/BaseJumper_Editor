using System;
using System.Runtime.CompilerServices;
using GameSave;

public class OptionDataModel
{
	public string language;

	public GameResolution resolution;

	public bool isFullscreen;

	public int qualityLevel;

	public int soundVolume_all;

	public int soundVolume_effect;

	public int soundVolume_bgm;

	public int soundVolume_voice;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionDataModel Clone()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetVolumeBGM()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetVolumeEffect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetVolumeVoice()
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public OptionDataModel()
	{
		throw null;
	}
}
