using UnityEngine;

public class BuildableArea : ClickableObject
{
	[Header("이거 반드시 설정하고 중복 없나 확인하란 말이야 확인!!")]
	public int positionIndex;

	[SerializeField]
	private ResourceTerritoryBuilding.EventBuildingType _eventBuildingType;

	[SerializeField]
	private GameObject _areaEmptyObject;

	[SerializeField]
	private GameObject _buildableHighlightObject;

	private Vector3 _buildableHighlightObjectOriginPos;

	private TerritoryBuilding _building;

	public ResourceTerritoryBuilding.EventBuildingType eventBuildingType => default(ResourceTerritoryBuilding.EventBuildingType);

	protected override void Awake()
	{
	}

	private void Update()
	{
	}

	public void ShowBuildableHighlight(bool show)
	{
	}

	public void ShowCanReplaceHighlight(bool show)
	{
	}

	public override void OnClick(Vector3 screenPosition, Vector3 clickedPosition)
	{
	}

	public void SetBuilding(TerritoryBuilding building)
	{
	}

	public void DestroyBuilding()
	{
	}

	public bool CanBuild(ResourceTerritoryBuilding resBuilding)
	{
		return false;
	}
}
