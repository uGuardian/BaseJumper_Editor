using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace LOR_DiceSystem
{
	public class DiceBehaviour
	{
		[XmlAttribute]
		public int Min;

		[XmlAttribute]
		public int Dice;

		[XmlAttribute]
		public BehaviourType Type;

		[XmlAttribute]
		public BehaviourDetail Detail;

		[XmlAttribute("Motion")]
		public MotionDetail MotionDetail;

		[XmlAttribute("MotionDefault")]
		public MotionDetail MotionDetailDefault;

		[XmlIgnore]
		public int KnockbackPower;

		[XmlAttribute]
		public string EffectRes;

		[XmlAttribute]
		public string Script;

		[XmlAttribute]
		public string ActionScript;

		[XmlAttribute]
		public string Desc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetMinText()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetMaxText()
		{
			throw null;
		}

		[XmlIgnore]
		public RWBPType Rwbp
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceBehaviour Copy()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public DiceBehaviour()
		{
			throw null;
		}
	}
}
