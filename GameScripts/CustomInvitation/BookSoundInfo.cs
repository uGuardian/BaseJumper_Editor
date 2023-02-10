using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using LOR_DiceSystem;

namespace CustomInvitation
{
	public class BookSoundInfo
	{
		[XmlAttribute("Motion")]
		public MotionDetail motion;

		[XmlAttribute("WinExternal")]
		public bool isWinExternal;

		[XmlAttribute("Win")]
		public string winSound;

		[XmlAttribute("LoseExternal")]
		public bool isLoseExternal;

		[XmlAttribute("Lose")]
		public string loseSound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public BookSoundInfo()
		{
			throw null;
		}
	}
}
