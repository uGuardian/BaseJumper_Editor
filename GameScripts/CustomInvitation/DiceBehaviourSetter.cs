using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceBehaviourSetter : MonoBehaviour
	{
		[SerializeField]
		private Image _blockImg;

		[SerializeField]
		private Toggle _activeToggle;

		[SerializeField]
		private DiceValueSetter _valueSetter;

		[SerializeField]
		private DiceTypeSetter _typeSetter;

		[SerializeField]
		private DiceAbilitySetter _abilitySetter;

		[SerializeField]
		private DiceBehaviourSetter _prevDice;

		[SerializeField]
		private DiceEffectSetter _effectSetter;

		[SerializeField]
		private Button _effectSettingButton;

		[SerializeField]
		private Text _curEffectText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsBehaviourActivated()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSettingEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBehaviourData(DiceBehaviour behaviour, bool activeToggle, bool interactable)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceBehaviour GetDiceBehaviour()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnableBehaviour(bool activated)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenEffectSetter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetEffectRes(string effectName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceBehaviourSetter()
		{
			throw null;
		}
	}
}
