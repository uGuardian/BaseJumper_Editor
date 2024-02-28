using System;
using UnityEngine;

public class BattleAttackEffectTester : MonoBehaviour
{
	public Transform self;

	public Transform target;

	public GameObject[] atkEffects;

	public AttackType at;

	private float elapsed;

	private void Start()
	{
	}

	private void Update()
	{
		this.elapsed += Time.deltaTime;
		if (this.elapsed > 0.5f)
		{
			Direction unitDir = (this.self.position.x > this.target.position.x) ? Direction.LEFT : Direction.RIGHT;
			this.CreateAtkEffect(unitDir, this.target.position - this.self.position);
			this.elapsed = 0f;
		}
	}

	private void OnGUI()
	{
		if (GUI.Button(new Rect((float)(Screen.width - 160), (float)(Screen.height - 160), 150f, 100f), "Make Atk Effect"))
		{
			Direction unitDir = (this.self.position.x > this.target.position.x) ? Direction.LEFT : Direction.RIGHT;
			this.CreateAtkEffect(unitDir, this.target.position - this.self.position);
		}
	}

	private void CreateAtkEffect(Direction unitDir, Vector3 atkDir)
	{
		GameObject original;
		switch (this.at)
		{
		case AttackType.Vert:
			original = this.atkEffects[1];
			break;
		case AttackType.Stab:
			original = this.atkEffects[2];
			break;
		case AttackType.Hori:
			original = this.atkEffects[0];
			break;
		default:
			original = this.atkEffects[0];
			break;
		}
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(original, this.self);
		gameObject.SetActive(true);
		gameObject.transform.right = -atkDir;
		gameObject.transform.Translate(0f, 0.5f, 0f);
	}
}
