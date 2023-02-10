using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class EffectPreview : MonoBehaviour
	{
		[SerializeField]
		private RawImage _effectPreviewImg;

		[SerializeField]
		private Text _effectNameText;

		[SerializeField]
		private Button _effectPlayButton;

		[SerializeField]
		private Slider _sliderPreviewBgColor;

		[SerializeField]
		private Camera _renderCam;

		[SerializeField]
		private Slider _sliderZoomCamera;

		[SerializeField]
		private Button _zoomInButton;

		[SerializeField]
		private Button _zoomOutButton;

		private DiceEffectSummary _effectSummary;

		private DiceAttackEffect _curPlayingEffect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectSummary(DiceEffectSummary effectSummary)
		{
			throw null;
		}

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
		private void PlayEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeBgColor(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ZoomCamera(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ZoomCameraByButton(bool zoomIn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EffectPreview()
		{
			throw null;
		}
	}
}
