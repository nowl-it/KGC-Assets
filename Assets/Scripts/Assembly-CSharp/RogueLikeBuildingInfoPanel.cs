using UnityEngine;

public class RogueLikeBuildingInfoPanel : MonoBehaviour, IClosable
{
	public RogueLikeBuildingPanel rogueLikeBuildingPanel;

	public RogueLikeBuildingItem buildingItem;

	private bool _inited;

	public static string[] sounds;

	private int _id;

	public void Show(int id)
	{
	}

	public void Reload(int level, bool effect)
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
