using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIInvitationRightMainPanel : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIInvitationPanel invPanel;

		public UICustomSelectablePanel SelectablePanel;

		public List<UIInvitationBookSlot> invitationbookSlots;

		[Header("Stage Lower Icon")]
		public Image LowerIcon;

		public Image LowerIconGlow;

		[SerializeField]
		private TextMeshProUGUI txt_receiverName;

		[SerializeField]
		private GameObject ob_Frames;

		[SerializeField]
		private Graphic[] AllFrames;

		[SerializeField]
		private Animator ButtonFrameHighlight;

		[Header("Buttons")]
		public UICustomGraphicObject button_SendButton;

		[SerializeField]
		private TextMeshProUGUI txt_SendButton;

		[Header("Confirm Area")]
		public GameObject confirmAreaRoot;

		public UICustomSelectable confirmButtonSelectable;

		[Header("Color")]
		public Color GrayColor;

		public Color NotApplyColor;

		public Color BrightColor;

		public Color NeedColor;

		public Color Color_Selectedcolor;

		[Header("TextChange")]
		[SerializeField]
		private TextMeshProMaterialSetter[] setter_changetxts;

		[Header("EndContents Effect")]
		[SerializeField]
		private GameObject ob_blueEffectBackFramesRoot;

		[SerializeField]
		private GameObject ob_blueEffectProcess;

		[SerializeField]
		private Graphic[] g_blueeffectright;

		[SerializeField]
		private Graphic[] g_blueeffectup;

		[SerializeField]
		private GameObject ob_blueEffectCenterFramesRoot;

		[SerializeField]
		private GameObject[] button_lowerEffectButton;

		[SerializeField]
		private TextMeshProUGUI txt_lowerStageTextright;

		[SerializeField]
		private TextMeshProUGUI txt_lowerStageTextup;

		[SerializeField]
		private GameObject ob_blueEffectFrontFramesRoot;

		[Header("EndContents Frames")]
		[SerializeField]
		private List<EndContentsFrame_Invitation> frames_Invitation;

		[SerializeField]
		private Image img_endcontents_frame;

		[SerializeField]
		private Image img_endcontents_text;

		[SerializeField]
		private Image img_endcontents_cover;

		[SerializeField]
		private Image img_endcontents_content;

		[Header("Buttons")]
		public UICustomGraphicObject button_SendButtonForBlue;

		public GraphicBundle g_sendbuttonForBlueBackground;

		[Header("Tutorial Highlight")]
		[SerializeField]
		private GameObject ob_tutorialSendButtonhighlight;

		[SerializeField]
		private GameObject ob_tutorialConfirmButtonhighlight;

		[Header("Workshop Invitation")]
		[SerializeField]
		private GameObject ob_customMode;

		[SerializeField]
		private Toggle _workshopInvitationToggle;

		[SerializeField]
		private UIInvitationRightCustomPanel customInvPanel;

		private StageClassInfo currentSelectedNormalstage;

		private UIInvitationBookSlot _currentSelectedSlot;

		[HideInInspector]
		public UIInvitationBookSlot CurrentOverSlot;

		[HideInInspector]
		public InvitationApply_State currentinvState;

		private bool ispossibleSend;

		private Color currentColor;

		public UIInvitationRightCustomPanel CustomInvPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsWorkshopInvitationToggleOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIInvitationBookSlot CurrentSelectedInvSlot
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInvBookApplyState(InvitationApply_State state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetUpdatePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLowerIconData(StageClassInfo stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyNormalInvBook(LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFixedInviationSlotId(LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyFixedInviationSlotIdAuto(LorId id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSendButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSendButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSendButtonForBlue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendInvitation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConfirmSendInvitation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CancelSendInvitation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter_SendButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit_SendButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUpdatePanelForBlue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter_SendButtonForBlue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit_SendButtonForBlue()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorInvitationSlots(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorAllFrames(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LeftSelectedBook(UIInvitationBookSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReleaseSlotList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RightSelectedBook(UIInvitationBookSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<LorId> GetAppliedBooksId()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationBookSlot CheckEmptySlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DropBookXmlInfo> GetAppliedBookModel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageClassInfo GetBookRecipe()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelBookList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveEndEffect(bool on, InvitationApply_State state = InvitationApply_State.Normal)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColorForBlueEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEndContentsFrame(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickInCustomInvToggle()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedCustomNormalStage(StageClassInfo stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCustomInvToggle(bool ison)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationRightMainPanel()
		{
			throw null;
		}
	}
}
