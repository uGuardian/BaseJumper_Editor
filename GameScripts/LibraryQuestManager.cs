using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class LibraryQuestManager : Singleton<LibraryQuestManager>
{
	private List<QuestModel> _questsInProgress;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterQuest(QuestModel quest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregietrQuest(QuestModel quest)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWaveStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStageStart()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseBook(SephirahType sephirah, LorId bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGetBook(LorId bookId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomizeSpeech(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditFormation(SephirahType sephirah)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEquipBook(SephirahType sephirah, UnitDataModel unit, BookModel book)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSendInvitation(LorId stageId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnClearStage(StageModel stage)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinWave(StageLibraryFloorModel floor)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEmotionLevelUp(BattleUnitModel unit, int level)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSelectEmotionCard(EmotionCardXmlInfo selected)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBreak()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGetGift()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditCard()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCoreEquip()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LibraryQuestManager()
	{
		throw null;
	}
}
