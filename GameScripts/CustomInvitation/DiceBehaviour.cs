using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace CustomInvitation
{
	public class DiceBehaviour
	{
		[XmlAttribute("Min")]
		public int min;

		[XmlAttribute("Dice")]
		public int max;

		[XmlAttribute("Type")]
		public BehaviourType type;

		[XmlAttribute("Detail")]
		public BehaviourDetail detail;

		[XmlAttribute("Motion")]
		public MotionDetail motionDetail;

		[XmlAttribute("MotionDefault")]
		public MotionDetail MotionDetailDefault;

		[XmlAttribute("EffectRes")]
		public string effectRes;

		[XmlAttribute("Script")]
		public string script;

		[XmlAttribute]
		public string ActionScript;

		[XmlAttribute]
		public string Desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceBehaviour()
		{
			throw null;
		}
	}
}
