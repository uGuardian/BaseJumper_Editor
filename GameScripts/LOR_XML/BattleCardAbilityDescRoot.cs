using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class BattleCardAbilityDescRoot
	{
		[XmlElement("BattleCardAbility")]
		public List<BattleCardAbilityDesc> cardDescList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BattleCardAbilityDescRoot()
		{
			throw null;
		}
	}
}
