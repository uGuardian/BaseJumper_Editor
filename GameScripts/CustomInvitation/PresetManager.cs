using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;

namespace CustomInvitation
{
	public sealed class PresetManager
	{
		private static PresetManager _instance;

		private const string _PRESET_PATH = "XML/Preset/";

		private const string _DROPBOOK = "DropBookPreset";

		private const string _CARD_SELFABIL = "BattleCardSelf";

		private const string _CARD_SELFABIL_CAUTION = "BattleCardSelfCaution";

		private const string _CARD_DICEABIL = "BattleCardDice";

		private const string _CARD_DICEABIL_CAUTION = "BattleCardDiceCaution";

		private const string _PASSIVE_DESC = "PassiveDesc";

		private const string _PASSIVE_SPEC = "PassiveList";

		private Dictionary<string, string> _dropBookDic;

		private Dictionary<string, string> _battleDiceAbil;

		private Dictionary<string, string> _battleDiceCautionAbil;

		private Dictionary<string, string> _battleCardSelfAbil;

		private Dictionary<string, string> _battleCardSelfCautionAbil;

		private List<DiceAttackEffect> _effectResList;

		private Dictionary<int, PresetManager.PassivePreset> _passiveDict;

		private Dictionary<int, ResourceXmlInfo> _characterSkinDict;

		private List<AudioClip> _motionSountList;

		public static PresetManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<DiceAttackEffect> GetDiceAttackEffectList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAttackEffect GetDiceAttackEffect(string effectName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<ResourceXmlInfo> GetCharacterSkinList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetDiceAbilityDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetDiceAbilityCautionDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAbilityDescIncludingAssembly(string abilityID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetDiceAbilityDesc(string diceAbilityID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetCardAbilityDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, string> GetCardAbilityCautionDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetCardAbilityDesc(string cardAbilityID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<AudioClip> GetMotionSoundList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<int, PresetManager.PassivePreset> GetPassiveDictionary()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<CustomId, PresetManager.PassivePreset> GetPassiveDictionaryIncludingCustom()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitWithoutLanguage()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadDropbookPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadCardSelfAbilPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadCardDiceAbilPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadPassivePreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadEffectResPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadMotionSoundPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadCharacterPreset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PresetManager()
		{
			throw null;
		}

		public struct PassivePreset
		{
			private string _name;

			private string _desc;

			private int _cost;

			private Rarity _rarity;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PassivePreset(string name, string desc)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PassivePreset(string name, string desc, int cost, Rarity rarity)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetCost(int cost)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public void SetRarity(Rarity rarity)
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetName()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public string GetDesc()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public int GetCost()
			{
				throw null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			public Rarity GetRarity()
			{
				throw null;
			}
		}
	}
}
