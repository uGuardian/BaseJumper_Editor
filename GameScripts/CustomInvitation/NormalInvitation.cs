using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class NormalInvitation
	{
		[XmlElement("Version")]
		public string version;

		[XmlElement("Workshop")]
		public WorkshopInfo workshopInfo;

		[XmlElement("InvitationFile")]
		public InvitationFile fileInfo;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public NormalInvitation()
		{
			throw null;
		}
	}
}
