﻿using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace StoryScene
{
	public class StoryChapterStartProloguePanel : MonoBehaviour
	{
		[Header("Reference")]
		public Animator revealAnim;

		[SerializeField]
		private TextMeshProUGUI txt_Prologue;

		[SerializeField]
		private TextMeshProUGUI txt_currentact;

		[SerializeField]
		private TextMeshProUGUI txt_gradetxt;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(string title, int act)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CheckIsRunningReveal()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StoryChapterStartProloguePanel()
		{
			throw null;
		}
	}
}
