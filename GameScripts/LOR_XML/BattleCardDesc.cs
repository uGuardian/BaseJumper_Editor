using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleCardDesc
	{
		[XmlAttribute("ID")]
		public int cardID;

		[XmlElement("LocalizedName")]
		public string cardName;

		[XmlElement("Ability")]
		public string ability;

		[XmlElement("Behaviour")]
		public List<CardBehaviourDesc> behaviourDescList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCardDesc()
		{
			throw null;
		}
	}
}
