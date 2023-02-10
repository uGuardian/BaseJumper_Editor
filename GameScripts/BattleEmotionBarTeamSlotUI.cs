﻿using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleEmotionBarTeamSlotUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private Image _frame;

	[SerializeField]
	private Image _linearDodge;

	[SerializeField]
	private Image img_Icon;

	[SerializeField]
	private Image img_IconGlow;

	private EmotionBattleTeamModel _currentTeam;

	private BattleEmotionInfoManagerUI _manager;

	public EmotionBattleTeamModel CurrentTeam
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEnemyTeamIcon(EmotionBattleTeamModel team, BattleEmotionInfoManagerUI manager)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPlayerTeamIcon(EmotionBattleTeamModel team, BattleEmotionInfoManagerUI manager)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPosDirect()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColor(Color frame, Color linearDodge)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleEmotionBarTeamSlotUI()
	{
		throw null;
	}
}
