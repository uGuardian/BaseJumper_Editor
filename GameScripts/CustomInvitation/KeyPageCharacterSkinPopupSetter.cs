using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageCharacterSkinPopupSetter : MonoBehaviour
	{
		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private Toggle _toggleViewLorSkin;

		[SerializeField]
		private Toggle _toggleViewCustomSkin;

		[SerializeField]
		private LorCharacterListViewer _lorCharacterViewer;

		[SerializeField]
		private CustomCharacterListViewer _customCharacterViewer;

		[SerializeField]
		private RawImage _previewTexture;

		[SerializeField]
		private Image _previewBg;

		[SerializeField]
		private Texture2D _defaultPreviewTex;

		[SerializeField]
		private Slider _slider;

		private Action<Texture, string, string> _callback;

		private string _skinType;

		private string _skinName;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenSkinSetterWindow(Action<Texture, string, string> callback)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewCustomTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleViewLorTab(bool isOn)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectLorCharacterSkin(object data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SelectCustomCharacterSkin(object data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangePreviewBgColor(float value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneSkinSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelSkinSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetSkinInfo(string skinName, string skinType)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageCharacterSkinPopupSetter()
		{
			throw null;
		}
	}
}
