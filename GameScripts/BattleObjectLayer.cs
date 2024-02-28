using System;
using System.Collections.Generic;
using UI;
using UnityEngine;

public class BattleObjectLayer : MonoBehaviour
{
	private static BattleObjectLayer _instance;

	public BattleUnitView battleUnitPrefab;

	private List<BattleUnitView> _unitList;

	public List<BattleObjectLayer.UnitViewportPosInfo> unitViewportList;

	public UICustomSelectablePanel selectablePanel;

	public static BattleObjectLayer instance
	{
		get
		{
			return BattleObjectLayer._instance;
		}
	}

	public List<BattleUnitView> UnitViewList
	{
		get
		{
			return this._unitList;
		}
	}

	private void Awake()
	{
		BattleObjectLayer._instance = this;
		this._unitList = new List<BattleUnitView>();
		this.unitViewportList = new List<BattleObjectLayer.UnitViewportPosInfo>();
	}

	public void Clear()
	{
		foreach (BattleUnitView battleUnitView in this._unitList)
		{
			if (battleUnitView != null)
			{
				string resourceName = "";
				if (battleUnitView.charAppearance != null)
				{
					resourceName = battleUnitView.charAppearance.resourceName;
				}
				UnityEngine.Object.Destroy(battleUnitView.gameObject);
				Singleton<AssetBundleManagerRemake>.Instance.ReleaseSdObject(resourceName);
			}
		}
		this._unitList.Clear();
		this.unitViewportList.Clear();
	}

	public void AddUnit(BattleUnitModel model)
	{
		BattleUnitView battleUnitView = UnityEngine.Object.Instantiate<BattleUnitView>(this.battleUnitPrefab);
		model.view = battleUnitView;
		battleUnitView.model = model;
		battleUnitView.CreateSkin();
		battleUnitView.model.UpdateDirection(Vector3.zero);
		battleUnitView.transform.SetParent(base.transform, false);
		battleUnitView.transform.localPosition = SingletonBehavior<HexagonalMapManager>.Instance.CellToWorldPos(model.formationCellPos + SingletonBehavior<HexagonalMapManager>.Instance.CenterCell);
		battleUnitView.gameObject.SetActive(true);
		battleUnitView.abCardSelector.selectable.parentSelectable = this.selectablePanel;
		this._unitList.Add(battleUnitView);
		BattleObjectLayer.UnitViewportPosInfo unitViewportPosInfo = new BattleObjectLayer.UnitViewportPosInfo();
		unitViewportPosInfo.view = battleUnitView;
		this.unitViewportList.Add(unitViewportPosInfo);
	}

	public void RemoveUnit(BattleUnitModel model)
	{
		string resourceName = "";
		BattleUnitView removal = null;
		foreach (BattleUnitView battleUnitView in this._unitList)
		{
			if (battleUnitView != null && battleUnitView.model == model)
			{
				removal = battleUnitView;
				if (removal.charAppearance != null)
				{
					resourceName = removal.charAppearance.resourceName;
				}
				UnityEngine.Object.Destroy(battleUnitView.gameObject);
				Singleton<AssetBundleManagerRemake>.Instance.ReleaseSdObject(resourceName);
			}
		}
		this._unitList.Remove(removal);
		BattleObjectLayer.UnitViewportPosInfo unitViewportPosInfo = this.unitViewportList.Find((BattleObjectLayer.UnitViewportPosInfo x) => x.view == removal);
		if (unitViewportPosInfo != null)
		{
			this.unitViewportList.Remove(unitViewportPosInfo);
		}
	}

	private void FixedUpdate()
	{
		foreach (BattleObjectLayer.UnitViewportPosInfo unitViewportPosInfo in this.unitViewportList)
		{
			Vector3 viewportPos = SingletonBehavior<BattleCamManager>.Instance.mainCam.WorldToViewportPoint(unitViewportPosInfo.view.WorldPosition);
			unitViewportPosInfo.viewportPos = viewportPos;
		}
	}

	public class UnitViewportPosInfo
	{
		public BattleUnitView view;

		public Vector3 viewportPos;
	}
}
