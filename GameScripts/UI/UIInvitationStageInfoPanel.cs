using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIInvitationStageInfoPanel : MonoBehaviour
	{
		public UIInvitationInfoPanel panel;

		[SerializeField]
		public CanvasGroup cg;

		[Header("enemy info")]
		public Image img_enemyTitleIconBg;

		public Image img_enemyTitleIcon;

		[SerializeField]
		private TextMeshProUGUI txt_enemyNametext;

		[Header("AlarmText")]
		[SerializeField]
		private TextMeshProUGUI txt_AvailableUnit;

		[SerializeField]
		private TextMeshProUGUI txt_AvailableUnitNumber;

		[SerializeField]
		private Image img_availabledunitbg;

		[SerializeField]
		private TextMeshProUGUI txt_EnemyFloor;

		[SerializeField]
		private TextMeshProUGUI txt_EnemyFloorNumber;

		[SerializeField]
		private Image img_enemyFloorBg;

		[SerializeField]
		private TextMeshProUGUI txt_AvailableFloor;

		[SerializeField]
		private TextMeshProUGUI txt_AvailableFloorNumber;

		[SerializeField]
		private Image img_availabledFloorbg;

		[Header("reward info")]
		[SerializeField]
		private RectTransform img_BookRewardFrame;

		[SerializeField]
		private UIRewardDropBookList rewardBookList;

		[SerializeField]
		private TextMeshProUGUI txt_afterbattleText;

		[Header("Story Button")]
		[SerializeField]
		private CanvasGroup storyTitlePanel;

		[SerializeField]
		private UICustomGraphicObject button_prevBattle;

		[SerializeField]
		private UICustomGraphicObject button_nextBattle;

		public Graphic[] graphics_battleframes;

		[SerializeField]
		private TextMeshProMaterialSetter setter_enemyTitle;

		[Header("Only Blue Effect")]
		[SerializeField]
		private GameObject ob_effect;

		[SerializeField]
		private TextMeshProUGUI[] txt_blueEffecttext;

		private StageClassInfo currentStage;

		private Vector2 bookListframeOriginsize;

		private Vector2 bookListframeWidesize;

		public float alphacount;

		public float alphaspeed;

		private bool isrunningAlpha;

		private float startAlpha;

		private float targetAlpha;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultRevealAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool show)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAlphaProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(StageClassInfo stage, UIStoryLine story = UIStoryLine.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStoryButton(bool show)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStoryButton(int index)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ReturnFromEndStory()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationStageInfoPanel()
		{
			throw null;
		}
	}
}
