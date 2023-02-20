using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LaserController2D : MonoBehaviour
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LaserController2D()
	{
		throw null;
	}
}
