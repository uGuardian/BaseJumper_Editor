using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EmotionCardXmlRoot
{
	[XmlElement("EmotionCard")]
	public List<EmotionCardXmlInfo> emotionCardXmlList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionCardXmlRoot()
	{
		throw null;
	}
}
