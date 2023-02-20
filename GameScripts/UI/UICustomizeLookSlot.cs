using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UICustomizeLookSlot : MonoBehaviour
	{
		protected int _id;

		protected int _index;

		protected CustomizingLookType _type;

		protected UnitCustomizingData _data;

		[SerializeField]
		protected GameObject[] sizingObjects;

		[SerializeField]
		protected Image[] frames;

		[SerializeField]
		protected TextMeshProUGUI indexText;

		[SerializeField]
		protected TextMeshProMaterialSetter setter_indextext;

		[SerializeField]
		protected FaceEditor[] FaceEditors;

		public UICustomSelectable selectable;

		public int ID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public int Index
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CustomizingLookType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlight(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnScroll(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomizeLookSlot()
		{
			throw null;
		}
	}
}
