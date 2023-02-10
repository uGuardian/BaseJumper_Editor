using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPageEditor : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private CardNameSetter _nameSetter;

		[SerializeField]
		private CardArtworkSetter _artworkSetter;

		[SerializeField]
		private CardRaritySetter _raritySetter;

		[SerializeField]
		private CardRangeSetter _rangeSetter;

		[SerializeField]
		private CardCostSetter _costSetter;

		[SerializeField]
		private CardChapterSetter _chapterSetter;

		[SerializeField]
		private CardOptionSetter _optionSetter;

		[SerializeField]
		private CardPrioritySetter _prioritySetter;

		[SerializeField]
		private CardAbilitySetter _abilitySetter;

		[SerializeField]
		private List<DiceBehaviourSetter> _diceBehaviourSetterList;

		[SerializeField]
		private GameObject _cardAbilityPopup;

		[SerializeField]
		private GameObject _diceAbilityPopup;

		[SerializeField]
		private DiceEffectSetter _diceEffectPopup;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Image _blockImg;

		private Action _callback;

		private bool _isNewCombatPage;

		private DiceCardXmlInfo _curCombatPage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(DiceCardXmlInfo cardInfo, Action callback, bool isNew)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Activate(bool enable)
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
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(DiceCardXmlInfo cardInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneCombatPageSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CombatPageSettingDone()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelCombatPageSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDiceBehaviourList(List<DiceBehaviour> behaviourList)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageEditor()
		{
			throw null;
		}
	}
}
