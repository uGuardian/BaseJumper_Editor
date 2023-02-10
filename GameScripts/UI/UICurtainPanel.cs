using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI
{
	public class UICurtainPanel : UIPanel
	{
		[Header("Frame Colors")]
		public Color DefaultColor;

		public Color RedColor;

		public Color DisabledColor;

		[Header("Slots")]
		public UICurtainSlot[] slots;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICurtainPanel()
		{
			throw null;
		}
	}
}
