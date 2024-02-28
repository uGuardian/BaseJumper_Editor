using System;
using UnityEngine;

public class BattleDiceCardBuf
{
	protected BattleDiceCardModel _card;

	protected int _stack = -1;

	protected int _priority = -1;

	private bool _isDestroyed;

	private bool _iconInit;

	private Sprite _bufIcon;

	public virtual DiceCardBufType bufType
	{
		get
		{
			return DiceCardBufType.None;
		}
	}

	public int Stack
	{
		get
		{
			return this._stack;
		}
	}

	public virtual int paramInBufDesc
	{
		get
		{
			return this._stack;
		}
	}

	public int Priority
	{
		get
		{
			return this._priority;
		}
	}

	protected virtual string keywordId
	{
		get
		{
			return "";
		}
	}

	protected virtual string keywordIconId
	{
		get
		{
			return this.keywordId;
		}
	}

	public Sprite GetBufIcon()
	{
		if (!this._iconInit)
		{
			try
			{
				if (!string.IsNullOrEmpty(this.keywordIconId))
				{
					this._bufIcon = Resources.Load<Sprite>("Sprites/CardAddedIcon/" + this.keywordIconId);
				}
			}
			catch (Exception)
			{
				this._bufIcon = null;
			}
			this._iconInit = true;
		}
		return this._bufIcon;
	}

	public string bufActivatedText
	{
		get
		{
			if (string.IsNullOrEmpty(this.keywordId))
			{
				return "";
			}
			return Singleton<BattleEffectTextsXmlList>.Instance.GetEffectTextDesc("CardBuf_" + this.keywordId, this.paramInBufDesc);
		}
	}

	public void Destroy()
	{
		this._isDestroyed = true;
	}

	public bool IsDestroyed()
	{
		return this._isDestroyed;
	}

	public void Init(BattleDiceCardModel card)
	{
		this._card = card;
	}

	public virtual int GetCost(int oldCost)
	{
		return oldCost;
	}

	public virtual void OnUseCard(BattleUnitModel owner)
	{
	}

	public virtual void OnUseCard(BattleUnitModel owner, BattlePlayingCardDataInUnitModel playingCard)
	{
	}

	public virtual void OnDiscard(BattleUnitModel owner, BattleDiceCardModel card)
	{
	}

	public virtual void OnRoundStart()
	{
	}

	public virtual void OnDrawCard()
	{
	}

	public virtual void OnRoundEnd()
	{
	}

	public virtual int OnAddKeywordBufByCard(BattleUnitBuf cardBuf, int stack)
	{
		return 0;
	}

	public virtual int OnGiveKeywordBufByCard(BattleUnitBuf cardBuf, int stack, BattleUnitModel target)
	{
		return 0;
	}
}
