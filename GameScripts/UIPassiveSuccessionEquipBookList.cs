using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UI;
using UnityEngine;

public class UIPassiveSuccessionEquipBookList : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private UIPassiveSuccessionPopup panel;

	[SerializeField]
	private List<UIPassiveSuccessionEquipBookSlot> bookslotlist;

	[SerializeField]
	private UIPassiveSuccessionEquipBookSlot animSlot;

	[SerializeField]
	private RectTransform rect_ViewPort;

	public UICustomSelectable selectable;

	private bool isRunningReveal;

	private int currentCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(List<BookModel> books)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnequipBookByPanel(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationCgOff()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationReveal()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator RevealAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIPassiveSuccessionEquipBookSlot GetBookSlot(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationDefault()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartEquipedAnimation(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartUnEquipedAnimation(UIPassiveSuccessionEquipBookSlot bookslot, BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIPassiveSuccessionEquipBookList()
	{
		throw null;
	}
}
