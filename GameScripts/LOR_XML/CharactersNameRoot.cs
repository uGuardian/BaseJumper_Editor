using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class CharactersNameRoot
	{
		[XmlElement("Name")]
		public List<CharacterName> nameList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharactersNameRoot()
		{
			throw null;
		}
	}
}
