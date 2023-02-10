using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using StoryScene;

namespace LOR_XML
{
	public class CharacterEffect
	{
		[XmlAttribute("Effect")]
		public CharacterActivate effect;

		[XmlAttribute("Ratio")]
		public float ratio;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterEffect()
		{
			throw null;
		}
	}
}
