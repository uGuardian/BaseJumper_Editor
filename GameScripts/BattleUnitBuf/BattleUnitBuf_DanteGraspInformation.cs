using System;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleUnitBuf_DanteGraspInformation : BattleUnitBuf
{
	private BattleUnitBuf_DanteGraspInformation.Info _result;

	private BattleUnitModel _dante;

	public override BufPositiveType positiveType
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	protected override string keywordId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public override string bufActivatedText
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitBuf_DanteGraspInformation(BattleUnitModel dante)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistHP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override AtkResist GetResistBP(AtkResist origin, BehaviourDetail detail)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Init(BattleUnitModel owner)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundEnd()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string GetAdditionalString()
	{
		throw null;
	}

	public enum Armor
	{
		HP,
		BP
	}

	public class Info
	{
		public BattleUnitBuf_DanteGraspInformation.Armor type;

		public BehaviourDetail detail;

		public AtkResist resist;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Info(BattleUnitBuf_DanteGraspInformation.Armor t, BehaviourDetail d, AtkResist r)
		{
			throw null;
		}
	}
}
