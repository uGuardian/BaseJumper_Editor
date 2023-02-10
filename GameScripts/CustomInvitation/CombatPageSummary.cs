using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPageSummary : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private Text _textCombatPageID;

		[SerializeField]
		private Text _textCombatPageName;

		[SerializeField]
		private Image _rangeImg;

		[SerializeField]
		private Image _chapterBgImg;

		[SerializeField]
		private Image _chapterImg;

		[SerializeField]
		private Toggle _toggle;

		private int _combatPageID;

		public int combatPageID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<CombatPageSummary> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCombatPageInfo(DiceCardXmlInfo cardXmlInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageSummary()
		{
			throw null;
		}
	}
}
