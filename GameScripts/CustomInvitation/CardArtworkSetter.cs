using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class CardArtworkSetter : MonoBehaviour
	{
		[SerializeField]
		private Button _loadButton;

		[SerializeField]
		private RawImage _artworkPreview;

		[SerializeField]
		private Texture2D _defaultTex;

		[SerializeField]
		private Text _previewText;

		[SerializeField]
		private CardArtworkListPopup _listPopup;

		private string _artworkName;

		private string _artworkFullPath;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsEditingArtwork()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetArtworkName(string name)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetArtworkName()
		{
			throw null;
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
		private void OpenArtworkPopup()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadArtwork()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetArtworkPath(string fullPath)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public CardArtworkSetter()
		{
			throw null;
		}
	}
}
