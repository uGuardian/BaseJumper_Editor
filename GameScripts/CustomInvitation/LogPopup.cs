using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class LogPopup : MonoBehaviour
	{
		[SerializeField]
		private Text _logTitle;

		[SerializeField]
		private Text _logDesc;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LogPopup()
		{
			throw null;
		}
	}
}
