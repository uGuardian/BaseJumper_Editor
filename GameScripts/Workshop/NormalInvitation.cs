using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workshop
{
	public class NormalInvitation
	{
		[XmlElement("Workshop")]
		public WorkshopInfo workshopInfo;

		[XmlElement("InvitationFile")]
		public InvitationFile fileInfo;

		[XmlElement("Version")]
		public string version;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NormalInvitation()
		{
			throw null;
		}
	}
}
