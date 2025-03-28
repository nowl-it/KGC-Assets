using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RogueLikeSelectNewHeroPanel : MonoBehaviour
{
	[Serializable]
	public class SaveData
	{
		public List<RogueLikeCardData> cardDatas;
	}

	private static RogueLikeSelectNewHeroPanel _instance;

	[SerializeField]
	private RogueLikeSelectNewHeroPanelItem[] _items;

	[SerializeField]
	private UnitSkillDisplayer _skillDisplayer;

	[SerializeField]
	private ConditionalImage[] _pageIndicators;

	[SerializeField]
	private ConditionalGroup _confirmButtonConditionals;

	[SerializeField]
	private RectTransform[] _pageArrows;

	[SerializeField]
	private Border _ribbon;

	private const int _heroCount = 6;

	private const int _heroPerPage = 3;

	private int _curPage;

	private RogueLikeCardData _selectedCard;

	private static SaveData _saveData;

	private bool _setBG;

	[SerializeField]
	private InputField _inputField;

	public static RogueLikeSelectNewHeroPanel Instance => null;

	private void Awake()
	{
	}

	private void SetBG()
	{
	}

	public void Show()
	{
	}

	private void ShowImpl()
	{
	}

	private void PickRandomUnits()
	{
	}

	private void SetPage(int page)
	{
	}

	public void OnClickPageButton(int dir)
	{
	}

	public void OnClickHeroItem(RogueLikeCardData cardData, RogueLikeSelectNewHeroPanelItem item)
	{
	}

	public void OnClickConfirm()
	{
	}

	public bool Close()
	{
		return false;
	}

	public static SaveData ToSaveData()
	{
		return null;
	}

	public void LoadFromSaveDataAndShow(SaveData saveData)
	{
	}

	public void OnClickDevSetHero()
	{
	}
}
