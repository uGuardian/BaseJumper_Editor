using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class KeyPageDialog : MonoBehaviour
	{
		[SerializeField]
		private InputField _inputField;

		[SerializeField]
		private Button _deleteButton;

		private KeyPageDialogSetter _setter;

		private DialogType _type;

		public DialogType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(KeyPageDialogSetter setter, DialogType type, string text)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnclickDeleteButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEditDialog(string str)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyPageDialog()
		{
			throw null;
		}
	}
}
