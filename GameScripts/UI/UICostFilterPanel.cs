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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<int> data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnChangeFilter()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnclickName()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnterName()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnExitName()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> CheckCostFilter()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFontDefaultAlpha()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnXEvent()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICostFilterPanel()
		{
			throw null;
		}
	}
}
