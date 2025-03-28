using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeBuildingPanel : MonoBehaviour, IClosable
{
	[Serializable]
	public struct UnLimitedDesc
	{
		public GameObject gameObject;

		public ConditionalGroup conditionalGroup;

		public Text buildingAndLevelText;

		public Image strokeImage;

		public Text descText;

		public Image descEffect;
	}

	public static RogueLikeBuildingPanel Instance;

	public RectTransform buildingItemsLayoutGroup;

	public UnLimitedDesc unLimitedDesc;

	public int unLimitedBuildingId;

	public RogueLikeBuildingItem buildingItemPrefab;

	private List<RogueLikeBuildingItem> _buildingItems;

	public RogueLikeBuildingInfoPanel rogueLikeBuildingInfoPanel;

	private bool _setBG;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetBG()
	{
	}

	public void Show()
	{
	}

	public void Reload()
	{
	}

	public void Reload(bool effect)
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}
}
