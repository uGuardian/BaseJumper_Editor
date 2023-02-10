using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class AbnormalityCard
	{
		[XmlAttribute("ID")]
		public string id;

		[XmlElement("Abnormality")]
		public string abnormalityName;

		[XmlElement("CardName")]
		public string cardName;

		[XmlElement("AbilityDesc")]
		public string abilityDesc;

		[XmlElement("FlaborText")]
		public string flavorText;

		[XmlArray("Dialogues")]
		[XmlArrayItem(typeof(AbnormalityCardDialog), ElementName = "Dialogue")]
		public List<AbnormalityCardDialog> dialogues;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AbnormalityCard()
		{
			throw null;
		}
	}
}
