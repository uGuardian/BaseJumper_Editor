using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIDeckSlot : UISlot
	{
		[Header("References")]
		[SerializeField]
		private Image frame;

		[SerializeField]
		private Image frame_highlighted;

		[SerializeField]
		private Image icon_empty;

		[SerializeField]
		private Image icon_filled;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private TextMeshProUGUI DefaultName;

		[SerializeField]
		private GameObject deleteButton;

		[SerializeField]
		private CanvasGroup canvasGroup;

		private UIDeckList DeckListRoot;

		private int deckID;

		[HideInInspector]
		public DeckSlotModel deckSlotModel;

		private bool editable;

		public int DeckID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameText(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UIDeckList _deckList, int _id, DeckSlotModel _deckSlotModel, bool _editable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetDefault()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightOn()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlighted()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckSlotModel GetDeckSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OverwriteDeck()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDeleteSlotButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvnet()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerUp(BaseEventData bData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDeckSlot()
		{
			throw null;
		}
	}
}
