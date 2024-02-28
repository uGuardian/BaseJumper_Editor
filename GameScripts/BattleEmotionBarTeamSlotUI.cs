using System;
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
			return _currentTeam;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitEnemyTeamIcon(EmotionBattleTeamModel team, BattleEmotionInfoManagerUI manager)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitPlayerTeamIcon(EmotionBattleTeamModel team, BattleEmotionInfoManagerUI manager)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetPosDirect()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetColor(Color frame, Color linearDodge)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{

	}
}
