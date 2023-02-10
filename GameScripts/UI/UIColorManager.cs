using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIColorManager : MonoBehaviour
	{
		public Color[] UIColors;

		[SerializeField]
		private Color _DefaultGlowColor;

		[Header("UI ALL Color")]
		[SerializeField]
		private Color[] SephirahColor;

		[SerializeField]
		private Color[] SephirahClickColor;

		[SerializeField]
		private Color[] SephirahhightlightedColor;

		[SerializeField]
		private Color[] SephirahGlowColor;

		[SerializeField]
		private Color[] SephirahHpColor;

		[SerializeField]
		private Color exclamationIconColor;

		[SerializeField]
		private Color[] EquipRarityColors;

		[Header("Card Slot")]
		[SerializeField]
		private Color[] CardSlotColor;

		public Color[] cardFrameColor;

		[SerializeField]
		private Color[] cardRarityColors;

		[SerializeField]
		private Color[] cardRarityLinearColors;

		[SerializeField]
		private Color _cardEgoColor;

		[SerializeField]
		private Color _cardEgoCostColor;

		[SerializeField]
		private Color _cardEgoLinearColor;

		[SerializeField]
		private Color[] _bookabilityColor;

		[SerializeField]
		private Color[] _behaviourColors;

		[SerializeField]
		private Color[] _diceColors;

		[SerializeField]
		private Color[] _diceLinearDodgeColors;

		[Header("Floor Quest")]
		[SerializeField]
		private Color[] floorQuestSlotIconColor;

		public Color Error;

		[Header("Passive Slot Color")]
		[SerializeField]
		private Color[] _passiveSlotColor;

		[Header("Passive Cost Slot Color")]
		[SerializeField]
		private Color[] _passiveCostColor;

		[Space(20f)]
		[Header("-----------Battle---------")]
		[Header("BattleRecoverIcon Color")]
		[SerializeField]
		private Color[] _battleRecoverIconColors;

		[Header("Battle Action Dice")]
		[SerializeField]
		private Color[] battleDice_IncreaseColor;

		[SerializeField]
		private Color[] batteDice_DecreaseColor;

		[Header("Abnormality Level Glow Color")]
		[SerializeField]
		private Color[] _abnormalityGlowColor;

		[SerializeField]
		private Color[] _passiveIconRarityColor;

		[SerializeField]
		private Color[] _passiveIconRarityGlowColor;

		[Header("Battle Frame UI COLOR")]
		[SerializeField]
		private Color _battleFrameUIColor;

		[SerializeField]
		private Color _enemyUIColor;

		[Header("Card RangeIcon Hsv")]
		[SerializeField]
		private Vector3[] _cardRangehsvValue;

		[Header("BufText")]
		[SerializeField]
		private Color beneficialBufColor;

		[SerializeField]
		private Color harmfulBufColor;

		[SerializeField]
		private Color gimmickBufColor;

		[Header("TheBlueReverberation Color")]
		[SerializeField]
		private Color _blueEffectContentColor;

		[SerializeField]
		private Color _blueEffectGlowColor;

		[Header("End")]
		[SerializeField]
		private Color[] _blackSilenceEffectColor;

		[SerializeField]
		private Color[] _twistedblueEffectColor;

		[SerializeField]
		private Color[] _anotherEtcEffectColor;

		public static UIColorManager Manager
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color DefaultGlowColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color _exclamationIconColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] _CardSlotColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color CardEgoColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color CardEgoCostColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color CardEgoLinearColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] bookabilityColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] BehaviourColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] DiceColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] DiceLinearDodgeColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] _floorQuestSlotIconColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] PassiveSlotColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] PassiveCostColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] battleRecoverIconColors
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] BattleDice_IncreaseColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Color[] BatteDice_DecreaseColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[HideInInspector]
		public Color[] AbnormalityGlowColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] PassiveIconRarityColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color[] PassiveIconRarityGlowColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color BattleFrameUIColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color EnemyUIColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Vector3[] CardRangeHsvValue
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color BeneficialBufColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color HarmfulBufColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color GimmickBufColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color BlueEffectContentColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Color BlueEffectGlowColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Color[] BlackSilenceEffectColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Color[] TwistedblueEffectColor
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[SerializeField]
		public Color[] AnotherEtcEffectColor
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
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetUIColor(UIColor type)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetEquipRarityColor(Rarity rare)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahClickColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahHighlightedColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahGlowColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetSephirahHPColor(SephirahType sephirah)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color[] GetCardFrameColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetCardRarityColor(Rarity rarity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Color GetCardRarityLinearColor(Rarity rarity)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIColorManager()
		{
			throw null;
		}
	}
}
