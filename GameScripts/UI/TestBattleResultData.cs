using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UI
{
	public class TestBattleResultData
	{
		public List<LorId> loseinvitationbooks;

		public List<DropBookDataForAddedReward> rewardbookdatas;

		public List<LorId> rewardCards;

		public StageModel stagemodelInBattle;

		public List<SephirahType> sephirahOrder;

		public List<BookDropResult> rewardpageResult;

		public bool iswin;

		public SephirahType lastSephirah
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public TestBattleResultData()
		{
			throw null;
		}
	}
}
