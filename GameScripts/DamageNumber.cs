using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class DamageNumber : MonoBehaviour
{
	public Image[] imgs;

	[Header("횡종찌에 따른 색깔")]
	[Header("Cut type")]
	public Color cutGlowColor;

	public Color cutImgColor;

	[Header("Strike type")]
	public Color strikeGlowColor;

	public Color strikeImgColor;

	[Header("Penetrate type")]
	public Color penetrateGlowColor;

	public Color penetrateImgColor;

	[Header("흐트러짐 타입에 따른 색깔")]
	[Header("Bleed type")]
	public Color bleedGlowColor;

	public Color bleedImgColor;

	[Header("Knockback type")]
	public Color knockbackGlowColor;

	public Color knockbackImgColor;

	[Header("Stun type")]
	public Color stunGlowColor;

	public Color stunImgColor;

	[Header("Default type")]
	public Color defaultGlowColor;

	public Color defaultImgColor;

	public AnimationCurve curve;

	private float _elapsedTime;

	private Color dmgColor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetColor(Color c, AtkResist resist)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeTextColor()
	{
		throw null;
	}

	public Color color
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAlpha()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DamageNumber()
	{
		throw null;
	}
}
