using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class BookSoulCardInfo
{
	[XmlText]
	public int cardId;

	[XmlAttribute("Level")]
	public int requireLevel;

	[XmlAttribute("Emotion")]
	public int emotionLevel;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BookSoulCardInfo()
	{
		throw null;
	}
}
