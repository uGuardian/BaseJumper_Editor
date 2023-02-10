using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class DiceTypeSetter : MonoBehaviour
	{
		private const string _TYPE_ATK = "Atk";

		private const string _TYPE_DEF = "Def";

		private const string _TYPE_STANDBY = "Standby";

		private const string _DETAIL_SLASH = "Slash";

		private const string _DETAIL_PENETRATE = "Penetrate";

		private const string _DETAIL_HIT = "Hit";

		private const string _DETAIL_GUARD = "Guard";

		private const string _DETAIL_EVASION = "Evasion";

		private const string _MOTION_J = "J";

		private const string _MOTION_H = "H";

		private const string _MOTION_Z = "Z";

		private const string _MOTION_G = "G";

		private const string _MOTION_E = "E";

		private const string _MOTION_F = "F";

		private const string _MOTION_S1 = "S1";

		private const string _MOTION_S2 = "S2";

		private const string _MOTION_S3 = "S3";

		[SerializeField]
		private ToggleGroupEventHandler _toggleGroupHandler;

		[SerializeField]
		private Dropdown _dropdownDetail;

		[SerializeField]
		private Dropdown _dropdownMotion;

		private BehaviourType _diceType;

		private BehaviourDetail _diceDetail;

		private MotionDetail _diceMotion;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDiceType(BehaviourType bType)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BehaviourType GetDiceType()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDiceDetail(BehaviourDetail bDetail)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BehaviourDetail GetDiceDetail()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMotionDetail(MotionDetail bMotionDetail)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public MotionDetail GetMotionDetail()
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
		private void ToggleDiceType(Toggle active)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeDetailDropdownOptions(BehaviourType type)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectDetail(int detailIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectMotion(int motionIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceTypeSetter()
		{
			throw null;
		}
	}
}
