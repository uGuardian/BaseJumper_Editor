using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BattleUnitInformationUI_Tab : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
{
	public BattleUnitInformationUI_Tab.TabEvent tabEvent;

	public int tabIdx;

	public Image img;

	public TextMeshProUGUI txt;

	private BattleUnitInformationUI_Tab.TabState _state;

	private _2dxFX_HSV _hsv;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitTab(bool activate)
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
	public void OnPointerClick(PointerEventData eventData)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitInformationUI_Tab()
	{
		throw null;
	}

	public enum TabState
	{
		None,
		MouseOver,
		MouseExit,
		Clicked
	}

	public delegate BattleUnitInformationUI_Tab.TabState TabEvent(int tabIdx, int mouseState);
}
