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
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitUnits()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStartAfter()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Sleep()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetMapDialogue(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool ExistsWaitingChild()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateChilds()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AwakeChild()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void CreateChild()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnDie()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int GetTakenGuardBreakDamageAdder(int dmg)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards()
	{
		
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleUnitBuf_turnIcon2()
		{
			throw null;
		}
	}
}
