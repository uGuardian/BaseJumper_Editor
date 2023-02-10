using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAlarmPopup : UIPopup, IPointerClickHandler, IEventSystemHandler
	{
		private static UIAlarmPopup _instance;

		[SerializeField]
		private GameObject ob_normal;

		[SerializeField]
		private GameObject ob_blue;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private TextMeshProUGUI txt_alarm;

		[SerializeField]
		private _2dxFX_HSV hsv_frame;

		[Header("Buttons")]
		[SerializeField]
		private UICustomSelectable okButton;

		[SerializeField]
		private UICustomSelectable yesButton;

		[SerializeField]
		private UICustomSelectable noButton;

		[SerializeField]
		private GameObject ob_BlackBg;

		[Header("For Blue")]
		[SerializeField]
		private TextMeshProUGUI txt_alarmForBlue;

		[SerializeField]
		private TextMeshProUGUI[] txt_alarmEffectTextForBlues;

		[SerializeField]
		private UICustomSelectable yesButtonForBlue;

		[SerializeField]
		private UICustomGraphicObject yesButtonGraphicForBlue;

		[SerializeField]
		private UICustomSelectable noButtonForBlue;

		[SerializeField]
		private UICustomGraphicObject noButtonGraphicForBlue;

		[SerializeField]
		private List<GameObject> ButtonRoots;

		[SerializeField]
		private RefineHsv hsv_bgframe;

		[SerializeField]
		private _2dxFX_Smoke smoke_bgframe;

		[Header("RewardTwistedBlue")]
		[SerializeField]
		private GameObject ob_Reward;

		[SerializeField]
		private UIRewardAlarmCardList rewardCardList;

		[SerializeField]
		private UICustomSelectable confirmButtonForReward;

		[SerializeField]
		private TextMeshProUGUI txt_rewardAlarm;

		private UIAlarmType currentAlarmType;

		private ConfirmEvent _confirmEvent;

		private ConfirmRewardevent _confirmRewardEvent;

		private UIAlarmPopup.UIAlarmAnimState currentAnimState;

		private AnimatorUpdateMode currentmode;

		private UIAlarmButtonType buttonNumberType;

		public Image img_bgFrame;

		public Image img_centerFrame;

		public Image img_yesbuttonNormal;

		public Image img_nobuttonNormal;

		public Image img_yesbuttonhighlighted;

		public Image img_nobuttonhighlighted;

		public List<GameObject> hologrameffectlist;

		public bool isEndContentsByInv;

		[Range(0f, 3f)]
		public float delaytimer;

		[Range(0f, 2f)]
		public float backdelaytimer;

		public static UIAlarmPopup instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UICustomSelectable OkButton
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UICustomSelectable YesButton
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UICustomSelectable YesButtonForBlue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		public UIAlarmButtonType ButtonNumberType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAlarmText_unused(UIAlarmType alarmtype)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAlarmText(UIAlarmType alarmtype, UIAlarmButtonType btnType = UIAlarmButtonType.Default, ConfirmEvent confirmFunc = null, string param = "", string param2 = "")
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAlarmText(string text)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAlarmTextForBlue(UIAlarmType alarmtype, ConfirmEvent confirmFunc = null, string param = "", UIStoryLine story = UIStoryLine.None)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRewardAlarm(UIAlarmRewardType type, List<FinalRewardCardInfo> rewarditems, ConfirmRewardevent confirmFunc = null)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealSlotAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ButtonClose()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnYesButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnNoButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTypeCloseFunc()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerZoomAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerZoomOutAnim(UI_BluePrimaryBattleState state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEndContentsStage(EndContentsStageId id, bool showstory = true, bool save = true, bool inv = false, bool ignoreprepare = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConfirmTwistedRewardAlarm()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAlarmPopup()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIAlarmPopup()
		{
			throw null;
		}

		private enum UIAlarmAnimState
		{
			Normal,
			Blue,
			Reward
		}
	}
}
