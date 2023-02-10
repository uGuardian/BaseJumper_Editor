using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class FloorLevelXmlInfo
{
	[XmlElement("Sephirah")]
	public SephirahType sephirahType;

	[XmlElement("Level")]
	public int level;

	[XmlElement("Stage")]
	public int stageId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FloorLevelXmlInfo()
	{
		throw null;
	}
}
