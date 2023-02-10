using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class PassiveEditor : MonoBehaviour
	{
		[SerializeField]
		private InputField _nameInput;

		[SerializeField]
		private Dropdown _rarityDropdown;

		[SerializeField]
		private InputField _costInput;

		[SerializeField]
		private InputField _scriptInput;

		[SerializeField]
		private Button _scriptSearchButton;

		[SerializeField]
		private PassiveScriptPresetViewer _scriptPresetViewer;

		[SerializeField]
		private InputField _descInput;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		private bool _isNew;

		private Action _callback;

		private PassiveXmlInfo _curPassive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(PassiveXmlInfo passiveInfo, Action callback, bool isNew)
		{
			throw null;
		}

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
		private void SetData(PassiveXmlInfo passiveInfo)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DonePassiveSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PassiveDone()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelPassiveSetting()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnClickPassiveSearchButton()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPassiveScript(string scriptName)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveEditor()
		{
			throw null;
		}
	}
}
