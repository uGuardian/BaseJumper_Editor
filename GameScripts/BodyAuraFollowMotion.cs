using System;

public class BodyAuraFollowMotion : BodyAura
{
	protected override void Update()
	{
		base.Update();
		if (this._appearance != null)
		{
			CharacterMotion currentMotion = this._appearance.GetCurrentMotion();
			base.transform.position = currentMotion.transform.position;
		}
	}
}
