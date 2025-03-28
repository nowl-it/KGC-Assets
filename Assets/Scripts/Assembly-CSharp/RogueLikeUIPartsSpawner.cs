using UnityEngine;

public class RogueLikeUIPartsSpawner : MonoBehaviour
{
	private enum Parts
	{
		RogueLikeHeroesSelectPanel = 0,
		RogueLikeInventoryPanel = 1,
		None = 2
	}

	[SerializeField]
	private Parts _parts;

	private void OnEnable()
	{
	}
}
