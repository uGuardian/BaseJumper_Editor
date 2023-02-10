using System;
using System.Runtime.CompilerServices;

public class BattleDialogWithCreatureBattle : Singleton<BattleDialogWithCreatureBattle>
{
	private BattleDialogWithCreatureBattle.ReserveInfo[] info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public string ReserveID(BattleUnitModel model)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleDialogWithCreatureBattle()
	{
		throw null;
	}

	public class ReserveInfo
	{
		public string str;

		public BattleUnitModel talker;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ReserveInfo(string s)
		{
			throw null;
		}
	}
}
