using System;
using System.Runtime.CompilerServices;

public class EmotionCardAbility_galaxyChild : EmotionCardAbilityBase
{
	private const int _targetNum = 3;

	private const int _recoverMin = 3;

	private const int _recoverMax = 7;

	private const int _loseMin = 1;

	private const int _loseMax = 3;

	private const string _icon = "GalaxyBoy_Stone";

	private static int Recover
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private static int Lose
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
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
	public override void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardAbility_galaxyChild()
	{
		throw null;
	}

	public class GalaxyChildPebbleBuf : BattleDiceCardBuf
	{
		protected override string keywordIconId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GalaxyChildPebbleBuf()
		{
			throw null;
		}
	}
}
