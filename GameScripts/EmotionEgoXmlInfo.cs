using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class EmotionEgoXmlInfo
{
	[XmlElement("ID")]
	public int id;

	[XmlElement("Sephirah")]
	public SephirahType Sephirah;

	[XmlElement("Card")]
	public int _CardId;

	[XmlElement("LockInBattle")]
	public bool isLock;

	public LorId CardId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmotionEgoXmlInfo()
	{
		throw null;
	}
}
