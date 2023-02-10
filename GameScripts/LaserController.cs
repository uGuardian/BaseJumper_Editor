using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaserController : MonoBehaviour
{
	public float length;

	public float width;

	public float OvarAll_Size;

	public GameObject hit_effect;

	[SerializeField]
	private GameObject laser_add;

	[SerializeField]
	private GameObject laser_alpha;

	[SerializeField]
	private GameObject trf_scaleController;

	[SerializeField]
	private bool raycast;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LaserController()
	{
		throw null;
	}
}
