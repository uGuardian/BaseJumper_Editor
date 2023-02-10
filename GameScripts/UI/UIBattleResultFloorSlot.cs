using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleResultFloorSlot : MonoBehaviour
	{
		[Header("Parent")]
		[SerializeField]
		private UIBattleResultPanel _rootPanel;

		[Header("Reference")]
		[SerializeField]
		private Image[] img_Frames;

		[Header("Floor")]
		[SerializeField]
		private UIFloorTitlePanel floorTitlePanel;

		[SerializeField]
		private ScrollRect scroll_UnitListScroll;

		[SerializeField]
		private RectTransform rect_unitGroupRoot;

		[SerializeField]
		private List<UIResultUnitSlot> resultUnitSlotList;

		[SerializeField]
		private Image[] img_UpperFloorbutton;

		[SerializeField]
		private Image[] img_LowerFloorButton;

		[SerializeField]
		private Button button_UpperFloor;

		[SerializeField]
		private Button button_LowerFloor;

		[SerializeField]
		private GameObject ob_upperarrow;

		[SerializeField]
		private GameObject ob_lowerarrow;

		[SerializeField]
		private UICustomSelectable upSelectableObject;

		[SerializeField]
		private UICustomSelectable downSelectableObject;

		private SephirahType currentsep;

		private bool isClickedUnitScrollUpperArrow;

		private bool isClickedUnitScrollLowerArrow;

		public float scrollSpeed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollUp()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpperFloorButton(SephirahType sep, bool interactable = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerFloorButton(SephirahType sep, bool interactable = true)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitScrollButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownUpperArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpUpperArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownLowerArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpLowerArrow()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartSlotsReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBgFloorColor(SephirahType currentsephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultFloorSlot()
		{
			throw null;
		}
	}
}
