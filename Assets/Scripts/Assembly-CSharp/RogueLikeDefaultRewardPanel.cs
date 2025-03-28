using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeDefaultRewardPanel : MonoBehaviour
{
	[Serializable]
	public class SaveData
	{
		public int defaultHealPer;

		public int rewardHealPer;

		public int goldAmount;

		public bool isElite;

		public List<int> unitExpGainList;
	}

	private static RogueLikeDefaultRewardPanel _instance;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private GameObject _unitIconPrefab;

	[SerializeField]
	private Transform _unitIconsRoot;

	[SerializeField]
	private Text[] _rewardTitleTexts;

	[SerializeField]
	private Text[] _rewardDescTexts;

	[SerializeField]
	private Border _ribbon;

	[SerializeField]
	private ConditionalGroup _selectedConditionals;

	private readonly List<RogueLikeDefaultRewardPanelUnitIcon> _icons;

	private int _selectedIndex;

	private static SaveData _saveData;

	private bool _setBG;

	public static RogueLikeDefaultRewardPanel Instance => null;

	private void SetBG()
	{
	}

	public void Show(int defaultHealPer, int rewardHealPer, bool isElite)
	{
	}

	private void ShowImpl()
	{
	}

	public void ShowPotentialUnlockText(int unitId, int level)
	{
	}

	public void OnClickReward(int index)
	{
	}

	public void OnClickSelect()
	{
	}

	public static SaveData ToSaveData()
	{
		return null;
	}

	public void LoadFromSaveDataAndShow(SaveData saveData)
	{
	}
}
