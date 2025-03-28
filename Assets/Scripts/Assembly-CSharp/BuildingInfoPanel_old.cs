using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoPanel_old : MonoBehaviour
{
	[ComponentConnect]
	public Image sprite;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Text curLevel;

	[ComponentConnect]
	public Text curDesc;

	[ComponentConnect]
	public Text nextLevel;

	[ComponentConnect]
	public Text nextDesc;

	public ResourceBuilding resBuilding;

	public BuildingData buildingData;

	public void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Reload()
	{
	}

	public void Show(BuildingData buildingData)
	{
	}

	public void Hide()
	{
	}

	public void OnClickUpgrade()
	{
	}

	public void DevUp()
	{
	}

	public void DevDown()
	{
	}
}
