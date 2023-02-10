using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class CardBehaviourDesc
	{
		[XmlAttribute("ID")]
		public int behaviourID;

		[XmlText]
		public string behaviourDesc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardBehaviourDesc()
		{
			throw null;
		}
	}
}
