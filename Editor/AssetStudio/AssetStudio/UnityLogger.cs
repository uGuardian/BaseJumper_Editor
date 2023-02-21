#if UNITY_EDITOR
using UnityEngine;

namespace AssetStudio
{
	public sealed class UnityLogger : ILogger
    {
        public void Log(LoggerEvent loggerEvent, string message) {
			switch (loggerEvent) {
				case LoggerEvent.Info:
				case LoggerEvent.Verbose:
				case LoggerEvent.Debug:
					Debug.Log(message);
					break;
				case LoggerEvent.Warning:
					Debug.LogWarning(message);
					break;
				case LoggerEvent.Error:
					Debug.LogError(message);
					break;
			}
		}
    }
}
#endif