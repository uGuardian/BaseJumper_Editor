using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RFX4_TransformMotion : MonoBehaviour
{
	public float Distance;

	public float Speed;

	public float Dampeen;

	public float MinSpeed;

	public float TimeDelay;

	public LayerMask CollidesWith;

	public GameObject[] EffectsOnCollision;

	public float CollisionOffset;

	public float DestroyTimeDelay;

	public bool CollisionEffectInWorldSpace;

	public GameObject[] DeactivatedObjectsOnCollision;

	[HideInInspector]
	public float HUE;

	[HideInInspector]
	public List<GameObject> CollidedInstances;

	private Vector3 startPositionLocal;

	private Transform t;

	private Vector3 oldPos;

	private bool isCollided;

	private bool isOutDistance;

	private Quaternion startQuaternion;

	private float currentSpeed;

	private float currentDelay;

	private const float RayCastTolerance = 0.3f;

	private bool isInitialized;

	private bool dropFirstFrameForFixUnityBugWithParticles;

	public event EventHandler<RFX4_TransformMotion.RFX4_CollisionInfo> CollisionEnter
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Initialize()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void UpdateWorldPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionBehaviour(RaycastHit hit)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnCollisionDeactivateBehaviour(bool active)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDrawGizmosSelected()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public RFX4_TransformMotion()
	{
		throw null;
	}

	public enum RFX4_SimulationSpace
	{
		Local,
		World
	}

	public class RFX4_CollisionInfo : EventArgs
	{
		public RaycastHit Hit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public RFX4_CollisionInfo()
		{
			throw null;
		}
	}
}
