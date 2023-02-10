using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPageDice : MonoBehaviour
	{
		[SerializeField]
		private Color[] _backgroundColors;

		[SerializeField]
		private Sprite _atkSlashSprite;

		[SerializeField]
		private Sprite _atkPenetrateSprite;

		[SerializeField]
		private Sprite _atkHitSprite;

		[SerializeField]
		private Sprite _defGuardSprite;

		[SerializeField]
		private Sprite _defEvasionSprite;

		[SerializeField]
		private Sprite _standbySlashSprite;

		[SerializeField]
		private Sprite _standbyPenetrateSprite;

		[SerializeField]
		private Sprite _standbyHitSprite;

		[SerializeField]
		private Sprite _standbyGuardSprite;

		[SerializeField]
		private Sprite _standbyEvasionSprite;

		[Header("Runtime")]
		[SerializeField]
		private Text _diceValueText;

		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _diceTypeImage;

		[SerializeField]
		private Text _diceAbilityText;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDiceInfo(DiceBehaviour behaviour)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageDice()
		{
			throw null;
		}
	}
}
