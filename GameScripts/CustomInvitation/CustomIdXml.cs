using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class CustomIdXml
	{
		[XmlText]
		public int id;

		[XmlAttribute("Pid")]
		public string pid;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CustomIdXml()
		{
			throw null;
		}
	}
}
