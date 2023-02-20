using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICreatureRebattleSephirahSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private List<UICreatureRebattleNumberSlot> numList;

		[SerializeField]
		private Image sephirahIcon;

		[SerializeField]
		private Animator keterFinalFrame;

		[SerializeField]
		private TextMeshProUGUI txt_sepText;

		[Header("KeterFinal")]
		[SerializeField]
		private List<UICreatureRebattleNumberSlot> keterfinalNumList;

		[Header("Controller")]
		public UICustomSelectable selectable;

		public SephirahType sephirah;

		private const int bloodBathPhase = 210005;

		private const int heartPhase = 210006;

		private const int pinocchioPhase = 210007;

		private const int snowQueenPhase = 210008;

		private const int silentGirlPhase = 210009;

		private bool isKeterFinalOpen;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActive(bool b)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClicketerFinal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICreatureRebattleSephirahSlot()
		{
			throw null;
		}
	}
}
