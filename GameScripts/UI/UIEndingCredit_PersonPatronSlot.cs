using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIEndingCredit_PersonPatronSlot : MonoBehaviour
	{
		[SerializeField]
		private List<Text> txt_list;

		[SerializeField]
		private RectTransform rect_parent;

		[SerializeField]
		private UIEndingCredit_BigTitleSlot big_title;

		[SerializeField]
		private Text nameprefab;

		[SerializeField]
		private GameObject spaceprefab;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetText(List<string> patronlist, string bigtitletext = "")
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEndingCredit_PersonPatronSlot()
		{
			throw null;
		}
	}
}
