﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class AdditionalEffectDefinition_AGF
{
	public static List<AdditionalEffectDefinition_AGF.SoundEffectInfo> soundEffectInfoList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitDictionary()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetSoundEffectName(int chapter, int episodeIdx, int dlgId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsLastDialogWithHessed(int chapter, int episodeIdx, int dlgId)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdditionalEffectDefinition_AGF()
	{
		throw null;
	}

	public class SoundEffectInfo
	{
		public int chapterID;

		public int episodeIdx;

		public Dictionary<int, string> soundEffectDic;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SoundEffectInfo()
		{
			throw null;
		}
	}
}
