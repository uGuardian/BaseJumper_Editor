using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class BattleCardBehaviourStack
{
	public List<BattleDiceBehaviourUI> StartBehaviours;

	public bool setStartBehavior;

	public List<BattleDiceBehaviourUI> BeforeActionBehaviours;

	public bool setBeforeBehavior;

	public List<BattleDiceBehaviourUI> EndBehaviours;

	public bool setEndBehavior;
}
