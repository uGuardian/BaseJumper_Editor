using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BattleCharacterProfile;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleUnitProfileInfoUI_EmotionLvTooltip : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private BattleCharacterProfileUI _characterProfileUI;

	[SerializeField]
	private VerticalLayoutGroup _layout;

	[SerializeField]
	private List<BattleUnitProfileInfoUI_EmotionLvTooltip_Slot> _slotList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(BattleCharacterProfileUI profileUI)
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitProfileInfoUI_EmotionLvTooltip()
	{
		throw null;
	}
}
