﻿using System;
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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void InitData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickCancel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnClickOK()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICustomPanel()
		{
			throw null;
		}
	}
}
