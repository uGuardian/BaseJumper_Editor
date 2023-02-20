using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIOptionSoundBar : MonoBehaviour
	{
		[SerializeField]
		private GameObject cancelTargetObject;

		[SerializeField]
		private TextMeshProUGUI expValueText;

		[SerializeField]
		private Image img_currentSoundBar;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private Graphic[] img_soundBarBg;

		[SerializeField]
		private TextMeshProMaterialSetter[] txt_setter;

		[SerializeField]
		private Image Img_SelectableHighlightFrame;

		private Vector2 barOriginSize;

		private float barLength;

		private bool _bInit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSoundBar(int volume)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetExpData(int max, int current)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValueChanged()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSoundBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeSelectSoundBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmitSoundBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelSoundBar()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlider(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeSelectSlider(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelSlider(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOptionSoundBar()
		{
			throw null;
		}
	}
}
