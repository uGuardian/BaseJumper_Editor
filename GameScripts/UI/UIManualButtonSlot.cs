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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerExit(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerClick(BaseEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetHighlighted(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void SetSelected(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualButtonSlot()
		{
			throw null;
		}
	}
}
