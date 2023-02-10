using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIReviewStoryEpSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIReviewStorySephirahSlot panel;

		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private Animator anim;

		[SerializeField]
		private int episodeIdx;

		[SerializeField]
		private Animator anim_glow;

		[SerializeField]
		private Image img_frame;

		[SerializeField]
		private Image img_glowframe;

		[SerializeField]
		private TextMeshProUGUI txt_name;

		[SerializeField]
		private TextMeshProUGUI txt_number;

		private SephirahType sep;

		public bool isOpen;

		private TextMeshProMaterialSetter tms_name;

		private TextMeshProMaterialSetter tms_number;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(SephirahType sep)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIReviewStoryEpSlot()
		{
			throw null;
		}
	}
}
