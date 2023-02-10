using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class DlgEffect
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlElement("Bg")]
		public Background bg;

		[XmlElement("Filter")]
		public Filter filter;

		[XmlElement("Bgm")]
		public Bgm bgm;

		[XmlArray("CharacterList")]
		[XmlArrayItem("Character")]
		public List<Character> characterList;

		[XmlElement("EffectSound")]
		public List<string> effectSounds;

		[XmlElement("BgChangeState")]
		public StoryBgChangeAnim bgChangeState;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DlgEffect()
		{
			throw null;
		}
	}
}
