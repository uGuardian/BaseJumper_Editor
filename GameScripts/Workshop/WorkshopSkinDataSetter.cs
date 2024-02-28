using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Workshop
{
	[RequireComponent(typeof(CharacterAppearance))]
	public class WorkshopSkinDataSetter : MonoBehaviour
	{
		public Dictionary<ActionDetail, ClothCustomizeData> dic;

		private Dictionary<ActionDetail, WorkshopSkinDataSetter.PartRenderer> parts;

		private CharacterAppearance _appearance;

		private Transform _front;

		private Transform _rear;

		private Transform _head;

		public CharacterAppearance Appearance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(Dictionary<ActionDetail, ClothCustomizeData> data)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData(WorkshopSkinData data)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LateInit()
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetMotionData(ActionDetail motion, ClothCustomizeData data)
		{

		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOrder(CustomizedAppearance ca)
		{

		}

		public class PartRenderer
		{
			public ActionDetail action;

			public SpriteRenderer front;

			public SpriteRenderer rear;

			[MethodImpl(MethodImplOptions.NoInlining)]
			public PartRenderer()
			{
				throw null;
			}
		}
	}
}
