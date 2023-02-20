using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIShowEnemyInfoPanel : MonoBehaviour
	{
		[Header("Resources")]
		[SerializeField]
		private CanvasGroup cg;

		[Header("enemy info")]
		public Image img_StageTitleIconBg;

		public Image img_StageTitleIcon;

		[SerializeField]
		private TextMeshProUGUI txt_StageNametext;

		[SerializeField]
		private TextMeshProUGUI txt_enemyName;

		[Header("AbilityData")]
		[SerializeField]
		private UICharacterStatInfoPanel statinfopanel;

		[Header("Inspector")]
		public Image img_Portrait;

		public RawImage rawimg_Portrait;

		[Header("Passive")]
		public UISetInfoSlotListSc passiveSlotList;

		public Graphic[] graphics_battleframes;

		[SerializeField]
		private TextMeshProMaterialSetter setter_enemyTitle;

		[SerializeField]
		private TextMeshProMaterialSetter setter_enemyName;

		[Header("Controller")]
		public UICustomSelectable SelectableRoot;

		[Header("Only Blue Effect")]
		[SerializeField]
		private GameObject ob_effect;

		[SerializeField]
		private TextMeshProUGUI[] txt_blueEffecttext;

		[HideInInspector]
		public UnitDataModel currentShowUnit;

		public float alphacount;

		public float alphaspeed;

		private bool isrunningAlpha;

		private float startAlpha;

		private float targetAlpha;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(UnitDataModel unit, Texture rawimagetexture = null)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultRevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePanel(bool show)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealAlphaProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIInvitationPanel GetInvPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UIEnemyCharacterListPanel GetEnemyListPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIShowEnemyInfoPanel()
		{
			throw null;
		}
	}
}
