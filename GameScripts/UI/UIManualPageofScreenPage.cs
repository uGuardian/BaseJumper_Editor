﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIManualPageofScreenPage : MonoBehaviour
	{
		[Header("Reference")]
		[SerializeField]
		private CanvasGroup cg;

		[SerializeField]
		private List<UIManualScriptSlot> scriptSlotList;

		public int currentscriptvalue;

		public int maxscriptvalue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenInit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool SetNextScript()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActivePage(bool On)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIManualPageofScreenPage()
		{
			throw null;
		}
	}
}
