using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using UnityEngine;

namespace UI
{
	public class UISpriteDataManager : MonoBehaviour
	{
		[Header("Main Sephirah")]
		[SerializeField]
		private Sprite[] floorCurrentStateIcon;

		[Header("Floor Quest")]
		[SerializeField]
		private List<Sprite> floorQuestStateIcon;

		[Header("Floor")]
		[SerializeField]
		private UIIconManager.IconSet[] floorIconSet;

		[Header("Card Data")]
		[SerializeField]
		private Sprite[] _cardRangeIconSprite;

		[SerializeField]
		private Sprite[] cardCostNumberSprites;

		[Header("Book")]
		[SerializeField]
		private UIIconManager.IconSet[] BookStatsIconSet;

		[Header("CardBehaviourList")]
		[SerializeField]
		private List<Sprite> cardBehaviourDetailIcons;

		[SerializeField]
		private List<Sprite> _cardStandbyBehaviourDetailIcons;

		[Header("Story Invitation ICON")]
		[SerializeField]
		private List<UIIconManager.IconSet> StoryIcons;

		private Dictionary<string, UIIconManager.IconSet> StoryIconDic;

		[SerializeField]
		private List<UIIconManager.IconSet> QuestionIcon;

		[Space(10f)]
		[Header("Book Filter Icon")]
		[SerializeField]
		private List<UIIconManager.IconSet> bookGradeFilterIcon;

		[SerializeField]
		private List<UIIconManager.IconSet> bookRarityFilterIcon;

		[Header("Book Sort Icon")]
		[SerializeField]
		private List<UISortIconSet> bookSortIcon;

		[Header("Card Filter Icon")]
		[SerializeField]
		private List<UIIconManager.IconSet> cardCostFilterIcon;

		[SerializeField]
		private List<UIIconManager.IconSet> cardDiceNumberIcon;

		[Header("Abnormality Card LeftFrame")]
		[SerializeField]
		private List<Sprite> _abnormalityFrame;

		[Header("EquipPage EquipIcon")]
		[SerializeField]
		private List<Sprite> _equipIcon;

		[Space(20f)]
		[Header("----------------------------------------")]
		[Header("Battle")]
		[SerializeField]
		private List<Sprite> _battleRecoverIcons;

		[SerializeField]
		private List<Sprite> _emotionLevelIcon;

		[Header("Effect Alarm UI")]
		[SerializeField]
		private List<BattleUIPassiveSet> _battleUIEffectSet;

		[SerializeField]
		public Dictionary<string, BattleUIPassiveSet> BattleUIEffectSetDic;

		[Header("Battle Dice Number")]
		[SerializeField]
		private List<Sprite> battleDice_numberAutoSlice;

		[SerializeField]
		private List<Sprite> _battleDice_numberAutoSliceBg;

		[Header("End")]
		[SerializeField]
		private Sprite[] _blackSilenceSprite;

		[SerializeField]
		private Sprite[] _twistedblueSprite;

		[SerializeField]
		private Sprite[] _anotherEtcSprite;

		[SerializeField]
		private Sprite giftAuraIcon;

		[Header("Battle Upper Information")]
		[SerializeField]
		private Sprite[] _portraitFrame;

		[Header("Card Cost Special")]
		[SerializeField]
		private Sprite[] _cardCostaddGlow;

		public static UISpriteDataManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Sprite[] _floorCurrentStateIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<Sprite> _floorQuestStateIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public UIIconManager.IconSet[] _floorIconSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Sprite[] _cardCostNumberSprites
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<Sprite> _cardBehaviourDetailIcons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> CardStandbyBehaviourDetailIcons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<UIIconManager.IconSet> _storyicons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<UIIconManager.IconSet> _questionicon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<UIIconManager.IconSet> _bookGradeFilterIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<UIIconManager.IconSet> _bookRarityFilterIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<UISortIconSet> _bookSortIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<UIIconManager.IconSet> _cardCostFilterIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<UIIconManager.IconSet> _cardDiceNumberIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public List<Sprite> AbnormalityFrame
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> EquipIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> battleRecoverIcons
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> EmotionLevelIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<BattleUIPassiveSet> BattleUIEffectSet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> BattleDice_NumberAutoSlice
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<Sprite> BattleDice_numberAutoSliceBg
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Sprite[] BlackSilenceSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Sprite[] TwistedblueSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Sprite[] AnotherEtcSprite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Sprite GiftAuraIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Sprite[] PortraitFrame
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[SerializeField]
		public Sprite[] CardCostAddGlow
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIIconManager.IconSet GetBookStatsIcon(UIBookStatsIconType type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStoryIconDictionary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEffectTypoIconDictionary()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIIconManager.IconSet GetStoryIcon(string story)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Sprite GetRangeIconSprite(CardRange range)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISpriteDataManager()
		{
			throw null;
		}
	}
}
