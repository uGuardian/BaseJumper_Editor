using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleEmotionRewardSlotUI : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private BattleEmotionRewardInfoUI panel;

	[SerializeField]
	private RectTransform rect;

	[SerializeField]
	private RectTransform rect_frame;

	[SerializeField]
	private RectTransform rect_bg;

	[SerializeField]
	private Image img_emotionlevel;

	[SerializeField]
	private TextMeshProUGUI txt_Name;

	[SerializeField]
	private List<TextMeshProUGUI> rewardtexts;

	private const float SlotOffsetHeight = 40f;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(UnitBattleDataModel unit, Faction faction)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSizeByText(TextMeshProUGUI txtslot)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionRewardSlotUI()
	{
		throw null;
	}
}
