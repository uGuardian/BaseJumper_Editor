using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace UI
{
	public class UICostFilterPanel : MonoBehaviour
	{
		[SerializeField]
		private List<UICostFilterSlot> costSlots;

		[SerializeField]
		private TextMeshProUGUI txt_name;

		[SerializeField]
		private Animator textanim;

		[SerializeField]
		private UICustomSelectable parentSelectablePanel;

		[SerializeField]
		private UnityEvent onChangeEvent;

		[SerializeField]
		private UnityEvent onXEvent;

		[Header("ref")]
		[SerializeField]
		private int minCost;

		[SerializeField]
		private int maxCost;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialized()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<int> data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnclickName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitName()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> CheckCostFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFontDefaultAlpha()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICostFilterPanel()
		{
			throw null;
		}
	}
}
