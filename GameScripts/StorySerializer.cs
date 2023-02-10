using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;
using WorkParser;

public static class StorySerializer
{
	public static bool loaded;

	public static Dictionary<int, ScenarioRoot> chapters;

	public static ScenarioRoot curScenario;

	public static Chapter curChapter;

	public static Episode curEpisode;

	public static int curgroupidx;

	public static int curEpisodeIdx;

	public static int curEpisodeNum;

	public static bool isMod;

	public static string curModPath;

	public static SceneEffect effectDefinition;

	public static string effectFilePath;

	public static string customStoryFilePath;

	public static string customEffectFilePath;

	public static string currentLn;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveEffectFile()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool HasEffectFile(StageStoryInfo stageStoryInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadStageStory(StageStoryInfo stageStoryInfo)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadStoryFile(string storyPath, string effectPath, string modPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LoadEffectFile(int chapterIdx, int groupIdx, int epIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static SceneEffect GetEffectFile(int chapterIdx, int groupIdx, int epIdx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveStoryByMod()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadStory()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SynchronizeVoice(int chapterId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadStory(bool internalPath)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool CheckValidateId(ScenarioRoot s)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StorySerializer()
	{
		throw null;
	}
}
