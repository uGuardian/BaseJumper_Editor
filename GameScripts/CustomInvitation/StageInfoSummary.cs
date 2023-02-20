using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class StageInfoSummary : MonoBehaviour
	{
		[SerializeField]
		private Text _textStageId;

		[SerializeField]
		private Text _textStageName;

		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private Image _chapterBgImage;

		[SerializeField]
		private Image _chapterImage;

		private int _stageID;

		private Action<StageInfoSummary> _callback;

		public int stageID
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<StageInfoSummary> callback)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStageInfo(StageClassInfo stage)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public Toggle GetToggle()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ToggleSummary(bool isOn)
		{
			
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public StageInfoSummary()
		{
			throw null;
		}
	}
}
