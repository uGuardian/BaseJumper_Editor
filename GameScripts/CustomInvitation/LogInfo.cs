using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class LogInfo : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rect;

		[SerializeField]
		private Text _txtLog;

		private readonly string _errorStr;

		private readonly string _doneStr;

		private readonly string _warningStr;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLog(LogManager.LogType logType, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LogInfo()
		{
			throw null;
		}
	}
}
