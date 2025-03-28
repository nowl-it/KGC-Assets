using System.Collections.Generic;
using UnityEngine;

public class RogueLikeMissionPopupPanel : MonoBehaviour
{
	[SerializeField]
	private GameObject _prefab;

	[SerializeField]
	private Transform _popupRoot;

	public float popupInterval;

	[SerializeField]
	private LayoutAnimator _layoutAnimator;

	private List<RogueLikeMissionPopupItem> _items;

	public void AddItem(int missionId)
	{
	}

	public void RemoveItem(RogueLikeMissionPopupItem popupItem)
	{
	}

	public void OnStartItemDestroy(RogueLikeMissionPopupItem popupItem)
	{
	}
}
