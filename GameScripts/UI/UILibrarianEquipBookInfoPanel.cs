using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UILibrarianEquipBookInfoPanel : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private Image iconGlow;

		[SerializeField]
		private TextMeshProUGUI bookName;

		[SerializeField]
		private UICharacterBookSlot currentBook;

		[SerializeField]
		private Image portrait;

		[SerializeField]
		private UISetInfoSlotListSc slotsInfo;

		[SerializeField]
		private UICharacterStatInfoPanel statInfo;

		[SerializeField]
		private UICustomSelectable passivePanelSelectable;

		private List<Graphic> targetGraphics;

		private UnitDataModel unitData;

		[SerializeField]
		private Graphic[] graphic_passivesSlot;

		private bool isDisabledPassiveSuccession;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitData(UnitDataModel data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDisabledBluePrimary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveSlotColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickPassiveSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianEquipBookInfoPanel()
		{
			throw null;
		}
	}
}
