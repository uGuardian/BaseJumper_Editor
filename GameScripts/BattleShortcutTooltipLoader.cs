using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class BattleShortcutTooltipLoader : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[Header("Set Inspector")]
	[SerializeField]
	private int key;

	[SerializeField]
	private Vector3 offsetPos;

	private RectTransform rect;

	private BattleShortcutTooltipUI tooltipUI
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public void OnPdSelect(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPdDeselect(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void DisplayToolTip(int idx, bool showkey = true)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleShortcutTooltipLoader()
	{
		throw null;
	}
}
