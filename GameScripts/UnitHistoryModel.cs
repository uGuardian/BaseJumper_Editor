using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameSave;

public class UnitHistoryModel : Savable
{
	private UnitDataModel _self;

	public int winKeter;

	public int winMalkuth;

	public int winYesod;

	public int winHod;

	public int winNetzach;

	public int winTiphereth;

	public int winGebura;

	public int winChesed;

	public int winBinah;

	public int winHokma;

	public int damagedFinnBook;

	public int winYunBook;

	public int paralysisIron;

	public int bleedHook;

	public int bleedPierr;

	public int deadByLulu;

	public int killLuluByMars;

	public int killWalterByIsadora;

	public int removeDiceByDog;

	public int discardByMolar;

	public int killOlgaByRainMika;

	public int winNormal2ch;

	public int killMarsInStreetLightEp1;

	public int fascinatingFabric;

	public int killWithRanged;

	public int aliveInWedge;

	public int killByDalloc;

	public int killPameliByPamela;

	public int killPhilipByOscar1;

	public int killPhilipByOscar2;

	public int killPhilipByOscar3;

	public int plWithPeriodFarByNear;

	public int meokchilWithSevenHands;

	public int killWithBleedCh4;

	public int give20bleedch4;

	public int jikanBleedMyself;

	public int ch4sakura3;

	public int ch4pwWithWorkshopFixer10;

	public int trashDisposalReuse;

	public int ch5killWithLowHP3;

	public int ch5costHp5;

	public int evadeWithLowHp;

	public int pwAgainstRanged;

	public int pwBorderVsBorder;

	public int killNoahWithEma;

	public int killNoahAndEma;

	public int killNoahAfterEma;

	public int plAgainstBBigduck;

	public int jiryeongipnida3;

	public int clashWithSmoke10;

	public int aliveInCryingBaby;

	public int stunByOverCharge3;

	public int spaceCutFail;

	public int drawByDoyak1;

	public int goldan2;

	public int danteSkill;

	public int ch6smashToSmoke40;

	public int killBorisByKalo;

	public int killDenisByKalo;

	public int killKatrielByKalo;

	public int killThumbByKalo;

	public int killKaloByBoris;

	public int ch6killByPunish;

	public int ch6discardByThumb;

	public int aliveXiaoAndRowel;

	public int ch6emotionLevelMin;

	public int burnInStar30;

	public int ch6laserDestroyDice;

	public int killBadaWithSan;

	public int ch6ususuhanAttack36;

	public int killOnceByChuckgyeol;

	public int ch6haegeum3;

	public int ch6killByChamsoo;

	public int ch6killByHyeongbeol;

	public int killKaliByGebura;

	public int killRabbit1;

	public int killRabbit2;

	public int killRabbit3;

	public int killRhino1;

	public int killRhino2;

	public int killRhino3;

	public int killReindeer1;

	public int killReindeer2;

	public int killReindeer3;

	public int killNicolaiTarget;

	public int killByCheoboon;

	public int hitByWhipMax;

	public int killOnceByDonkatsu;

	public int killMyoByGebura;

	public int killByMyoLastDice;

	public int burnByXiao;

	public int winWithYeokrin;

	public int killXiaoByMiris;

	public int rerollByPurpleTear;

	public int purpleTearAllForm;

	public int killKalo;

	public int killNicolai;

	public int killPurpleTear;

	public int yanJiryeong4;

	public int give30bleedch6;

	public int destroyDefByAlan3;

	public int destroyDebufByErina4;

	public int ussetProtByOneTurn;

	public int breakMaxByIlzeom;

	public int ch6smash2ToSmoke60;

	public int ch7oneforall4;

	public int killPhilipWithDawns;

	public int killEileenWithPeriod;

	public int killGretaWithPierre;

	public int killBrementWithBremens;

	public int killOswaldWithEma;

	public int killTanyaWithKurokumo;

	public int killPuppeteerWithPuppet;

	public int killElenaWithTomerry;

	public int killPlutoWithJipangi;

	public int killArgalia;

	public int killTwistedPhilip;

	public int killTwistedEileen;

	public int killTwistedGreta;

	public int killTwistedBremen;

	public int killTwistedOswald;

	public int killTwistedTanya;

	public int killTwistedJaeheon;

	public int killTwistedElena;

	public int killTwistedPluto;

	public int killTwistedArgalia;

	private const int winCondition = 10;

	public List<UnitHistoryModel.GiftInfo> abnormalityGiftList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UnitHistoryModel(UnitDataModel self)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public List<GiftModel> TryAddNewGifts(UnitBattleStageHistory stageHistory, UnitBattleWaveHistory waveHistory)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AddGift(List<GiftModel> targetList, int id)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SaveData GetSaveData()
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LoadFromSaveData(SaveData data)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void KillUnit(int enemyUnitId)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UseEgoCard(BattleDiceCardModel egoCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PickEmotionCard(BattleEmotionCardModel emotionCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<int> GetGiftIdByEmotionCard(BattleEmotionCardModel emotionCard)
	{
		throw null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<int> GetGiftIdByEgoCard(BattleDiceCardModel egoCard)
	{
		throw null;
	}

	public class GiftInfo
	{
		public string key;

		public int giftId;

		public int useCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public GiftInfo()
		{
			throw null;
		}
	}
}
