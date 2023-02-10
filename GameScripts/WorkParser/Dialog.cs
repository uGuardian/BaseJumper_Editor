using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace WorkParser
{
	public class Dialog
	{
		[XmlAttribute("ID")]
		public int ID;

		[XmlAttribute("Model")]
		public string Model;

		[XmlElement("Teller")]
		public string Teller;

		[XmlElement("Title")]
		public string Title;

		[XmlElement("VoiceFile")]
		public string Voice;

		[XmlElement("Content")]
		public string Content;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dialog()
		{
			throw null;
		}
	}
}
