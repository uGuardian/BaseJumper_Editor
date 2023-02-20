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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetColorFrame(UIEquipPageSlotState type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(WorkshopSkinData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnScroll(BaseEventData Data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEquipPageCustomizeSlot()
		{
			throw null;
		}
	}
}
