using System;
using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class GachaResultTableItem : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private ConditionalImage _artifactFrame;

	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Text _name;

	[SerializeField]
	private Text _valueText;

	[SerializeField]
	private GameObject _showMoreButton;

	[SerializeField]
	private ConditionalScale _dropdownButton;

	[SerializeField]
	private RectTransform _dropdownRoot;

	private GameObject _flashParticle;

	private Action _onClickShowMore;

	private Action _onClickDropdownAlert;

	public void Set(ResourceGacha resGacha, ResourceGacha.Result result, int upgradeMultiplier, GameObject dropdownPrefab, int rarity = -1)
	{
	}

	private void Clear()
	{
	}

	private void SetArtifact(ResourceArtifact resArtifact, float percentage, ResourceGacha resGacha)
	{
	}

	private void SetTreasure(ResourceTreasure resTreasure, float percentage, ResourceGacha resGacha, bool highlight)
	{
	}

	private void SetAccessory(int synergy, float percentage)
	{
	}

	public void SetReward(Reward reward, float probability)
	{
	}

	private void SetValueText(float percentage)
	{
	}

	private float MakeDropdown(ResourceGacha resGacha, string type, GameObject dropdownPrefab, int rarity = -1)
	{
		return 0f;
	}

	public void OnClickShowMore()
	{
	}

	public void OnClickDropdown()
	{
	}

	private void OpenDropdown(bool open)
	{
	}
}
