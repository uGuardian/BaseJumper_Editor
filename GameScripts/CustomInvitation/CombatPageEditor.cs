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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Activate(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(DiceCardXmlInfo cardInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneCombatPageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CombatPageSettingDone()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelCombatPageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDiceBehaviourList(List<DiceBehaviour> behaviourList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageEditor()
		{
			throw null;
		}
	}
}
