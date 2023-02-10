using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CharacterSkinResourceViewer : MonoBehaviour
	{
		[SerializeField]
		private CharacterSkinSummary _ref;

		[SerializeField]
		private LayoutGroup _layout;

		[SerializeField]
		private Button _refreshButton;

		[SerializeField]
		private ToggleGroup _toggleGroup;

		[SerializeField]
		private List<CharacterSkinSummary> _characterSkinList;

		[SerializeField]
		private CanvasGroup _customSkinCanvasGroup;

		[SerializeField]
		private LorCharacterListViewer _lorCharacterList;

		[SerializeField]
		private Toggle _toggleViewLor;

		[SerializeField]
		private Toggle _toggleViewCustom;

		[SerializeField]
		private RawImage _previewImage;

		[SerializeField]
		private Texture2D _defaultTexture;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshCharacterSkin()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleArtworkSummary(string name)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewLorTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewCustomTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CharacterSkinResourceViewer()
		{
			throw null;
		}
	}
}
