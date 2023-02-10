using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UI.Title
{
	public class UITitleButtonSlot : MonoBehaviour
	{
		private ButtonState _state;

		public TitleActionType type;

		[SerializeField]
		private _2dxFX_HSV hsv_DefaultIcon;

		public Animator ActionButtonAnim;

		public UICustomSelectable IconSelectable;

		public GameObject BoxRect;

		public ButtonState State
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetButtonIconHsv(Vector3 hsvValue)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(ButtonState state)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnSelectIcon()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerDown()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UITitleButtonSlot()
		{
			throw null;
		}
	}
}
