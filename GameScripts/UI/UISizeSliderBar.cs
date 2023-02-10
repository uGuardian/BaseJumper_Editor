using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UISizeSliderBar : MonoBehaviour, IPointerExitHandler, IEventSystemHandler, IPointerEnterHandler
	{
		[SerializeField]
		private UICustomizeClothsPanel panel;

		public UICustomSelectable selectable;

		[SerializeField]
		private TextMeshProUGUI expValueText;

		[SerializeField]
		private Image img_currentBar;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Graphic[] frames;

		private Vector2 barOriginSize;

		private float Bar_Totalsize;

		private float Bar_CurrentSize;

		private float minValue;

		private float maxValue;

		private bool controllerInputed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBarValue(float currentsize)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBarData(float current)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteratable(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValueChanged()
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
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISizeSliderBar()
		{
			throw null;
		}
	}
}
