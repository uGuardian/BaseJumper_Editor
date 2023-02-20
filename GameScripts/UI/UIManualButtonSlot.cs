using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIManualButtonSlot : MonoBehaviour
	{
		[Header("Reference")]
		public TextMeshProUGUI txt_Title;

		public Image img_title;

		public GameObject ob_content;

		public bool isSelected;

		public int Id;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerEnter(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData eventData)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlighted(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelected(bool on)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualButtonSlot()
		{
			throw null;
		}
	}
}
