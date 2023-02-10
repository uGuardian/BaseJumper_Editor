using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class LocalizedTextLoader : Singleton<LocalizedTextLoader>
{
	public const bool isExternalLocalizeText = false;

	private const string _localizedFolderPath = "Localize/";

	private const string localizeFolder = "Localize/";

	private const string localizeListFileSrc = "LocalizeList";

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadAbnormalityAbilityDescription(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadAbnormalityCardDescriptions(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleCardAbilityDescriptions(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Load(string path, Dictionary<string, BattleCardAbilityDesc> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleCardDescriptions(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadBattleCardDescWithPath(string path, Dictionary<LorId, BattleCardDesc> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleDialogues(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<BattleDialogRelationWithBookID> LoadBattleDialoguesRelations()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBattleEffectTexts(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadBattleEffectTextsWithPath(string path, Dictionary<string, BattleEffectText> dictionary)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBookDescriptions(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadBossBirdText(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadCharactersName(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadStageName(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadGiftDesc(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadLibrariansName(string language)
	{
		throw null;
	}

	public string CurrentLanguage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadOthers(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string BuildPath(params string[] paths)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Load(string currentLanguage, ref Dictionary<string, string> dic)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LoadLocalizeFile(string path, ref Dictionary<string, string> dic)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadPassiveDesc(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddPassiveDesc(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string LoadXmlTextFile(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string[] LoadXmlTextDirectory(string path)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadOpeningLyrics(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadEndingLyrics(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadWhiteNightText(string language)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocalizedTextLoader()
	{
		throw null;
	}
}
