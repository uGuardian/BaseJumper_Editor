using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PassiveAbility_1410011 : PassiveAbilityBase
{
	private const int _ALLEGRO_ID = 704011;

	private const int _LARGO_ID = 704012;

	private const int _DANZA_ID = 704014;

	private const int _BLUE_ATTACK_ID = 704001;

	private const int _CARD_NEW_ID = 707001;

	private const int _CARD_DMG_ID = 707002;

	private const int _CARD_NOPOWER_ID = 707003;

	private const int _CARD_ATK_ID = 707004;

	private const int _DANZA_NEW_ID = 707011;

	private const int _CARD_FINAL_AREA_ID = 707012;

	private Queue<int> _addCardQueue;

	private int _cooltimeFinalAtk;

	private int _pattern;

	private PassiveAbility_1410011.PatternState _curState;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnRoundStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_normalPattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCards_finalPattern()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddNewCard(int cardId, int priorityAdder, int costAdder)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public PassiveAbility_1410011()
	{
		throw null;
	}

	private enum PatternState
	{
		Normal,
		Final
	}
}
