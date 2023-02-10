using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class FileInfo
	{
		[XmlAttribute("Exist")]
		public bool isFileExist;

		[XmlElement("Path")]
		public string relativePath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public FileInfo()
		{
			throw null;
		}
	}
}
