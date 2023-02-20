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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitBarValue(float currentsize)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetBarData(float current)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInteratable(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValueChanged()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISizeSliderBar()
		{
			throw null;
		}
	}
}
