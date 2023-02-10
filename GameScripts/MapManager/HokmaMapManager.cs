using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HokmaMapManager : MapManager
{
	[Header("시계추")]
	[SerializeField]
	private List<HokmaMapManager.PendulumInfo> _pendulumList;

	[SerializeField]
	private GameObject _dustParticle;

	[Header("구름")]
	[SerializeField]
	private float _cloudSpeed;

	[SerializeField]
	private float _startPosX;

	[SerializeField]
	private Transform _cloudMid;

	[SerializeField]
	private Transform _cloudLeft;

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdate()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InitializeMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ResetMap()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ActiveMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void EnableMap(bool b)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void MoveCloud()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ResetCloud()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public HokmaMapManager()
	{
		throw null;
	}

	[Serializable]
	public class PendulumInfo
	{
		public Transform pendulum;

		public AnimationCurve curve;

		public float speed;

		public float amplitude;

		private float _elapsed;

		private bool _bPause;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Pause()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Start()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float deltaTime)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public PendulumInfo()
		{
			throw null;
		}
	}
}
