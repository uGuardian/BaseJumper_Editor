using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class AbnormalityAbilityRoot
	{
		[XmlElement("Abnormality")]
		public List<AbnormalityAbilityText> abnormalityList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AbnormalityAbilityRoot()
		{
			throw null;
		}
	}
}
