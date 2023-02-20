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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollDown()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void scrollUp()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpperFloorButton(SephirahType sep, bool interactable = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerFloorButton(SephirahType sep, bool interactable = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUnitScrollButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownUpperArrow()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpUpperArrow()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDownLowerArrow()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerUpLowerArrow()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartSlotsReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealSlotProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBgFloorColor(SephirahType currentsephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultFloorSlot()
		{
			throw null;
		}
	}
}
