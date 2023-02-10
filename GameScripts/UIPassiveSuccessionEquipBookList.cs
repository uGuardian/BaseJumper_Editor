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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(List<BookModel> books)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnequipBookByPanel(BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationCgOff()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAnimationReveal()
	{
		
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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartEquipedAnimation(BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartUnEquipedAnimation(UIPassiveSuccessionEquipBookSlot bookslot, BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIPassiveSuccessionEquipBookList()
	{
		throw null;
	}
}
