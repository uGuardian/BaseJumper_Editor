using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIAbnormalityCardPreviewSlot : MonoBehaviour
	{
		[SerializeField]
		private Image frame;

		[SerializeField]
		private Image artwork;

		[SerializeField]
		private TextMeshProUGUI cardName;

		[SerializeField]
		private TextMeshProUGUI cardLevel;

		public EmotionCardXmlInfo Card;

		public UICustomSelectable selectable;

		[HideInInspector]
		public int index;

		private UIAbnormalityPanel abnormalityPanel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(EmotionCardXmlInfo card, int idx, UIAbnormalityPanel panel)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerScroll(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDrag(BaseEventData data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCardPreviewSlot()
		{
			throw null;
		}
	}
}
