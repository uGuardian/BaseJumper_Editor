using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class EffectActor : MonoBehaviour
{
	public Transform spawnLocator;

	public EffectActor.projectile[] bombList;

	private string FauxName;

	public Text UiText;

	public int bombType;

	public float min;

	public float max;

	public bool MinorRotate;

	public bool MajorRotate;

	private int seq;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Switch(int value)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Fire()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void RandomizeRotation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Major_RandomizeRotation()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EffectActor()
	{
		throw null;
	}

	[Serializable]
	public class projectile
	{
		public string name;

		public GameObject bombPrefab;

		public Transform bombPrefabTransform;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public projectile()
		{
			throw null;
		}
	}
}
