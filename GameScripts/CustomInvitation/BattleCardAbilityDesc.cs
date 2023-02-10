using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class BattleCardAbilityDesc
	{
		[XmlAttribute("ID")]
		public string id;

		[XmlElement("Desc")]
		public List<string> desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCardAbilityDesc()
		{
			throw null;
		}
	}
}
