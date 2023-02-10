using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICustomizeNamePanel : UICustomPanel
	{
		public TMP_InputField inputField;

		[SerializeField]
		private Transform transform_nameSlotListRoot;

		public UICustomSelectable nameListSelectable;

		private List<UICustomizeNameTitleSlot> nameSlotList;

		public UICustomGraphicObject shuffleButton;

		public GraphicBundle NameFrames;

		[SerializeField]
		private Transform transform_prefixSlotListRoot;

		public UICustomSelectable prefixListSelectable;

		private List<UICustomizeNameTitleSlot> prefixSlotList;

		[SerializeField]
		private Transform transform_postfixSlotListRoot;

		public UICustomSelectable postfixListSelectable;

		private List<UICustomizeNameTitleSlot> postfixSlotList;

		public GraphicBundle inputFieldGraphics;

		[HideInInspector]
		public UICustomizeNameTitleSlot selectedPrefixSlot;

		[HideInInspector]
		public UICustomizeNameTitleSlot selectedPostfixSlot;

		[HideInInspector]
		public UICustomizeNameTitleSlot selectedNameSlot;

		private int prefixListIdx;

		private int postfixListIdx;

		public GameObject titlePanel;

		[Header("Arrow Button")]
		[SerializeField]
		private Button prefixUpArrow;

		[SerializeField]
		private UICustomSelectable prefixUpSelectable;

		[SerializeField]
		private Button prefixDownArrow;

		[SerializeField]
		private UICustomSelectable prefixDownSelectable;

		[SerializeField]
		private Button postfixUpArrow;

		[SerializeField]
		private UICustomSelectable postfixUpSelectable;

		[SerializeField]
		private Button postfixDownArrow;

		[SerializeField]
		private UICustomSelectable postfixDownSelectable;

		private List<int> nameData;

		private List<GiftModel> giftData;

		private List<GiftModel> prefixGiftData;

		private List<GiftModel> postfixGiftData;

		public TextMeshProUGUI PlaceholderText
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
		public override void InitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameRootActive(bool istrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitNamePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitTitlePanel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePrefixList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePostfixList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameInputFieldHighlight(bool isTrue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickArrowButton(int arrow)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickShuffleNameListButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartEditNameInputField()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndEditNameInputField()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectTitle(UICustomizeNameTitleSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectTitle(UICustomizeNameTitleSlot slot)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectName(int id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject_prefix()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectDownSelectableObject_prefix()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject_postfix()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectDownSelectableObject_postfix()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeNamePanel()
		{
			throw null;
		}
	}
}
