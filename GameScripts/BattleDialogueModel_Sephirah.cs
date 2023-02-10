using System;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BattleDialogueModel_Sephirah : BattleDialogueModel
{
	protected const int _stageId_BS = 60003;

	protected const int _stageId_RB2 = 60004;

	public BattleDialogueModel_Sephirah(BattleDialogCharacter battleDlg)
		: base(battleDlg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg_BS(DialogType dlgType, SephirahType sephirah, string sephirahName)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg_RB2(DialogType dlgType, SephirahType sephirah, string sephirahName)
	{
		throw null;
	}
}
