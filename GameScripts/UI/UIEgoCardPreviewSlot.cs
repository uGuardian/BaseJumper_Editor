using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEgoCardPreviewSlot : MonoBehaviour
	{
		[SerializeField]
		private UIEgoCardPanel egoCardPanel;

		[SerializeField]
		private Image frame;

		[SerializeField]
		private Image artwork;

		[SerializeField]
		private TextMeshProUGUI cardName;

		[SerializeField]
		private TextMeshProUGUI cardCost;

		[SerializeField]
		private GameObject Lock;

		public UICustomSelectable selectable;

		public DiceCardItemModel CardModel;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(DiceCardItemModel cardModel)
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
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEgoCardPreviewSlot()
		{
			throw null;
		}
	}
}
