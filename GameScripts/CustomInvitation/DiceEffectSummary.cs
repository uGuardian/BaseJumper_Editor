using System;
using System.Runtime.CompilerServices;
using Battle.DiceAttackEffect;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceEffectSummary : MonoBehaviour
	{
		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Text _effectNameText;

		[SerializeField]
		private Image _seletedBeforeImage;

		private DiceAttackEffect _effect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelectedBeforeImg(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetEffectName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAttackEffect GetEffect()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(DiceAttackEffect effect, Action<DiceEffectSummary> toggleCallback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceEffectSummary()
		{
			throw null;
		}
	}
}
