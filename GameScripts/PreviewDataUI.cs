﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PreviewDataUI : MonoBehaviour
{
	[SerializeField]
	private BattleDiceCardUI cardUI;

	[SerializeField]
	private RawImage rawImg_portrait;

	[SerializeField]
	private CanvasGroup cg;

	private BattleUnitModel unitmodel;

	private BattlePlayingCardDataInUnitModel currentCard;

	public float testvalue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCardData(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetProfileData(BattleUnitView _view)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckParryingState(BattleUnitModel selectedModel, int slotidx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PreviewDataUI()
	{
		throw null;
	}
}
