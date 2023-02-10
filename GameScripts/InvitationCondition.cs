using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class InvitationCondition
{
	public InvitationConditionType type;

	public List<int> bookClassInfoIdList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public InvitationCondition()
	{
		throw null;
	}
}
