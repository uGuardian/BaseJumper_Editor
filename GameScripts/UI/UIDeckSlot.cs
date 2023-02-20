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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameText(string name)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(UIDeckList _deckList, int _id, DeckSlotModel _deckSlotModel, bool _editable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLightOn()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlighted()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DeckSlotModel GetDeckSlot()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OverwriteDeck()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickDeleteSlotButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DeleteSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvnet()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerUp(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDeckSlot()
		{
			throw null;
		}
	}
}
