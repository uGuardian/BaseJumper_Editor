using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class LocalizedFontSetter : SingletonBehavior<LocalizedFontSetter>
{
	[SerializeField]
	private TMP_FontAsset krFont_Arita;

	[SerializeField]
	private TMP_FontAsset krFont_Namsan;

	[SerializeField]
	private TMP_FontAsset jpFont_logoTypeGothic;

	[SerializeField]
	private TMP_FontAsset jpFont_ShipporiMincho;

	[SerializeField]
	private TMP_FontAsset cnFont_notoSansCJKsc;

	[SerializeField]
	private TMP_FontAsset cnFont_notoSerifCJKsc;

	[SerializeField]
	private TMP_FontAsset font_NotoSerif;

	[SerializeField]
	private TMP_FontAsset font_NotoSans;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLocalizedFont(TextMeshProUGUI text, FontType type)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLocalizedFont(TMP_InputField input, FontType type)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FontType GetDefaultFontType(TMP_FontAsset font)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LocalizedFontSetter()
	{
		throw null;
	}
}
