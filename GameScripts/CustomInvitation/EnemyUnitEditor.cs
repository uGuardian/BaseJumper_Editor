using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class EnemyUnitEditor : MonoBehaviour
	{
		[SerializeField]
		private KeyPageSummary _refKeyPageUI;

		[SerializeField]
		private ToggleListFilter _enemyKeyPageFilter;

		[SerializeField]
		private LayoutGroup _enemyKeyPageLayout;

		[SerializeField]
		private DropBookSummary _refDropBookUI;

		[SerializeField]
		private ToggleListFilter _dropBookFilter;

		[SerializeField]
		private LayoutGroup _dropBookLayout;

		[SerializeField]
		private InputField _inputEnemyName;

		[SerializeField]
		private Slider _sliderMinHeight;

		[SerializeField]
		private InputField _inputCurMinHeight;

		[SerializeField]
		private Slider _sliderMaxHeight;

		[SerializeField]
		private InputField _inputCurMaxHeight;

		[SerializeField]
		private Button _doneButton;

		[SerializeField]
		private Button _cancelButton;

		[Header("Runtime")]
		[SerializeField]
		private List<KeyPageSummary> _enemyKeyPageSummaryList;

		[SerializeField]
		private List<DropBookSummary> _dropBookSummaryList;

		private const int _MIN_LIMIT = 140;

		private const int _MAX_LIMIT = 220;

		private Action _callback;

		private EnemyUnitClassInfo _curEnemyUnitInfo;

		private bool _isNewEnemyUnit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenEditorWindow(EnemyUnitClassInfo enemyUnitInfo, Action callback, bool isNew)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
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
		private void SetData(EnemyUnitClassInfo info)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetKeyPageList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetDropBookList()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveMinHeightSlider(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveMaxHeightSlider(float value)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditMinHeightInput(string input)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EditMaxHeightInput(string input)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DoneEnemyUnitSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void EnemyUnitDone()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CancelEnemyUnitSetting()
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public EnemyUnitEditor()
		{
			throw null;
		}
	}
}
