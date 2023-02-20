using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DamagedBloodEffect : MonoBehaviour
{
	[SerializeField]
	private AnimationCurve _bloodStainColorCurve;

	[SerializeField]
	private GameObject bloodEffectRoot;

	[SerializeField]
	private GameObject splatDirectional;

	[SerializeField]
	private GameObject cone;

	[SerializeField]
	private GameObject radial;

	[SerializeField]
	private GameObject droplets;

	[SerializeField]
	private Transform _corpseRoot;

	private SpriteRenderer _curBloodStain;

	private bool _isCreatedBloodStain;

	private bool _isOverkilled;

	private Vector3 _explodeDirection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(BattleUnitView view, BattleUnitView viewAttacker, int damage, float curHp, Vector2 dir)
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public DamagedBloodEffect()
	{
		throw null;
	}
}
