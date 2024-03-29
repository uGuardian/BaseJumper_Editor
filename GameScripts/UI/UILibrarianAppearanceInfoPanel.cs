﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianAppearanceInfoPanel : MonoBehaviour
	{
		[SerializeField]
		private UILibrarianInfoPanel panel;

		[SerializeField]
		private RawImage portrait;

		[SerializeField]
		private TextMeshProUGUI charNameText;

		[Header("Gift")]
		[SerializeField]
		private List<UIGiftPreviewSlot> giftPreviewSlots;

		public Toggle giftDetailToggle;

		public UIGiftInventory giftInventory;

		public bool GiftChanged;

		[Header("Customize Button")]
		public UICustomGraphicObject button_Customize;

		[HideInInspector]
		public UnitDataModel unitData;

		[HideInInspector]
		public UIGiftPreviewSlot currentGiftPreviewSlot;

		[Header("controller")]
		public UICustomSelectable giftSelectable;

		[Header("Frames For Disabled")]
		[SerializeField]
		private Graphic[] g_frames;

		[SerializeField]
		private TextMeshProMaterialSetter setter_charname;

		[SerializeField]
		private Image img_frameglow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitData(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCustomizeButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateGiftList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGiftToggle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGift(UIGiftPreviewSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCloseGiftInven()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeGift(GiftPosition part)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianAppearanceInfoPanel()
		{
			throw null;
		}
	}
}
