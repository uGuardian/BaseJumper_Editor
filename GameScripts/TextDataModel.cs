using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public static class TextDataModel
{
	private const string ErrorText = "<color=#FF5544>ERROR</color>";

	private static Dictionary<string, string> _dic;

	private static string _currentLanguage;

	private static bool _isLoaded;

	private static string[] _supported;

	private static bool _yame;

	public static string CurrentLanguage
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public static Dictionary<string, string> textDic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitTextData(string currentLanguage)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetText(string id, params object[] args)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<string> GetSupportedLangs()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string GetBattleDialogText(string groupName, string characterName, DialogType dlgType)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TextDataModel()
	{
		throw null;
	}
}
