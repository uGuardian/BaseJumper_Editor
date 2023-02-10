using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIOriginCardSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		protected RectTransform Pivot;

		[SerializeField]
		protected CanvasGroup cg;

		[Header("LeftFrames")]
		[SerializeField]
		protected GameObject ob_NormalFrame;

		[SerializeField]
		protected Image[] img_Frames;

		[SerializeField]
		protected Image[] img_linearDodge;

		[SerializeField]
		protected Image[] img_BehaviourIcons;

		[SerializeField]
		protected _2dxFX_GrayScale[] gs_BehaviourIcons;

		[Header("LeftContents")]
		[SerializeField]
		protected Image img_RangeIcon;

		[SerializeField]
		protected NumbersData costNumbers;

		[SerializeField]
		protected TextMeshProUGUI txt_cardName;

		[SerializeField]
		protected Image img_Artwork;

		[SerializeField]
		protected RefineHsv hsv_rangeIcon;

		[SerializeField]
		public UICustomSelectable selectable;

		protected DiceCardItemModel _cardModel;

		protected Color colorFrame;

		protected Color colorLineardodge;

		[HideInInspector]
		public int originSiblingIdx;

		public DiceCardItemModel CardModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetData(DiceCardItemModel cardmodel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetActiveSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetFrameColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetLinearDodgeColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHighlightedSlot(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetRangeIconHsv(Vector3 hsvvalue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGrayScaleArtwork(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetGrayScale(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnScroll(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIOriginCardSlot()
		{
			throw null;
		}
	}
}
