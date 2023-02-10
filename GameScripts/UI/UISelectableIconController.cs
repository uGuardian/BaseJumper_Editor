using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UISelectableIconController : MonoBehaviour
	{
		[SerializeField]
		private List<GameObject> Icons;

		[SerializeField]
		private List<GameObject> Replaces;

		[SerializeField]
		private List<UISelectableIconController> parentController;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowIcon()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideIcon()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetIcon(GameObject go)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetParent(List<UISelectableIconController> parent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UISelectableIconController()
		{
			throw null;
		}
	}
}
