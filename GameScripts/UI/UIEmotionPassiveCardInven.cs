using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
	public class UIEmotionPassiveCardInven : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[SerializeField]
		private UIAbnormalityPanel panel;

		[Header("Resource")]
		[SerializeField]
		private Sprite[] _negativeBgSprite;

		[SerializeField]
		private Sprite[] _positiveBgSprite;

		[SerializeField]
		private Sprite[] _negativeFrameSprite;

		[SerializeField]
		private Sprite[] _positiveFrameSprite;

		[Header("Reference")]
		[SerializeField]
		private bool _update;

		[SerializeField]
		private Image _rootImageBg;

		[SerializeField]
		private Image _hOverImg;

		[SerializeField]
		private Image _rightFrame;

		[SerializeField]
		private Image _leftFrameTitleLineardodge;

		[SerializeField]
		private Image _rightBg;

		[SerializeField]
		private Image _artwork;

		[SerializeField]
		private TextMeshProUGUI _cardName;

		[SerializeField]
		private TextMeshProUGUI _flavorText;

		[SerializeField]
		private AbnormalityFlavorTextEffect _flavorEffect;

		[SerializeField]
		private AbnormalityFlavorTextEffect _DescEffect;

		[SerializeField]
		private TextMeshProUGUI _abilityDesc;

		[SerializeField]
		private RectTransform _rootRect;

		[SerializeField]
		private RectTransform _rightRect;

		[SerializeField]
		private Image img_LeftTotalFrame;

		[SerializeField]
		private TextMeshProUGUI txt_Level;

		private EmotionCardXmlInfo _card;

		private Vector2 _rootWidth;

		private Vector2 _rightDstPos;

		private float _rightAlpha;

		private bool _bEntered;

		private BattleEffectSound _hOverSound;

		public bool isDetailSlot;

		private Vector2 _originRootWidth;

		private Vector2 _originRightDstPos;

		private float _originRightAlpha;

		private float elapsed;

		public EmotionCardXmlInfo Card
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public bool IsEntered
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(EmotionCardXmlInfo card)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveDetail(bool on)
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
		private void ResetLayout()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSprites(MentalState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetTexts(string cardName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEmotionPassiveCardInven()
		{
			throw null;
		}
	}
}
