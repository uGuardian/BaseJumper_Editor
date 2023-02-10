using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIPassiveSuccessionEquipBookSlot : MonoBehaviour
{
	[SerializeField]
	private UIPassiveSuccessionEquipBookList panel;

	[SerializeField]
	private Image img_Frame;

	[SerializeField]
	private Image img_Highlighted;

	[SerializeField]
	private TextMeshProUGUI txt_BookName;

	[SerializeField]
	private TextMeshProMaterialSetter setter_txtbookname;

	[SerializeField]
	private GameObject ob_Icon;

	[SerializeField]
	private Image img_Icon;

	[SerializeField]
	private Image img_IconGlow;

	public CanvasGroup cg;

	public Animator anim;

	public RectTransform rect;

	private bool isEmpty;

	private BookModel bookmodel;

	public bool isAnimSlot;

	public BookModel CurrentBookModel
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetData(BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetEmpty()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetRarityColor(Color c)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHighlighted(bool on)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerEnter(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerExit(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPointerClick(BaseEventData eventData)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOffNormalSlotInAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetOffAnimationSlotInAnim()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UIPassiveSuccessionEquipBookSlot()
	{
		throw null;
	}
}
