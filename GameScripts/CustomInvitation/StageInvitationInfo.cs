using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class StageInvitationInfo
	{
		[XmlAttribute("Combine")]
		public StageCombineType combine;

		[XmlElement("Book")]
		public List<CustomIdXml> needsBooks;

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
}
