using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class StageExtraCondition
{
	[XmlElement("Stage")]
	public List<int> needClearStageList;

	[XmlElement("Level")]
	public int needLevel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsUnlocked()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageExtraCondition()
	{
		throw null;
	}
}
