using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EmotionSetInfo
{
	[XmlAttribute("Level")]
	public int level;

	[XmlAttribute("State")]
	public MentalState state;

	[XmlText]
	public int emotionId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionSetInfo()
	{
		throw null;
	}
}
