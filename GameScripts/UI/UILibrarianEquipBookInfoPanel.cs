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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckDisabledBluePrimary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveSlotColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClickPassiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibrarianEquipBookInfoPanel()
		{
			throw null;
		}
	}
}
