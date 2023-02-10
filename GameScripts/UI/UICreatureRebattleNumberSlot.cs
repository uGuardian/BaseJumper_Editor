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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetKeterFinal(int num, int idx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEmpty()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deactivate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAnimation(bool isShow)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetHighlightColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetDefaultColor()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetGlowColor(Color c)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointetEnter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICreatureRebattleNumberSlot()
		{
			throw null;
		}
	}
}
