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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(StageWaveInfo waveInfo)
		{
			
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectEnemyCount(int dropdownIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public WaveInfoSetter()
		{
			throw null;
		}
	}
}
