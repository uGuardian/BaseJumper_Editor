using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class EnemyUnitInfoSummary : MonoBehaviour
	{
		[SerializeField]
		private Text _textEnemyName;

		[SerializeField]
		private Text _textEnemyId;

		[SerializeField]
		private Toggle _toggle;

		private int _enemyUnitID;

		public int enemyUnitID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<EnemyUnitInfoSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnemyUnitInfo(EnemyUnitClassInfo data)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitInfoSummary()
		{
			throw null;
		}
	}
}
