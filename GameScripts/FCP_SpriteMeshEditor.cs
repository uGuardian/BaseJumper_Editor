using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class FCP_SpriteMeshEditor : MonoBehaviour
{
	public int x;

	public int y;

	public FCP_SpriteMeshEditor.MeshType meshType;

	public Sprite sprite;

	private int bufferedHash;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private int GetSettingHash()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MakeMesh(Sprite sprite, int x, int y, FCP_SpriteMeshEditor.MeshType meshtype)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public FCP_SpriteMeshEditor()
	{
		throw null;
	}

	public enum MeshType
	{
		CenterPoint,
		forward,
		backward
	}
}
