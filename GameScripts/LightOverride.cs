using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class LightOverride : MonoBehaviour
{
	[Header("Overrides")]
	public float m_IntensityMult;

	[MinValue(0f)]
	public float m_RangeMult;

	private LightOverride.Type m_Type;

	private bool m_Initialized;

	private Light m_Light;

	private TubeLight m_TubeLight;

	private AreaLight m_AreaLight;

	public bool isOn
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public Light light
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public TubeLight tubeLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public AreaLight areaLight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	public LightOverride.Type type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		
	}

	public abstract bool GetForceOn();

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Init()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected LightOverride()
	{
		throw null;
	}

	public enum Type
	{
		None,
		Point,
		Tube,
		Area,
		Directional
	}
}
