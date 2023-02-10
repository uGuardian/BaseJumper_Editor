using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class CharacterName
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlText]
		public string name;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterName()
		{
			throw null;
		}
	}
}
