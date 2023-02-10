using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPagePreview : MonoBehaviour
	{
		private static CombatPagePreview _instance;

		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private Image[] _backgroundImages;

		[SerializeField]
		private Text _cardNameText;

		[SerializeField]
		private Text _costText;

		[SerializeField]
		private Image _rangeImage;

		[SerializeField]
		private Text _selfAbilityText;

		[SerializeField]
		private Text _singleUseText;

		[SerializeField]
		private RawImage _artwork;

		[SerializeField]
		private Texture2D _defaultArtworkTex;

		[SerializeField]
		private List<CombatPageDice> _diceList;

		public static CombatPagePreview instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenCardPreview(DiceCardXmlInfo cardInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseCardPreview()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPagePreview()
		{
			throw null;
		}
	}
}
