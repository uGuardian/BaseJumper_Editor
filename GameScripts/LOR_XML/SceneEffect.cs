using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_XML
{
	public class SceneEffect
	{
		[XmlElement("Dialogue")]
		public List<DlgEffect> dlgEffectList;

		[XmlElement("CG")]
		public Background cg;

		[XmlElement("storyBranch")]
		public StoryBranch storyBranch;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SceneEffect()
		{
			throw null;
		}
	}
}
