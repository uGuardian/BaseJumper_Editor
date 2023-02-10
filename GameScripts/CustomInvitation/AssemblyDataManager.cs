using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CustomInvitation
{
	public class AssemblyDataManager
	{
		private static AssemblyDataManager _instance;

		private List<string> _passiveScripts;

		private List<string> _diceAbilityScripts;

		private List<string> _cardSelfAbilityScripts;

		private Dictionary<string, string> _abilityDescs;

		public static AssemblyDataManager Instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected AssemblyDataManager()
		{
			throw null;
		}

		public List<string> DiceAbilityScripts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<string> CardSelfAbilityScripts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public List<string> PassiveScripts
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public Dictionary<string, string> AbilityDescs
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetAbilityDescription(string id)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReloadDll(string dllDirectory)
		{
			
		}
	}
}
