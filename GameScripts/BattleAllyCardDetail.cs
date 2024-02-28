using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_DiceSystem;

public class BattleAllyCardDetail
{
	private BattleUnitModel _self;

	private int _maxHand = 10;

	private int _maxDrawHand = 8;

	private List<BattleDiceCardModel> _cardInDeck;

	private List<BattleDiceCardModel> _cardInHand;

	private List<BattleDiceCardModel> _cardInUse;

	private List<BattleDiceCardModel> _cardInDiscarded;

	private List<BattleDiceCardModel> _cardInReserved;

	public int maxHandCount
	{
		get
		{
			return this._maxHand;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<DiceCardXmlInfo> deck)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxHand(int handCount)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMaxDrawHand(int handCount)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsHighlander()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool Exsist6CardsInHand_andCopy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool ExceptHighlanderID(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardToDeck(List<BattleDiceCardModel> cards)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddCardToHand(BattleDiceCardModel card, bool front = false)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardCardsInUse()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustAllCards()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustACard(BattleDiceCardModel card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustACardAnywhere(BattleDiceCardModel card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustCard(int id)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustCard(LorId id)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustCardInHand(int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustCardInHand(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustCardInHand(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ReturnCardInHandToDeck(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustRandomCardInHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ExhaustAllCardsInHand()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustCardInDeck(LorId id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel ExhaustRandomCardInDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawCards(int count)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawCardsAllSpecific(LorId cardId, BattleDiceCardModel exclude = null)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnAllToDeck()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseCard(BattleDiceCardModel card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool SpendCard(BattleDiceCardModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddSoulCard(int emotionLevel)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCard(int cardId, bool front = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCard(LorId cardId, bool front = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddTempCard(int cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddTempCard(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCardToDeck(int cardId, bool front = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCardToDeck(LorId cardId, bool front = false)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCardToDiscarded(int cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel AddNewCardToDiscarded(LorId cardId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnCardToHand(BattleDiceCardModel appliedCard)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardACardByAbility(BattleDiceCardModel card)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardACardByAbility(List<BattleDiceCardModel> cardList)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardACardRandomlyByAbility(int num)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DiscardInHand(int num)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel DisCardACardRandom()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel DiscardACardHighest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel DiscardACardLowest()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetHand()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetDiscarded()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetUse()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<BattleDiceCardModel> GetAllDeck()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDiceCardModel GetRandomCardInHand(Predicate<BattleDiceCardModel> condition = null)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shuffle()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayTurnAutoForEnemy(int currentDiceSlotIdx, int speed)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PlayTurnAutoForPlayer(int idx)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundStart()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnBreakState()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawCard()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseCard(BattlePlayingCardDataInUnitModel curCard)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnLoseParrying(BattleDiceBehavior behavior)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWinParrying(BattleDiceBehavior behavior)
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd_before()
	{

	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRoundEnd()
	{

	}
}
