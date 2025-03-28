using UnityEngine;
using UnityEngine.UI;

public class RogueLikeMerchantHeroItem : MonoBehaviour
{
	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private StatDisplayer _statDisplayer;

	[SerializeField]
	private UnitSkillDisplayer _skillDisplayer;

	[SerializeField]
	private RectTransform _skillDescRectTransform;

	[SerializeField]
	private UnitSkillDisplayer _skillDisplayerBig;

	[SerializeField]
	private RogueLikeUnitLevel _levelIcon;

	[SerializeField]
	private Image _regionImage;

	[SerializeField]
	private Transform _prefabRoot;

	[SerializeField]
	private Image[] _unitColorImages;

	private UnitController _unitPrefab;

	public void Set(ResourceUnit resUnit, int level)
	{
	}

	public void Clear()
	{
	}
}
