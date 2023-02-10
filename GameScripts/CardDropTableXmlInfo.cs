using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class CardDropTableXmlInfo
{
	[XmlAttribute("ID")]
	public int _id;

	[XmlIgnore]
	public string workshopId;

	[XmlElement("Card")]
	public List<LorIdXml> _cardIdList;

	[XmlIgnore]
	public List<LorId> cardIdList;

	[XmlIgnore]
	public List<int> _validCardIdList;

	[XmlIgnore]
	public LorId id
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CardDropTableXmlInfo()
	{
		throw null;
	}
}
