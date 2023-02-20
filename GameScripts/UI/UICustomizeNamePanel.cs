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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void InitData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameRootActive(bool istrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitNamePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitTitlePanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePrefixList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePostfixList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNameInputFieldHighlight(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RandomCustom()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickArrowButton(int arrow)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickShuffleNameListButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnStartEditNameInputField()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndEditNameInputField()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectTitle(UICustomizeNameTitleSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectTitle(UICustomizeNameTitleSlot slot)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectName(int id)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectName()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSlotsNavigation()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject_prefix()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectDownSelectableObject_prefix()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectUpSelectableObject_postfix()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void onSelectDownSelectableObject_postfix()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeNamePanel()
		{
			throw null;
		}
	}
}
