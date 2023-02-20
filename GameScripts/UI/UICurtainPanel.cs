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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Initialize()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UICurtainPanel()
		{
			throw null;
		}
	}
}
