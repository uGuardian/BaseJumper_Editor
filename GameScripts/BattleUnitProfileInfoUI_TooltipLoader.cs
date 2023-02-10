using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleUnitProfileInfoUI_TooltipLoader : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Header("Set In Inspector")]
	public int idx;

	public bool isLibrarian;

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
	public void DisplayTooltipOther(int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitProfileInfoUI_TooltipLoader()
	{
		throw null;
	}
}
