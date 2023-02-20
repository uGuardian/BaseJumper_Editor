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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectSummary(DiceEffectSummary effectSummary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PlayEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeBgColor(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ZoomCamera(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ZoomCameraByButton(bool zoomIn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EffectPreview()
		{
			throw null;
		}
	}
}
