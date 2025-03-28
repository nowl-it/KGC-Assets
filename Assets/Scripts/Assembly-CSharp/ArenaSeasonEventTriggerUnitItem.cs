using UnityEngine;
using UnityEngine.UI;

public class ArenaSeasonEventTriggerUnitItem : MonoBehaviour
{
	[SerializeField]
	private Image _unitIllust;

	[SerializeField]
	private Image _unitIllustGradation;

	[SerializeField]
	private Text _unitNameText;

	[SerializeField]
	private RectTransform _unitObjRoot;

	[SerializeField]
	private Image _regionIcon;

	[SerializeField]
	private Image _roleIcon;

	private ResourceUnit _resUnit;

	private GameObject _unitObj;

	public void Set(ResourceUnit resUnit)
	{
	}

	public void OnClickShortcut()
	{
	}
}
