using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class QuestMissionXmlInfo
{
	[XmlAttribute("ID")]
	public int id;

	[XmlAttribute("Goal")]
	public int goal;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestMissionXmlInfo()
	{
		throw null;
	}
}
