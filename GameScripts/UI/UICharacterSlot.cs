using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UICharacterSlot : UISlot
	{
		[Header("Parent")]
		[SerializeField]
		private UICharacterList listPanel;

		[Header("References")]
		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private RectTransform Rect_Data;

		[SerializeField]
		private GraphicBundle frames;

		[SerializeField]
		private GameObject FrameImage;

		[SerializeField]
		private GameObject SelectedFrame;

		[SerializeField]
		private RawImage portraitImage;

		[SerializeField]
		private RectTransform dataPivot;

		[SerializeField]
		private TextMeshProUGUI Name;

		[Header("StateImage")]
		[SerializeField]
		private Image img_LockImage;

		[SerializeField]
		private Image img_QuestionImage;

		[SerializeField]
		private Image img_DeathMark;

		[SerializeField]
		private Image img_hpFill;

		private UnitDataModel unitData;

		private UnitBattleDataModel _unitBattleData;

		private bool isEmptySlot;

		[Header("BattleSetting Only RightSlot")]
		[SerializeField]
		private GameObject toggleRoot;

		[SerializeField]
		private Image img_ToggleBg;

		[SerializeField]
		private Image img_ToggleGlow;

		[SerializeField]
		private Image img_CheckMark;

		[SerializeField]
		private CanvasGroup cg_toggle;

		[SerializeField]
		private Sprite[] sprite_Checkmark;

		[SerializeField]
		private _2dxFX_HSV hsv_toggleframe;

		[SerializeField]
		private Animator anim_toggleframeanim;

		[Header("Runtime")]
		private bool _isToggleSelected;

		private bool isToggleActive;

		[Header("EdgeBlindFrame")]
		[SerializeField]
		private Image img_edgeblind;

		public float fillspeed;

		public float vibeRunningTime;

		private Coroutine vibeRoutine;

		[Range(0f, 20f)]
		public float startvibepower;

		public UnitDataModel _unitData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UnitBattleDataModel unitBattleData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool _isEmptyslot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsToggleSelected
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetYesToggleState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNoToggleState()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggle(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToggleColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnterToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExitToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetClickable(bool clickable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlot(UnitDataModel data, Color originColor, bool isToggable = false)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetUnknownSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetLockSlot(bool On)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCharacterSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCharacter(UnitDataModel unitData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBattleCharacter(UnitBattleDataModel unitBattleData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadHpBattleSettingSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginalFrameColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOriginalGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNotInvitationLockSlot(bool On)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetQuestionSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetSelected(bool selected)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMouseOverHighlightedColor(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSephirhaChanged(SephirahType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOverallColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator FillProcess(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator DeathMarkSizeProcess(float speed = 5f, float vibepower = 2f)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartVibe()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator SlotVibeProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetLockSlotForBluePrimaryKeter(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartKeterXmarkForBlueAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActiveDeathMark()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICharacterSlot()
		{
			throw null;
		}
	}
}
