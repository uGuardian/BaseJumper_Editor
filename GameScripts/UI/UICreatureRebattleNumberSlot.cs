using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UICreatureRebattleNumberSlot : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private GameObject rect_data;

		[SerializeField]
		private Image img_frame;

		[SerializeField]
		private Image img_glow;

		[SerializeField]
		private TextMeshProUGUI txt_number;

		[SerializeField]
		private TextMeshProUGUI text_name;

		[SerializeField]
		private GameObject rect_empty;

		[SerializeField]
		private Animator anim;

		public UICustomSelectable selectable;

		public SephirahType sephirah;

		private int stageNum;

		private bool isFinalBattle;

		private bool isKeterFinal;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(SephirahType sep, int num, bool isFinal)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKeterFinal(int num, int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimation(bool isShow)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlightColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDefaultColor()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGlowColor(Color c)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointetEnter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICreatureRebattleNumberSlot()
		{
			throw null;
		}
	}
}
