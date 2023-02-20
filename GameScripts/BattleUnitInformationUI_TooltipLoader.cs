using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleUnitInformationUI_TooltipLoader : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Header("Reference In Script")]
	public BattleUnitInformationUI_Tooltip enemy_tooltip;

	public BattleUnitInformationUI_Tooltip librarian_tooltip;

	[Header("Set In Inspector")]
	public int idx;

	public bool isLibrarian;

	[Header("Card Resist Tooltip")]
	public bool isCardResistTooltip;

	public bool isResistHp;

	public Vector3 offsetPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayTooltipOther(int idx)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisPlayerTooltipCardResist(int index)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_TooltipLoader()
	{
		throw null;
	}
}
