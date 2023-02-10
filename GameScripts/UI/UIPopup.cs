using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIPopup : MonoBehaviour
	{
		protected UICustomSelectable prevSelectable;

		protected UIController Controller
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool IsOpened()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIPopup()
		{
			throw null;
		}
	}
}
