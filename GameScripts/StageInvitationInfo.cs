using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class StageInvitationInfo
{
	[XmlAttribute("Combine")]
	public StageCombineType combine;

	[XmlElement("Book")]
	public List<LorIdXml> _needsBooks;

	[XmlIgnore]
	public List<LorId> needsBooks;

	[XmlElement("Value")]
	public float bookValue;

	[XmlElement("Num")]
	public int bookNum;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public StageInvitationInfo()
	{
		throw null;
	}
}
