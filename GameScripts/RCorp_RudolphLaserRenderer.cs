using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RCorp_RudolphLaserRenderer : MonoBehaviour
{
	[Header("Reference")]
	[SerializeField]
	private LineRenderer _lineRenderer;

	[SerializeField]
	private RCorp_RudolphBezier _bezierRefObj;

	[SerializeField]
	private RCorp_RudolphLaserController _controller;

	[SerializeField]
	private float _laserSpeed;

	[Header("Runtime")]
	[SerializeField]
	private List<RCorp_RudolphBezier> _bezierCurveList;

	private List<Vector3> _curvePositionList;

	private int _positionCount;

	private int _curPosIdx;

	private float _elapsedMoving;

	private Vector3 _curPos;

	private int _posCountByOneCurve;

	private float _defaultLineWidth;

	public LineRenderer LaserLineRenderer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(List<Vector3> stdPosList)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetLineWidthByRatio(float ratio)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetStartPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetCurPos()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void InitLineVertices()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveLaser()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RCorp_RudolphLaserRenderer()
	{
		throw null;
	}
}
