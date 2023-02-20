using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIBattleResultEnemySlotList : MonoBehaviour
	{
		[SerializeField]
		private List<UIBattleResultEnemySlot> enemySlotList;

		[HideInInspector]
		public float frameHeight;

		public bool isExistEnemyData;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<UnitBattleDataModel> enemylist)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHideDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetRevealDefault()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartEnemyListReveal()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator RevealEnemyListRoutine()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIBattleResultEnemySlotList()
		{
			throw null;
		}
	}
}
