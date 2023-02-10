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
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Open()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CloseEndingCredit()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlayLogVideo()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UIEndingLogoPopup()
		{
			throw null;
		}
	}
}
