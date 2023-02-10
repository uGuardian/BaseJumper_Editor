using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class MapPointLightBG : MonoBehaviour
{
	[SerializeField]
	private bool _isImportant;

	[SerializeField]
	private bool _isBlink;

	[SerializeField]
	private Light _light;

	[SerializeField]
	private float _maxRange;

	[SerializeField]
	private float _maxIntensity;

	[SerializeField]
	private bool _affectCam;

	[SerializeField]
	private float _intensityMultiplier;

	[SerializeField]
	private float _speed;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator BlinkLight()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator ChangeIntensity()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapPointLightBG()
	{
		throw null;
	}
}
