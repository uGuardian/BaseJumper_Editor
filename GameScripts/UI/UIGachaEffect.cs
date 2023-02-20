using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

namespace UI
{
	public class UIGachaEffect : UIPopup
	{
		private static UIGachaEffect _instance;

		public Animator anim_StartEffect;

		[Header("LevelFrames")]
		[SerializeField]
		private Image img_LightBg;

		[SerializeField]
		private Image img_EffectFrame;

		[SerializeField]
		private Image img_EffectFrameinMask;

		[SerializeField]
		private List<Transform> levelSlotParentList;

		[SerializeField]
		private List<UIGachaLevelSlot[]> slotsByLevel;

		[Header("Hsv")]
		[SerializeField]
		private _2dxFX_HSV[] hsv_frames;

		[SerializeField]
		private Vector3[] hsvValue;

		[Header("Gacha Result")]
		[SerializeField]
		private UIGachaResultPopup popupPanel;

		private List<UIGachaLevelSlot[]> currentRunningSlotList;

		[Header("PostProcessing")]
		public PostProcessProfile pp;

		public Bloom pp_bloom;

		[HideInInspector]
		public bool isbloomUpdateOn;

		[HideInInspector]
		public float bloomIntensityvalue;

		[Header("Controller")]
		[SerializeField]
		private UICustomSelectablePanel selectablePanel;

		public Color floorColor;

		[Header("TestData")]
		public Color[] Sephirahcolor;

		public float fillspeed;

		public SephirahType currentsep;

		public int testlv;

		private float targetalpha;

		public static UIGachaEffect instance
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixedUpdate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DefaultGacha()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RevealResultInAnim(int on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartBgLvEffectOnAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHsv(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartGachaProcess(SephirahType sep, int level)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TestProcess()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ChangeAlphaProcess(List<UIGachaLevelSlot[]> slotlist, int currentslotcount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayStartSound(int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsAnimationPlaying()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGachaEffect()
		{
			throw null;
		}
	}
}
