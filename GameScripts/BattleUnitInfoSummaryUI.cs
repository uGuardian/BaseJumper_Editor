using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitInfoSummaryUI : MonoBehaviour
{
	[Header("Detail UI References")]
	public Image refPortrait;

	public Slider refHP;

	public Slider refMessiness;

	public Image refEmotionLv;

	public Image refBadEmotion;

	public Image refNormalEmotion;

	public Image refGoodEmotion;

	public Image refEmotionGauge;

	public RectTransform refArrowRoot;

	[Header("Summary UI")]
	public Image imgPortrait;

	public Slider sliderHP;

	public Slider sliderMessiness;

	public Image imgEmotionLv;

	public Image imgBadEmotion;

	public Image imgNormalEmotion;

	public Image imgGoodEmotion;

	public Image imgEmotionGauge;

	public RectTransform arrowRoot;

	public Image imgFrame;

	public Image imgFrameGlow;

	public Image[] imgFrames;

	public Image[] imgFrameGlows;

	public Text txtOverCoin;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInfoSummaryUI()
	{
		throw null;
	}
}
