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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPreviewPortrait(BookXmlInfo bookItem)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPreviewPortrait(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectCostume(BookModel bookItem)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectCostume(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnequipCostume()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickUnequip()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterCostume(BookModel bookItem)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterCostume(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitCostume()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnequipButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSizeData(int value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAppearanceButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickGenderAppearanceForMale(bool forMale)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickWorkshop()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeClothsPanel()
		{
			throw null;
		}
	}
}
