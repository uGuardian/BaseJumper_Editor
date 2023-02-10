using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EmotionEgoXmlRoot
{
	[XmlElement("EmotionEgo")]
	public List<EmotionEgoXmlInfo> egoXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionEgoXmlRoot()
	{
		throw null;
	}
}
