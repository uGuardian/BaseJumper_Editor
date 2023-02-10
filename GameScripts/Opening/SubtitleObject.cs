using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Opening
{
	public class SubtitleObject
	{
		[XmlAttribute("id")]
		public int id;

		[XmlAttribute("display")]
		public float displayTime;

		[XmlAttribute("duration")]
		public float duration;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SubtitleObject()
		{
			throw null;
		}
	}
}
