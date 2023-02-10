using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAutoTooltipSlot : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler, IPointerClickHandler
	{
		[Header("Reference")]
		[SerializeField]
		private GameObject tooltiproot;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private Image img_BackGround;

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

		[Header("Values")]
		[Range(0.1f, 3f)]
		public float tooltiprunningtime;

		[SerializeField]
		private float normalDescWidth;

		[SerializeField]
		private float onlyContentDescWidth;

		[SerializeField]
		private float WideDescWidth;

		[SerializeField]
		private float normalNameHeight;

		[SerializeField]
		private float onlyContentNameHeight;

		private Vector2 _curSize;

		private Vector2 _rightDownPivot;

		[SerializeField]
		private UIAutoTooltipType _currentType;

		private RectTransform targetTransform;

		private Camera cam;

		[SerializeField]
		private bool _isRunningCloseAnim;

		private bool isoverExitClose;

		private UITutorialAutoAlarmTemplate tutorialtemplate;

		public UIAutoTooltipType CurrentType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsRunningClose
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator StartOpenProcess()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartCloseAnim()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetToolTip(UIAutoTooltipType type, RectTransform targetRect, bool isAutoClose = true, Camera targetcam = null, UIToolTipPanelType paneltype = UIToolTipPanelType.Normal, UITooltipPanelPositionType postype = UITooltipPanelPositionType.None, bool isoverclose = false, UITutorialAutoAlarmTemplate template = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTooltipOverlayBoxPosition(Camera cam, RectTransform targeTranseForm, UITooltipPanelPositionType postype = UITooltipPanelPositionType.None)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTooltipOverlayBoxSize(UIToolTipPanelType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAutoTooltipSlot()
		{
			throw null;
		}
	}
}
