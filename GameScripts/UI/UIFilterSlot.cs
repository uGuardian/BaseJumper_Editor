using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
	public class UIFilterSlot : MonoBehaviour
	{
		[Header("Reference")]
		public Toggle toggle_object;

		[SerializeField]
		protected Image img_icon;

		[SerializeField]
		protected Image img_iconGlow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(int idx)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIFilterSlot()
		{
			throw null;
		}
	}
}
