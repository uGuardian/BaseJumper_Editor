using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIDetailCardDescSlot : MonoBehaviour
	{
		[Header("Reference")]
		public Image img_detail;

		public TextMeshProUGUI txt_ability;

		public TextMeshProUGUI txt_range;

		[Header("Colors")]
		[SerializeField]
		private Color[] refsColors_FaceColor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBehaviourInfo(DiceBehaviour behaviour, LorId cardId, List<DiceBehaviour> behaviourList, bool isHide = false)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText(DiceBehaviour behaviour)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIDetailCardDescSlot()
		{
			throw null;
		}
	}
}
