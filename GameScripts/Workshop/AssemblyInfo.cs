using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workshop
{
	public class AssemblyInfo
	{
		[XmlElement("File")]
		public List<string> assemblies;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public AssemblyInfo()
		{
			throw null;
		}
	}
}
