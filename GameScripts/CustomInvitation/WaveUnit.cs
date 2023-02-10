using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class WaveUnit : MonoBehaviour
	{
		[SerializeField]
		private Dropdown _dropdownEnemyUnit;

		[SerializeField]
		private GameObject _noDataObj;

		private List<WaveUnit.EnemyUnit> _list;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dropdown GetEnemyUnitDropdown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyUnitDropdown(int enemyID)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetEnemyUnitID()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshEnemyUnitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaveUnit()
		{
			throw null;
		}

		public class EnemyUnit
		{
			public int id;

			public string name;

			public int dropdownIdx;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public EnemyUnit()
			{
				throw null;
			}
		}
	}
}
