using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LOR_XML;

public class BattleDialogueModel_Librarian : BattleDialogueModel
{
	protected static List<int> librarianIndex;

	protected int _index;

	protected SephirahType _sephirahType;

	protected string _floorName_RB1;

	protected string _characterId_RB1;

	protected int _stageId_RB1;

	protected const int _stageId_BS = 60003;

	protected string _characterId_BS;

	protected const int _stageId_RB2 = 60004;

	protected string _characterId_RB2;

	private Dictionary<DialogType, List<BattleDialog>> _dlgDictionaryInBattle;

	public BattleDialogueModel_Librarian(BattleDialogCharacter battleDlg)
		: base(battleDlg)
	{}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string GetBattleDlg(DialogType dlgType)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string GetBattleDlg_BS(DialogType dlgType, SephirahType sephirah, string sephirahName)
	{
		throw null;
	}

	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BattleDialogueModel_Librarian()
	{
		throw null;
	}
}
