using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceAbility : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rect;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Text _idText;

		[SerializeField]
		private Text _abilityText;

		private string _abilityID;

		public Toggle toggle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAbilityID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAbilityText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string id, string text)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceAbility()
		{
			throw null;
		}
	}
}
