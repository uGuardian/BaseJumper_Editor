using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LinePatternRenderer : MonoBehaviour
{
	[SerializeField]
	private SpriteRenderer _sprRenderer;

	public Vector3 _line1;

	public Vector3 _line2;

	public float scale;

	[SerializeField]
	private LinePatternRenderer.LinePlaneDirectionType _planeDirectionType;

	[SerializeField]
	private Vector3 _planeDirection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetLine(Vector3 pos1, Vector3 pos2)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLayer(string layer)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public LinePatternRenderer()
	{
		throw null;
	}

	public enum LinePlaneDirectionType
	{
		Camera,
		Custom
	}
}
