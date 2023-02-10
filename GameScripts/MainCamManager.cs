using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainCamManager : MonoBehaviour
{
	private static MainCamManager _instance;

	[SerializeField]
	private Vector3 _originPos;

	private Coroutine _shakeRoutine;

	private bool isShaking;

	public float shakeRange;

	public float duration;

	private float _orthoSize;

	public static MainCamManager Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ShakeCam()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator VibeCam(Vector3 originPos)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MainCamManager()
	{
		throw null;
	}
}
