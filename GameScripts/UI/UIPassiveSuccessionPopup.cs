using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIPassiveSuccessionPopup : UIPopup
	{
		private static UIPassiveSuccessionPopup _instance;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Animator anim;

		[Header("LeftPanel")]
		public UICustomSelectablePanel leftSelectablePanel;

		[SerializeField]
		private GameObject ob_Profile;

		[SerializeField]
		private TextMeshProUGUI txt_Name;

		[SerializeField]
		private FaceEditor faceEdit;

		[SerializeField]
		private UICharacterBookSlot currentBook;

		[SerializeField]
		private UIPassiveSuccessionEquipBookList equipBookList;

		[SerializeField]
		private UIPassiveSuccessionList equipPassiveList;

		[SerializeField]
		private Image img_originBg;

		[SerializeField]
		private Image img_onlybookbg;

		[Space(10f)]
		[Header("CenterPanel")]
		public UIPassiveSuccessionCenterPanel centerBookListPanel;

		[Space(10f)]
		[Header("RightPanel")]
		public UIPassiveSuccessionBookListPanel rightBookListPanel;

		[Header("Slot Animation")]
		[SerializeField]
		private UIPassiveSuccessionSlot equipAnimSlot;

		[Header("Controller")]
		[SerializeField]
		private GameObject ApplyAndCancelRect;

		[SerializeField]
		private GameObject OnlyApplyRect;

		[SerializeField]
		private GameObject ControllerGuide;

		private UIPassiveSuccessionPopup.ApplyEvent _applyEvent;

		private UnitDataModel _currentUnit;

		private BookModel _currentBookModel;

		private Color originCostColor;

		[Header("Cost UI")]
		[SerializeField]
		private RectTransform rect_CostUI;

		[SerializeField]
		private Image img_costFrame;

		[SerializeField]
		private TextMeshProUGUI txt_costTitle;

		[SerializeField]
		private TextMeshProUGUI txt_costContent;

		public float vibeRunningTime;

		private Coroutine vibeRoutine;

		[Range(0f, 20f)]
		public float startvibepower;

		public static UIPassiveSuccessionPopup Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitDataModel CurrentUnit
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public BookModel CurrentBookModel
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
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel unit, UIPassiveSuccessionPopup.ApplyEvent applyfunc = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDataOnly(BookModel currentbook, UIPassiveSuccessionPopup.ApplyEvent applyfunc = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLeftEquipBooks()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool EquipBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickReleaseAllEquipedBookButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnEquipBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnEquipBookOtherBook(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool ChangePassive(UIPassiveSuccessionCenterPassiveSlot selectedcenterSlot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleasePassive(PassiveModel targetpassive)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleasePassiveReverse(UIPassiveSuccessionSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickApplyButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickCancelButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitReservedData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartLeftEquipBookAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEquipPassiveAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartSetEquipPassiveAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCenterBookRevealInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRightBookRevealInAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCostData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetCostUIColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopCostFullAlarm()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCostFullAlarm()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SlotVibeProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPassiveSuccessionPopup()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIPassiveSuccessionPopup()
		{
			throw null;
		}

		public delegate void ApplyEvent();
	}
}
