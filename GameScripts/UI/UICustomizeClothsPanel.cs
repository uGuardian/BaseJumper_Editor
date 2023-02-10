using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Workshop;

namespace UI
{
	public class UICustomizeClothsPanel : UICustomPanel
	{
		[Header("Center")]
		[SerializeField]
		private UICustomGraphicObject GenderAppearanceA;

		[SerializeField]
		private UICustomGraphicObject GenderAppearanceB;

		[SerializeField]
		private Image PreviewImage;

		[SerializeField]
		private UISizeSliderBar sizeSlider;

		[Header("EquipPagesPanel")]
		public UICustomSelectable ListSelectable;

		[SerializeField]
		private UIEquipPageCustomizePanel EquipPageCustomizePanel;

		[SerializeField]
		private TextMeshProUGUI corebooktypeMessage;

		[SerializeField]
		private UICustomGraphicObject unequipButton;

		[SerializeField]
		private UICustomGraphicObject workshopButton;

		private List<int> equipBookInfoList;

		private int equippableCount;

		private List<int> workshopSkinInfoList;

		private string meleeType;

		private string hybridType;

		private string rangeType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPreviewPortrait(BookXmlInfo bookItem)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPreviewPortrait(WorkshopSkinData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectCostume(BookModel bookItem)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectCostume(WorkshopSkinData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnequipCostume()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickUnequip()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterCostume(BookModel bookItem)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterCostume(WorkshopSkinData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitCostume()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnequipButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSizeData(int value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAppearanceButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGenderAppearanceForMale(bool forMale)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickWorkshop()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeClothsPanel()
		{
			throw null;
		}
	}
}
