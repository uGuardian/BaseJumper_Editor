using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace UI
{
	public class UIMainOverlayManager : SingletonBehavior<UIMainOverlayManager>
	{
		[Header("Reference")]
		[SerializeField]
		private GameObject tooltiproot;

		[SerializeField]
		private Canvas tooltipCanvas;

		[SerializeField]
		private TextMeshProUGUI tooltipName;

		[SerializeField]
		private TextMeshProMaterialSetter setter_tooltipname;

		[SerializeField]
		private TextMeshProUGUI tooltipDesc;

		[SerializeField]
		private RectTransform tooltipPositionPivot;

		[SerializeField]
		private RectTransform tooltipSizePivot;

		[SerializeField]
		private RectTransform rect_verticalLayout;

		private Vector2 _curSize;

		private Vector2 _rightDownPivot;

		[SerializeField]
		private float normalDescWidth;

		[SerializeField]
		private float onlyContentDescWidth;

		[SerializeField]
		private float normalNameHeight;

		[SerializeField]
		private float onlyContentNameHeight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTooltipOverlay(UIToolTipType type, RectTransform rectTransform, UIToolTipPanelType panelType = UIToolTipPanelType.Normal)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTooltipOnlyContentsText(string content, string param, RectTransform rectTransform, UIToolTipPanelType panelType = UIToolTipPanelType.Normal)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTooltipOverlayBoxPosition(Camera cam, RectTransform targeTranseForm)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTooltipOverlayBoxSize(UIToolTipPanelType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIMainOverlayManager()
		{
			throw null;
		}
	}
}
