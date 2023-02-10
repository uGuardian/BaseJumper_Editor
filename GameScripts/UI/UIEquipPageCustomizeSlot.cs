using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using Workshop;

namespace UI
{
	public class UIEquipPageCustomizeSlot : UIOriginEquipPageSlot
	{
		[SerializeField]
		private UIEquipPageCustomizePanel panel;

		[HideInInspector]
		public WorkshopSkinData workshopData;

		private bool isLocked;

		[HideInInspector]
		public BookModel bookModel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetData(BookModel book)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetColorFrame(UIEquipPageSlotState type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(WorkshopSkinData data)
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
		public void OnScroll(BaseEventData Data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageCustomizeSlot()
		{
			throw null;
		}
	}
}
