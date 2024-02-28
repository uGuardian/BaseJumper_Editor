using System;
using System.Collections.Generic;
using UnityEngine;

public class CreatureAppearance : CharacterAppearance
{
	public override void InitCustomData(UnitCustomizingData customizeData, LorId defaultBookId)
	{
	}

	public override void InitGiftDataAll(List<GiftModel> equippedGiftList)
	{
	}

	public override void SetDamagedSprite(int dmg, float curHp)
	{
	}

	public override void ChangeMotion(ActionDetail detail)
	{
		try
		{
			CharacterMotion currentMotion = this._currentMotion;
			if (currentMotion != null)
			{
				GameObject gameObject = currentMotion.gameObject;
				if (gameObject != null)
				{
					gameObject.SetActive(false);
				}
			}
			if (this._altMotion.ContainsKey(detail))
			{
				detail = this._altMotion[detail];
			}
			if (!this._characterMotionDic.ContainsKey(detail))
			{
				this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				detail = ActionDetail.Default;
			}
			switch (detail)
			{
			case ActionDetail.Default:
				this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				break;
			case ActionDetail.Guard:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Guard))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Guard];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.Evade:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Evade))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Evade];
				}
				else if (this._characterMotionDic.ContainsKey(ActionDetail.Guard))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Guard];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.Damaged:
				this._currentMotion = this._characterMotionDic[ActionDetail.Damaged];
				break;
			case ActionDetail.Slash:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Slash))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Slash];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Hit];
				}
				break;
			case ActionDetail.Penetrate:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Penetrate))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Penetrate];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Hit];
				}
				break;
			case ActionDetail.Hit:
				this._currentMotion = this._characterMotionDic[ActionDetail.Hit];
				break;
			case ActionDetail.Move:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Move))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Move];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.Standing:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Standing))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Standing];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.NONE:
				break;
			case ActionDetail.Fire:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Fire))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Fire];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.Aim:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Aim))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Aim];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			case ActionDetail.Special:
				if (this._characterMotionDic.ContainsKey(ActionDetail.Special))
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Special];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			default:
				if (this._characterMotionDic.ContainsKey(detail))
				{
					this._currentMotion = this._characterMotionDic[detail];
				}
				else
				{
					this._currentMotion = this._characterMotionDic[ActionDetail.Default];
				}
				break;
			}
			CharacterMotion currentMotion2 = this._currentMotion;
			if (currentMotion2 != null)
			{
				GameObject gameObject2 = currentMotion2.gameObject;
				if (gameObject2 != null)
				{
					gameObject2.SetActive(true);
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogErrorFormat("{0} [{1}] : {2}", new object[]
			{
				base.gameObject.name,
				detail,
				ex
			});
		}
	}

	protected override GiftAppearance CreateGiftData(GiftModel gift, string resPath)
	{
		return null;
	}

	protected override void Awake()
	{
		base.Awake();
	}
}
