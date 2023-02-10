using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KnightOfDespairGroggyFilter : MonoBehaviour
{
	[Header("References")]
	[SerializeField]
	private Transform[] _swords;

	[SerializeField]
	private Vector3[] _srcToDstSword1;

	[SerializeField]
	private Vector3[] _srcToDstSword2;

	[SerializeField]
	private Vector3[] _srcToDstSword3;

	[SerializeField]
	private Animator _animator;

	[Header("Runtime")]
	[SerializeField]
	private bool _doneAnim;

	[SerializeField]
	private List<KnightOfDespairGroggyFilter.SwordInfo> _list;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetSwordPosition()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveSwordSprite()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnAnimEvent(int i)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator MoveRoutine(Transform t, Vector3[] srcToDst)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public KnightOfDespairGroggyFilter()
	{
		throw null;
	}

	[Serializable]
	public class SwordInfo
	{
		public Transform t;

		public bool moved;

		public Vector3[] srcToDst;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public SwordInfo()
		{
			throw null;
		}
	}
}
