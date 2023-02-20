using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UISephirahEnemyFloorSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIBattleResultSephirahListPanel _rootPanel;

		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private CanvasGroup cg;

		[Header("Frame")]
		[SerializeField]
		private Image img_Frame;

		[SerializeField]
		private Image img_FloorIcon;

		[SerializeField]
		private TextMeshProUGUI txt_FloorName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_FloorName;

		[Header("WaveSlot")]
		[SerializeField]
		private List<UIBattleResultEnemySlotList> waveSlotList;

		[HideInInspector]
		public SephirahType currentSephirah;

		[HideInInspector]
		public int currentWaveCount;

		[HideInInspector]
		public float startSlotheight;

		[HideInInspector]
		public float startHighlightedheight;

		public Vector2 currentFrameSize;

		private Color originFrameColor;

		private Color originFrameGlowColor;

		private readonly float slotWidth;

		public readonly float slotheight;

		public readonly float startslotheight;

		public readonly float totalslotoffset;

		private readonly float bgframeheightoffset;

		public int currentrevealwaveCount;

		[Range(0f, 1f)]
		public float waitnextwavereveal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveSlot(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsActiveSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSlot(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddWaveData(List<UnitBattleDataModel> enemylist)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFrameSize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHideDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartFloorReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealFloorRoutine(float startHeight)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color color)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(UISephirahEnemyFloorSlot.Result_FloorState state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISephirahEnemyFloorSlot()
		{
			throw null;
		}

		public enum Result_FloorState
		{
			LOCKED,
			NORMAL,
			SELECTED,
			PASSED
		}
	}
}
