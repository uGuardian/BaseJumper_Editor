using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class QuestXmlInfo
{
	[XmlAttribute("ID")]
	public int id;

	[XmlElement("Level")]
	public int level;

	[XmlElement("Sephirah")]
	public SephirahType sephirah;

	[XmlElement("Mission")]
	public List<QuestMissionXmlInfo> missionList;

	[XmlElement("Story")]
	public string story;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestXmlInfo()
	{
		throw null;
	}
}
