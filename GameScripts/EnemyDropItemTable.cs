using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EnemyDropItemTable
{
	[XmlAttribute("Level")]
	public int emotionLevel;

	[XmlElement("DropItem")]
	public List<EnemyDropItem> dropItemList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EnemyDropItemTable()
	{
		throw null;
	}
}
