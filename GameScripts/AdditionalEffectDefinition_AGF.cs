using System;
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

	public class SoundEffectInfo
	{
		public int chapterID;

		public int episodeIdx;

		public Dictionary<int, string> soundEffectDic;
	}
}
