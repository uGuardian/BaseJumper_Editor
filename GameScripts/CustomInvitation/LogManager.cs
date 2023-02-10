using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace CustomInvitation
{
	public class LogManager : MonoBehaviour
	{
		private static LogManager _instance;

		[Header("Block")]
		[SerializeField]
		private Image _blockImg;

		[SerializeField]
		private Color _errorPopupColor;

		[SerializeField]
		private Color _normalPopupColor;

		[SerializeField]
		private Color _warningPopupColor;

		[Header("LogList")]
		[SerializeField]
		private CanvasGroup _logListCanvasGroup;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private Button _clearButton;

		[SerializeField]
		private LogInfo _logInfo;

		[SerializeField]
		private LayoutGroup _logLayout;

		[SerializeField]
		private int _maxLogCount;

		[SerializeField]
		private Scrollbar _scrollBar;

		[Header("PopupLog")]
		[SerializeField]
		private Image _logPopupBg;

		[SerializeField]
		private CanvasGroup _logPopupCanvasGroup;

		[SerializeField]
		private Text _logPopupText;

		[SerializeField]
		private Button _logPopupConfirmButton;

		[SerializeField]
		private Button _logPopupCancelButton;

		private Queue<LogInfo> _logQueue;

		private LogManager.WarningEvent _warningEvent;

		public static LogManager instance
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLog(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogDone(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogError(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogWarning(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogFormat(string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogDoneFormat(string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogErrorFormat(string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PrintLogWarningFormat(string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupLog(bool availableClosing, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupLogFormat(bool availableClosing, string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupWarningLog(bool availableClosing, string message, LogManager.WarningEvent warningEvent = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupWarningLogFormat(bool availableClosing, string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupErrorLog(bool availableClosing, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PopupErrorLogFormat(bool availableClosing, string format, params object[] args)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogPopup(bool availableClosing, string str, Color c, LogManager.WarningEvent warningEvent = null)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CreateLog(LogManager.LogType logType, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator UpdateScrollbar()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ClearLogs()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OpenLogList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseLogList()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OpenLogPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void CloseLogPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ConfirmLogPopup()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public LogManager()
		{
			throw null;
		}

		public enum LogType
		{
			Error,
			None,
			Done,
			Warning
		}

		public delegate void WarningEvent();
	}
}
