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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitSoundBar(int volume)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetExpData(int max, int current)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetValue()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnValueChanged()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSoundBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeSelectSoundBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSubmitSoundBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelSoundBar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectSlider(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDeSelectSlider(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancelSlider(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOptionSoundBar()
		{
			throw null;
		}
	}
}
