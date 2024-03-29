﻿using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIMainPanel : UIPanel
	{
		private static UIMainPanel.KetherTransformInfo _defaultKetherInfo;

		private static UIMainPanel.KetherTransformInfo _onlyKeterInfoUIState;

		private const float _factor = 0.0009259259f;

		private const float _defaultScale = 1f;

		public float EffectTime;

		public float stepSize;

		public float EndScale;

		public UICustomSelectable[] SephirahButtons;

		public UISephirahFloor[] SephirahFloors;

		public RectTransform ZoomPivot;

		public RectTransform SepirothPivot;

		public RectTransform InnerUIPivot;

		public RectTransform SephirahPivot;

		public RectTransform frontCloudBlackOutPivot;

		public CanvasGroup Group;

		public GameObject LowerBlackImage;

		[Header("Display info")]
		public UIMainPanel.TransformInfo[] SepirothStateInfo;

		public UIMainPanel.TransformInfo[] UIStateInfo;

		public UIMainPanel.TransformInfo[] FrontCloudBlackOutInfo;

		[Header("Kether info")]
		public UIMainPanel.KetherTransformInfo[] KetherSetting;

		public RectTransform KetherPivot;

		[Header("Coroutine")]
		[SerializeField]
		private UIMainProcessPanel FrontCloudProcessPanel;

		[SerializeField]
		private UIMainProcessPanel BackCloudProcessPanel;

		[SerializeField]
		private UIMainProcessPanel sepirothBackProcessPanel;

		[SerializeField]
		private UIMainProcessPanel sepirothCenterProcessPanel;

		[SerializeField]
		private UIMainProcessPanel sepirothFrontProcessPanel;

		[Header("BgParticle")]
		[SerializeField]
		private GameObject sepirothBg;

		[SerializeField]
		private GameObject defaultBg;

		public GameObject Ob_TargetBlock;

		[Header("Blue Primary Position")]
		[SerializeField]
		private UIMainPanel.TransformInfo[] SepirothStateInfoForBlue;

		[SerializeField]
		private UIMainPanel.TransformInfo[] UIStateInfoForBlue;

		[SerializeField]
		private GameObject DummyTipherethSep;

		[SerializeField]
		private GameObject DummyBinahSep;

		[SerializeField]
		private Animator zoomAnim;

		[SerializeField]
		private NormalIconSet[] NeonFrames;

		[SerializeField]
		private Color[] NeonOriginColor;

		[SerializeField]
		private Color GrayColorForBluePrimary;

		[Header("TwistedBlue After")]
		[SerializeField]
		private GameObject ob_EnterBattleTwistedBlue;

		[SerializeField]
		private Transform transform_EnterBattleTwistedBlue;

		[SerializeField]
		private Image img_enterbattleTwistedBlueIcon;

		[SerializeField]
		private Image img_enterBattleTwistedBlueFrame;

		[SerializeField]
		private Animator anim_twistedblueicon;

		[SerializeField]
		private UICustomSelectable enterBattleSelectable;

		public UIMainPanel.TransformInfo SepirothStateInfoForEndContents;

		public UIMainPanel.TransformInfo UIStateInfoForEndContents;

		private UIMainPanel.UIType _currentUIType;

		[HideInInspector]
		public SephirahType CurrentSephirahType;

		[HideInInspector]
		public float Delay;

		private UITimer _delayTimer;

		private int savedSephirah;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SephirahType GetLastSelectableSephirah()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainPanel.TransformInfo GetTransformInfo(SephirahType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainPanel.KetherTransformInfo GetKetherTransformInfo(SephirahType maxSephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnOpen()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSephirahSelectableParent(UICustomSelectable parent)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallPhaseMain()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPivotTransform(UIMainPanel.TransformInfo info)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKetherTransform(UIMainPanel.KetherTransformInfo info, bool isRight = true)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnSetSephirah(SephirahType targetSephirah)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSephirahList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnUIPhaseEnter(UIPhase phase)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProcessAll(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetProcessTree(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnUpdatePhase()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckTutorialMain()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickSephirah(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLevelUp(int index)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStartTheBlueReverberationPrimaryBattle(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickStartBlackSilence()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLowerBattleEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LevelUpFloor(LibraryFloorModel floor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPivotY(float pivotY)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDelayedEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPivotScale(float factor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator ZoomInEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFloorPanel GetFloorPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOnEnableZoomAnim(string trigger)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOffEnableZoomAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwapTheTwistedBlueIcon(bool over)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainPanel()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIMainPanel()
		{
			throw null;
		}

		public enum UIType
		{
			Sepiroth,
			Else
		}

		[Serializable]
		public class TransformInfo
		{
			public float Scale;

			public float yPosition;

			public float xPosition;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public TransformInfo()
			{
				throw null;
			}
		}

		[Serializable]
		public class KetherTransformInfo : UIMainPanel.TransformInfo
		{
			public float xPos;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public KetherTransformInfo()
			{
				throw null;
			}
		}
	}
}
