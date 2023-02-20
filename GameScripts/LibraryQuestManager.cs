using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class LibraryQuestManager : Singleton<LibraryQuestManager>
{
	private List<QuestModel> _questsInProgress;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterQuest(QuestModel quest)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregietrQuest(QuestModel quest)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnWaveStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStageStart()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnUseBook(SephirahType sephirah, LorId bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnGetBook(LorId bookId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomize()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCustomizeSpeech(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditFormation(SephirahType sephirah)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEquipBook(SephirahType sephirah, UnitDataModel unit, BookModel book)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSendInvitation(LorId stageId)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnClearStage(StageModel stage)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnWinWave(StageLibraryFloorModel floor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEmotionLevelUp(BattleUnitModel unit, int level)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnSelectEmotionCard(EmotionCardXmlInfo selected)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCard(BattlePlayingCardDataInUnitModel card)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnBreak()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGetGift()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnEditCard()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnUseCoreEquip()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LibraryQuestManager()
	{
		throw null;
	}
}
