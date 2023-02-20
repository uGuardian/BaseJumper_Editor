using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISephirahButton : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIBattleSettingPanel panel;

		public RectTransform rect;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Image img_Circle;

		[SerializeField]
		private Image img_CircleGlow;

		[SerializeField]
		private Image img_Icon;

		[SerializeField]
		private Image img_IconGlow;

		[SerializeField]
		private Image img_usedAlarmFrame;

		[SerializeField]
		private _2dxFX_HSV hsv_Icon;

		[SerializeField]
		private _2dxFX_HSV hsv_Circle;

		[SerializeField]
		private _2dxFX_HSV hsv_CircleGlow;

		[SerializeField]
		private CanvasGroup cg;

		[Header("Resources")]
		public Color defeatColor;

		public Color closeColor;

		public UICustomSelectable selectable;

		public UISephirahButton.ButtonState State;

		public SephirahType sephirahType;

		private bool isDisabled;

		private float startbright;

		private float endbright;

		private float speed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonState(UISephirahButton.ButtonState value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetButtonHighlightedState(UISephirahButton.UISephirahButtonType state)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator ChangeHSVProcess()
		{
			throw null;
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
		public UISephirahButton()
		{
			throw null;
		}

		public enum ButtonState
		{
			Open,
			Close,
			Destroied,
			Occupied,
			Limited
		}

		public enum UISephirahButtonType
		{
			Normal,
			Selected,
			Over,
			Pressed
		}
	}
}
