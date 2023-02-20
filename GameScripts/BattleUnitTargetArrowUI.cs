using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleUnitTargetArrowUI : MonoBehaviour
{
	public LineRenderer lineRenderer;

	[SerializeField]
	private SpriteRenderer sr_Arrow1;

	[SerializeField]
	private SpriteRenderer sr_Arrow2;

	[SerializeField]
	private Animator _anim;

	private int numPoints;

	private Vector3[] positions;

	private BattleUnitModel _model;

	private bool OnStartPoint;

	private bool isParrying;

	private int heightparam;

	private const float defaultMovecount = 0.75f;

	private bool bCurve;

	private bool isMousepointer;

	private Transform t1;

	private Transform t2;

	private bool ismove;

	private float movecount;

	public SpriteRenderer SprTargeting
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public bool isActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetActive(bool b)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitInParrying(Transform from, Transform to, bool curve)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Transform from, Transform to, bool curve, Faction faction, bool transparent = false)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitParryingSelect(Transform from, Transform to, bool curve, int heightidx = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitParryingSwitch(Transform from, Transform to, bool curve)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitTargetArrow(Transform from, Transform to, bool curve, Faction faction, int heightidx = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitSelect(Transform from, Transform to, bool curve, Faction faction, int heightidx = 1)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitSwitch(Transform from, Transform to, bool curve, Faction faction)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ChangeTransform(Transform from, Transform to)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetLineCenterPos()
	{
		throw null;
	}

	public Transform StartDicetransform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	public Transform EndDicetransform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Vector3 CalcQuadraticBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public BattleUnitTargetArrowUI()
	{
		throw null;
	}
}
