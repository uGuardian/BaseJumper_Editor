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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerScroll(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnBeginDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEndDrag(BaseEventData data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIAbnormalityCardPreviewSlot()
		{
			throw null;
		}
	}
}
