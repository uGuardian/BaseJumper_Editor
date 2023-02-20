using System;
using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIItemSlot : MonoBehaviour
	{
		private static UIItemController _itemController;

		public Image Frame;

		public Image Icon;

		public TextMeshProUGUI ItemName;

		public ItemSlotType slotType;

		public bool Interactable;

		public bool IsSelected;

		private ItemModel _itemModel;

		public static UIItemController ItemController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetData(ItemModel itemModel)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(ItemXmlData itemData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ItemModel GetItemModel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetTextColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetFrameColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSlotType(ItemSlotType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetLegendary(bool isLegendary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnEnterPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnExitPointer(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnScroll(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClick(BaseEventData bData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelected(bool selected)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FadeoutEffect(float effectTime)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ClearFadeEffect()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator Coroutine_FadeOut(CanvasGroup group, float effectTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIItemSlot()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[MethodImpl(MethodImplOptions.NoInlining)]
		static UIItemSlot()
		{
			throw null;
		}
	}
}
