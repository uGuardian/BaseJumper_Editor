using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class QuestXmlRoot
{
	[XmlElement("Quest")]
	public List<QuestXmlInfo> list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public QuestXmlRoot()
	{
		throw null;
	}
}
