using UnityEngine;
using UnityEngine.UI;

public class BuildingInfoPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public BuildingItem buildingItem;

	public Animator pointFlame;

	public Text pointText;

	public Text[] descTextLong;

	public Animator[] altars;

	public Animator[] flames;

	public Canvas canvas;

	private bool _isClanRaidMode;

	private static string[] _sounds;

	private int _id;

	public void Show(int id, bool isClanRaidMode)
	{
	}

	public void Reload()
	{
	}

	public void Hide()
	{
	}

	public void OnClickHide()
	{
	}

	public bool Close()
	{
		return false;
	}
}
