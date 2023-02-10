using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleUnitDiceActionUI_EmotionCard : MonoBehaviour
{
	[Header("Resources")]
	public Sprite[] titleRefImg;

	[Header("Reference")]
	public Image titleImg;

	public TextMeshProUGUI cardName;

	public Image artwork;

	private Direction _direction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleEmotionCardModel card, Direction unitDirection)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitDiceActionUI_EmotionCard()
	{
		throw null;
	}
}
