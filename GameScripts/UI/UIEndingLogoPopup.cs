using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

namespace UI
{
	public class UIEndingLogoPopup : UIPopup
	{
		[SerializeField]
		private GameObject ob_logovideo_close;

		[SerializeField]
		private VideoPlayer player_close;

		[SerializeField]
		private Animator anim;

		public UICustomSelectable selectable;

		[HideInInspector]
		public bool ingame;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseEndingCredit()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayLogVideo()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEndingLogoPopup()
		{
			throw null;
		}
	}
}
