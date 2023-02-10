using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICustomPanel : MonoBehaviour
	{
		private UICustomizePopup _parent;

		public UICustomizePopup Parent
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CustomizingSavedData Origindata
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		public CustomizingSavedData PreviewData
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Init(UICustomizePopup parent)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitData()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickCancel()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickOK()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomPanel()
		{
			throw null;
		}
	}
}
