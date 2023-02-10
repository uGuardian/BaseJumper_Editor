using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using StoryScene;

namespace LOR_XML
{
	public class Character
	{
		[XmlAttribute("Name")]
		public string name;

		[XmlAttribute("Face")]
		public string face;

		[XmlAttribute("Body")]
		public string body;

		[XmlAttribute("Pos")]
		public CharacterPos pos;

		[XmlAttribute("Emotion")]
		public string emotion;

		[XmlAttribute("Telling")]
		public bool telling;

		[XmlElement("Active")]
		public CharacterEffect activeEffect;

		[XmlElement("Deactive")]
		public CharacterEffect deactiveEffect;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Character()
		{
			throw null;
		}
	}
}
