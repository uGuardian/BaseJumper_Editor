using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_901011 : PassiveAbilityBase
{
	private int _childUnitId;

	private bool _isActivated;

	private List<PassiveAbility_901011.CreatureChildInfo> _childrenList;

	private int _nextAwakeUnitIndex;

	private int _awakeRemainTurnCount;

	private bool _existsChild;

	private bool _startCreate;

	public override bool isTargetable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override bool isActionable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int SpeedDiceNumAdder()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUnits()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Sleep()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapDialogue(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistsWaitingChild()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateChilds()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AwakeChild()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChild()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetTakenGuardBreakDamageAdder(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_901011()
	{
		throw null;
	}

	private class CreatureChildInfo
	{
		public int id;

		public int posIdx;

		public BattleUnitModel unit;

		public PassiveAbility_901021 passive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CreatureChildInfo()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_turnIcon : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_turnIcon()
		{
			throw null;
		}
	}

	public class BattleUnitBuf_turnIcon2 : BattleUnitBuf
	{
		protected override string keywordId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRoundEnd()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_turnIcon2()
		{
			throw null;
		}
	}
}
