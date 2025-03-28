using UnityEngine;
using UnityEngine.EventSystems;

public class RogueLikeBasePanelHero : RogueLikeSelectHeroIcon
{
	[SerializeField]
	private Transform _unitPrefabRoot;

	[SerializeField]
	private Transform _unitPrefabPool;

	private Transform _unitPrefab;

	public override void Reload()
	{
	}

	private void ShowUnitPrefab()
	{
	}

	public bool IsPointerOver(PointerEventData eventData)
	{
		return false;
	}

	public override void OnClick()
	{
	}
}
