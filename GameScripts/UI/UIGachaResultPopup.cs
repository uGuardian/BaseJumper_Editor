﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIGachaResultPopup : UIPopup
	{
		private static UIGachaResultPopup _instance;

		public GameObject ActiveControl;

		public Transform cardListParent;

		public Animator revealAnim;

		[Header("Reference")]
		[SerializeField]
		private List<UIGachaSlot> _gachaSlotList;

		[SerializeField]
		private List<UIGachaSlot> _gachaSlotList_sub;

		[SerializeField]
		private Image Img_bgFrame;

		[SerializeField]
		private TextMeshProUGUI txt_floorName;

		[Header("page btns")]
		[SerializeField]
		private Button btn_nextPage;

		[SerializeField]
		private Button btn_prevPage;

		[SerializeField]
		private Toggle[] pageToggles;

		[SerializeField]
		private Animator scrollAnimator;

		public int _currentPage;

		private List<BookDropResult> DropList;

		private List<BookDropResult> _currentViewDropList;

		public SephirahType testsep;

		[SerializeField]
		private UIEquipPageModelPreviewPanel equipPagePreview;

		[SerializeField]
		private UIDetailCardSlot cardPreview;

		[SerializeField]
		private Vector3 targetPosForEquipSlotPreview;

		[SerializeField]
		private float equipSlotPreviewWidth;

		[SerializeField]
		private Vector3 targetPosForCardSlotPreview;

		[SerializeField]
		private float cardSlotPreviewWidth;

		[Header("controller")]
		public UICustomSelectablePanel selectablePanel;

		public GameObject confirmButton;

		public GameObject confirmGuide;

		[SerializeField]
		private List<GameObject> upSelectableObjects;

		[SerializeField]
		private List<GameObject> downSelectableObjects;

		private bool isPreviewShow;

		public static UIGachaResultPopup Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<BookDropResult> list, SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGachaList(List<BookDropResult> listOrigin, SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateGachaList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSubGachaList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator WaitResultSOUND()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickConfirm()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator StartCardAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ExistsNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPrevPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickNextPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetMaxPage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdatePageButtons()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPage(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerEnterSlot(UIGachaEquipSlot gachaEquip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerEnterSlot(UIGachaCardSlot gachaCard)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerExitSlot(UIGachaEquipSlot gachaEquip, bool isControllerInput)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PointerExitSlot(UIGachaCardSlot gachaCard, bool isControllerInput)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectDownSelectableObjet(int column)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGuideStateController(bool isController)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmitSlot(UIGachaCardSlot gachaCard)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmitSlot(UIGachaEquipSlot gachaEquip)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaResultPopup()
		{
			throw null;
		}
	}
}
