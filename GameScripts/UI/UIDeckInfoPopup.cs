using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIDeckInfoPopup : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private UIDeckList root_ListPanel;

		[SerializeField]
		private CanvasGroup canvasGroup;

		[SerializeField]
		private GameObject PointerIcon;

		[SerializeField]
		private UIDeckCardList deckCardListView;

		[SerializeField]
		private TextMeshProUGUI deckNameText;

		[SerializeField]
		private Button renameButton;

		[SerializeField]
		private Button applyNameButton;

		[SerializeField]
		private TMP_InputField nameInputField;

		[SerializeField]
		private TextMeshProUGUI nameText;

		[SerializeField]
		private Image nameFiledFrame;

		[SerializeField]
		private UICustomGraphicObject applyDeckEquipButton;

		public UICustomSelectablePanel selectableRoot;

		public Animator Anim;

		private DeckSlotModel curDeckSlot;

		private int curIdx;

		public bool isOpened
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
		public void SetDeactive()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshDeckData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPopup(UIDeckSlot deckslot, int idx, Vector2 vec, bool isEditing)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClosePopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPointerPos(Vector2 targetPos)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private UILibrarianEquipDeckPanel GetCardDeckPanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void setEditingName(bool editing)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickRenameButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCompleteInput(int hresult, string resultText)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickApplyNameButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnclickApplyDeckButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDeckInfoPopup()
		{
			throw null;
		}
	}
}
