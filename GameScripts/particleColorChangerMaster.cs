using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
public class particleColorChangerMaster : MonoBehaviour
{
	public float Speed_custom;

	public particleColorChangerMaster.colorChange[] colorChangeList;

	public bool applyChanges;

	public bool Keep_applyChanges;

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public particleColorChangerMaster()
	{
		throw null;
	}

	[Serializable]
	public class colorChange
	{
		public string Name;

		public ParticleSystem[] colored_ParticleSystem;

		public Gradient Gradient_custom;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public colorChange()
		{
			throw null;
		}
	}
}
