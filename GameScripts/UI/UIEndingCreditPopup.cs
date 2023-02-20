using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ending;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace UI
{
	[ExecuteInEditMode]
	public class UIEndingCreditPopup : UIPopup
	{
		[Header("Reference")]
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private GameObject ob_logovideo_open;

		[SerializeField]
		private VideoPlayer player_open;

		[Header("Ending Text")]
		[SerializeField]
		private RectTransform rect_EndingText;

		[SerializeField]
		private RectTransform rect_EndingTextForPatron;

		[SerializeField]
		private RectTransform rect_EndingTextForAndyou;

		[Header("Resource")]
		[SerializeField]
		private RectTransform rect_contentParent;

		[SerializeField]
		private UIEndingCredit_BigTitleSlot bigTitlePrefab;

		[SerializeField]
		private UIEndingCredit_TitleSlot titlePrefab;

		[SerializeField]
		private UIEndingCredit_PersonSlot personPrefab;

		[SerializeField]
		private UIEndingCredit_PersonPatronSlot patronSlot;

		[SerializeField]
		private GameObject spacePrefab;

		[Header("CutScene Effect NotUse")]
		[SerializeField]
		private Image img_CutScene;

		[SerializeField]
		private Animator anim_CutScene;

		[SerializeField]
		private List<Sprite> sp_CutSceneList;

		[SerializeField]
		private RefineHsv cutScene_Hsv;

		[SerializeField]
		private _2dxFX_Smoke cutScene_SmokeEffect;

		[SerializeField]
		private _2dxFX_DestroyedFX cutScene_Destoryed;

		[SerializeField]
		private _2dxFX_Frozen cutScene_Frozen;

		[SerializeField]
		private _2dxFX_Blur cutScene_Blur;

		[SerializeField]
		private _2dxFX_DesintegrationFX cutScene_Desintegration;

		[Header("Bgm Manager")]
		[SerializeField]
		private UIEndingLyricsManager endingbgmmanager;

		[Header("End Fade")]
		[SerializeField]
		private CanvasGroup cg_endfade;

		[SerializeField]
		private AnimationCurve fadealphaCurve;

		[Header("Controller")]
		[SerializeField]
		private UICustomSelectable selectable;

		private int effectCounter;

		private int cutSceneSpriteCounter;

		private bool isRunningText;

		private bool isRunningCredit;

		[HideInInspector]
		public bool ingame;

		[Header("EditorCreate")]
		public bool iscreate;

		public bool iscreateUpdate;

		private float speed;

		private float patronspeed;

		private float andyouspeed;

		[Header("For Calc")]
		public float speedmultiply;

		public float speedmultiplyforpatron;

		public int totaltime;

		public int cutsceneinterval;

		private bool isEndBgmStart;

		[SerializeField]
		[Range(0.1f, 15f)]
		private float cutScene_interval;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseEndingCredit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartTextFlowInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndTextFlowAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartTextFlowProcessForAll()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator TextFlowProcessForAll()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartTextFlowProcessForAndyou()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator TextFlowProcessForAndyou()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCutSceneInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator CutSceneProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapCutScene()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEndingCreditPopup()
		{
			throw null;
		}
	}
}
