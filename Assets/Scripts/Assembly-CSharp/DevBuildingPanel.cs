using UnityEngine;
using UnityEngine.UI;

public class DevBuildingPanel : MonoBehaviour
{
	public InputField[] levels;

	public InputField[] enemyLevels;

	public Toggle checkRogueLike;

	private bool _setted;

	public static bool isRogueLike;

	public int maxBuildingCount => 0;

	public void Show()
	{
	}

	public void OnChanged()
	{
	}

	public void Close()
	{
	}
}
