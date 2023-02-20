using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class PassiveScript : MonoBehaviour
	{
		[SerializeField]
		private Text _text;

		[SerializeField]
		private Toggle _toggle;

		public string scriptName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Toggle toggle
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string scriptName)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveScript()
		{
			throw null;
		}
	}
}
