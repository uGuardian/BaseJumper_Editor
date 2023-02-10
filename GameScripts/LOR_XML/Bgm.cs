using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using StoryScene;

namespace LOR_XML
{
	public class Bgm
	{
		[XmlAttribute("Src")]
		public string src;

		[XmlAttribute("Effect")]
		public BgmMode newBgmMode;

		[XmlAttribute("PrevBgm")]
		public BgmMode prevBgmMode;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Bgm()
		{
			throw null;
		}
	}
}
