using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIBattleSettingWaveSlot : MonoBehaviour
	{
		[SerializeField]
		private UIBattleSettingWaveList panel;

		[SerializeField]
		private RectTransform rect;

		[SerializeField]
		private Image img_circle;

		[SerializeField]
		private Image img_circleglow;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		private Image img_IconGlow;

		[SerializeField]
		private _2dxFX_HSV hsv_Icon;

		[SerializeField]
		private _2dxFX_HSV hsv_IconGlow;

		[SerializeField]
		private _2dxFX_HSV hsv_Circle;

		[SerializeField]
		private _2dxFX_HSV hsv_CircleGlow;

		[SerializeField]
		private TextMeshProUGUI txt_Alarm;

		[SerializeField]
		private TextMeshProMaterialSetter materialsetter_txtAlarm;

		[SerializeField]
		private Image arrow;

		[Header("Resources")]
		public Color defeatColor;

		[Header("Slot Reveal Anim")]
		[SerializeField]
		private Animator anim;

		[SerializeField]
		private CanvasGroup cg;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(StageWaveModel stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNormal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefeat()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlighted()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ActivateArrow(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStartAnimDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartRevealAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEndAnimDefaultInAnim()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleSettingWaveSlot()
		{
			throw null;
		}
	}
}
