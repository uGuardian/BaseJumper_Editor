using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace UI
{
	public class UILibraryLevelUpPanel : UIPopup
	{
		private static UILibraryLevelUpPanel instance;

		[Header("Reference")]
		public UICustomSelectablePanel selectablePanel;

		[SerializeField]
		private TextMeshProUGUI nextChapter;

		[SerializeField]
		private TextMeshProUGUI backnextChapter;

		[SerializeField]
		private Animator revealAnim;

		private bool isVibe;

		public static UILibraryLevelUpPanel _instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetData()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLevelupPanel()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckPassiveSuccesionAlarm()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClickLevelupPanel(bool Openfloor)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartVibe()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EndVibe()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public UILibraryLevelUpPanel()
		{
			throw null;
		}
	}
}
