using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StageInfoEditor : MonoBehaviour
	{
		[SerializeField]
		private InputField _inputStageName;

		[SerializeField]
		private Dropdown _dropdownBookCount;

		[SerializeField]
		private Dropdown _dropdownChapter;

		[SerializeField]
		private Dropdown _dropdownWaveCount;

		[SerializeField]
		private Dropdown _dropdownFloorNum;

		[SerializeField]
		private Button _startStoryButton;

		[SerializeField]
		private Text _startStoryText;

		[SerializeField]
		private Button _endStoryButton;

		[SerializeField]
		private Text _endStoryText;

		[SerializeField]
		private StorySetter _storySetter;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[SerializeField]
		private List<WaveInfoSetter> _waveSetterList;

		[SerializeField]
		private Image _blockImage;

		private Action _callback;

		private StageClassInfo _curStage;

		private bool _isNewStage;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(StageClassInfo info, Action callback, bool isNew)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Init()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetData(StageClassInfo info)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ChangeWaveCount(int dropdownIdx)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneStageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelStageSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageInfoEditor()
		{
			throw null;
		}
	}
}
