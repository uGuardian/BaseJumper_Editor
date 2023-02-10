using System;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

public class UICardListDetailFilterSlot : MonoBehaviour
{
	[SerializeField]
	private UICardListDetailFilterPopup panel;

	[SerializeField]
	private UICustomSelectableToggle SelectableToggle;

	[HideInInspector]
	public int detailNum;

	private UICardListDetailFilterGroup group;

	public bool IsOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(UICardListDetailFilterGroup g, int idx)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetToggleOn(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnClickToggle()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnScroll(BaseEventData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FocusOn(BaseEventData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnXEvent()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UICardListDetailFilterSlot()
	{
		throw null;
	}
}
