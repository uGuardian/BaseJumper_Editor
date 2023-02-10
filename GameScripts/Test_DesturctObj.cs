using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Test_DesturctObj : MonoBehaviour
{
	public Transform piecesRoot;

	public Rigidbody[] pieces;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnTriggerEnter(Collider other)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Test_DesturctObj()
	{
		throw null;
	}
}
