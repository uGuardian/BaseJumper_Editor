using System;
using UnityEngine;

public class BattleCamera
{
	private bool _on;

	private bool _posOn;

	private Vector3 _startZoomPos;

	private float _startZoomSize;

	private float _zoomTime;

	private float _elapsedTime;

	public void ReturnCameraState(float time)
	{
	}

	public void StopZoom()
	{
		this._on = false;
	}

	public bool IsZoomOn()
	{
		return this._on;
	}

	public void OnUpdate()
	{
		this._elapsedTime += Time.unscaledDeltaTime;
		if (this._elapsedTime >= this._zoomTime)
		{
			this._on = false;
		}
	}
}
