/*
namespace System.Threading.Tasks.uGuardian {
	public static class TaskExtensions {
		#region kjbartel
		// This will not stop the Task you were waiting for and it will continue running.
		public static async Task<T> WaitOrCancel<T>(this Task<T> task, CancellationToken token)
		{
			token.ThrowIfCancellationRequested();
			await Task.WhenAny(task, token.WhenCanceled());
			token.ThrowIfCancellationRequested();

			return await task;
		}

		public static Task WhenCanceled(this CancellationToken cancellationToken)
		{
			var tcs = new TaskCompletionSource<bool>();
			cancellationToken.Register(s => ((TaskCompletionSource<bool>)s).SetResult(true), tcs);
			return tcs.Task;
		}
		#endregion
	}
}
*/