﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CombatPageRewardsSetter : MonoBehaviour
	{
		[SerializeField]
		private CombatPageSummary _refUI;

		[SerializeField]
		private DropBookCombatPageListViewer _combatPageListViewer;

		[SerializeField]
		private Button _editButton;

		[SerializeField]
		private LayoutGroup _layout;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageSummary> _rewardSummaryList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> GetCombatPageDropList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEditing()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<CustomIdXml> combatPageDropList)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditCombatPageRewards()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetRewards(List<CombatPageSummary> list)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CombatPageRewardsSetter()
		{
			throw null;
		}
	}
}
