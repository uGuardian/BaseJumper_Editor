using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
	private static CursorManager _instance;

	[SerializeField]
	private Texture2D _normalCursor;

	[SerializeField]
	private Texture2D _mouseOverCursor;

	[SerializeField]
	private Texture2D _mouseDownCursor;

	[SerializeField]
	private Texture2D _mouseCameraScrollCursor;

	[SerializeField]
	private Texture2D _mouseLoadingCursor;

	private MouseCursorType _currentCursor;

	private int _mouseOverCount;

	private bool _cameraScrollOn;

	private Vector3 _lastPosition;

	public static CursorManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	private bool mouseOverState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateCursor(MouseCursorType cursor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void SetCursor(MouseCursorType cursor)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetMouse()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddMouseOverCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SubMouseOverCount()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnCameraScroll()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HideCursor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShowCursor()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetCursorWorldPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CursorManager()
	{
		throw null;
	}
}
