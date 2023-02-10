using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Opening
{
	public class GameOpeingSubtitleRoot
	{
		[XmlElement("subtitle")]
		public List<SubtitleObject> subtitles;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSubtitles(List<GameOpeningController.Subtitle> list)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GameOpeingSubtitleRoot()
		{
			throw null;
		}
	}
}
