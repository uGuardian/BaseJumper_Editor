using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UIRewardDropBookList : UIOriginBookList
	{
		[Header("---Child---")]
		[SerializeField]
		private CanvasGroup cg;

		[Header("Scroll")]
		[SerializeField]
		private RectTransform viewPort;

		[SerializeField]
		private RectTransform content;

		private Vector2 viewPortOriginSize;

		private Vector2 viewPortWideSize;

		private float lineheight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetActiveList(bool on)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(List<LorId> bookids)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetViewPortSize(bool origin)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetContentSize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIRewardDropBookList()
		{
			throw null;
		}
	}
}
