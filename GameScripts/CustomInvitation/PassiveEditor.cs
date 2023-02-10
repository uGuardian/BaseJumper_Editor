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
		private void SetData(PassiveXmlInfo passiveInfo)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DonePassiveSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PassiveDone()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelPassiveSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnClickPassiveSearchButton()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetPassiveScript(string scriptName)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PassiveEditor()
		{
			throw null;
		}
	}
}
