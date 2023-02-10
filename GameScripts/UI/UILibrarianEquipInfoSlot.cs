﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianEquipInfoSlot : MonoBehaviour
	{
		[SerializeField]
		private UISetInfoSlotListSc listRoot;

		public RectTransform rect;

		[SerializeField]
		private Image Frame;

		[SerializeField]
		private GameObject root;

		[SerializeField]
		private CanvasGroup cg_DataRoot;

		public TextMeshProUGUI txt_cost;

		public TextMeshProUGUI euipName;

		public TextMeshProUGUI euipDesc;

		public GameObject lockRoot;

		public Image img_LockIcon;

		public RectTransform[] rects;

		public UICustomSelectable selectable;

		private float currentcolorAlpha;

		private Color originColor;

		private BookPassiveInfo _currentpassive;

		public BookPassiveInfo Currentpassive
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UIIconManager.IconSet iconSet, string name, string desc, BookPassiveInfo passive = null, bool noCost = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Lock()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmptyDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHeightSlotByText(bool isdefault = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianEquipInfoSlot()
		{
			throw null;
		}
	}
}
