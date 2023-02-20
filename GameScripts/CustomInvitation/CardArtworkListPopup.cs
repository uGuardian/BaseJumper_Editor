using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardArtworkListPopup : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private CombatPageArtworkSummary _ref;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private RawImage _previewImage;

		[SerializeField]
		private Texture2D _defaultTexture;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Button _refreshButton;

		[Header("Runtime")]
		[SerializeField]
		private List<CombatPageArtworkSummary> _combatPageArtworkList;

		private Action<string> _callback;

		private CombatPageArtworkSummary _selectedArtwork;

		private bool _init;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenPopup(Action<string> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Activate(bool enable)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void InitArtworks()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshArtworkResources()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneArtworkSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelArtworkSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleArtworkSummary(CombatPageArtworkSummary summary)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardArtworkListPopup()
		{
			throw null;
		}
	}
}
