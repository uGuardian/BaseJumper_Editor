using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class AbnormalityAbilityText
	{
		[XmlAttribute("ID")]
		public string id;

		[XmlArray("AbilityList")]
		[XmlArrayItem("Ability")]
		public List<string> abilityList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AbnormalityAbilityText()
		{
			throw null;
		}
	}
}
