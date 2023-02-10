using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIGiftPreviewSlot : MonoBehaviour
	{
		public GiftPosition GiftPartType;

		[SerializeField]
		private Image[] frames;

		[SerializeField]
		private TextMeshProUGUI txt_GiftPart;

		[SerializeField]
		private TextMeshProUGUI txt_GiftName;

		[SerializeField]
		private TextMeshProUGUI txt_GiftDesc;

		[SerializeField]
		private GameObject detailcRect;

		[SerializeField]
		private Image img_Gift;

		public UICustomSelectable SelectableObject;

		[Header("Toggle")]
		[SerializeField]
		private Image eyeToggleFrame;

		[SerializeField]
		private Image eyeToggle_Open;

		[SerializeField]
		private Image eyeToggle_Close;

		[SerializeField]
		private Image eyeIcon_Open;

		[SerializeField]
		private Image eyeIcon_Close;

		private GiftModel Gift;

		private string partTextLoaderId;

		private UILibrarianAppearanceInfoPanel panel;

		private bool isEyeOpen;

		public bool isDisabled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(GiftModel giftdata, UILibrarianAppearanceInfoPanel _root)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabled()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateSlot()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEyeButton(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHighlight(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEyeHighlight(bool isTrue)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEyeColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterToggle(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitToggle(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickToggle(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIGiftPreviewSlot()
		{
			throw null;
		}
	}
}
