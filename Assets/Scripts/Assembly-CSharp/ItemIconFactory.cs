using System.Collections.Generic;
using UnityEngine;

public class ItemIconFactory : MonoBehaviour
{
	[SerializeField]
	private GameObjectPool _artifactIconPool;

	private readonly Dictionary<GameObject, List<GameObject>> _rentedArtifactIconDict;

	public void MakeItemIcon(GameObject rentedBy, ClickableShopItemIcon icon, string rewardType, int rewardId, int rewardCount, bool showCount, out GameObject artifactIcon)
	{
		artifactIcon = null;
	}

	public GameObject RentArtifactIcon(GameObject rentedBy, Transform parent, int artifactId, int count)
	{
		return null;
	}

	public void ReturnArtifactIcons(GameObject rentedBy)
	{
	}

	public void ReturnArtifactIcon(GameObject rentedBy, GameObject artifactIcon)
	{
	}
}
