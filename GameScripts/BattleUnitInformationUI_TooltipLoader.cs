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
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisplayTooltipOther(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DisPlayerTooltipCardResist(int index)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_TooltipLoader()
	{
		throw null;
	}
}
