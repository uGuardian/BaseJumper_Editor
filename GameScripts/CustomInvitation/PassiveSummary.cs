using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class PassiveSummary : MonoBehaviour
	{
		[SerializeField]
		private Color[] _rarityColor;

		[SerializeField]
		private Text _passiveCostText;

		[SerializeField]
		private Text _passiveNameText;

		[SerializeField]
		private Text _passiveDescText;

		[SerializeField]
		private Toggle _toggle;

		private int _passiveId;

		public int PassiveId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<PassiveSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetPassiveInfo(PassiveXmlInfo passiveXmlInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveSummary()
		{
			throw null;
		}
	}
}
