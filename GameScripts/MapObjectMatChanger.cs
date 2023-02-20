using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MapObjectMatChanger : MonoBehaviour
{
	[SerializeField]
	private MeshRenderer _meshRenderer;

	[SerializeField]
	private Material _cutoutMat;

	[SerializeField]
	private Material _fadeMat;

	[SerializeField]
	private List<Transform> tList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTransparent(Transform t)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public MapObjectMatChanger()
	{
		throw null;
	}
}
