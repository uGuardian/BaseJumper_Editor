using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class WaveInfoSetter : MonoBehaviour
	{
		[SerializeField]
		private List<WaveUnit> _waveUnitList;

		[SerializeField]
		private Dropdown _dropdownAvailableUnit;

		[SerializeField]
		private Dropdown _dropdownEnemyCount;

		[SerializeField]
		private Image _nonUsingImage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableWave(bool waveOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(StageWaveInfo waveInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public List<int> GetEnemyUnitList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetAvailableUnitCount()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectEnemyCount(int dropdownIdx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaveInfoSetter()
		{
			throw null;
		}
	}
}
