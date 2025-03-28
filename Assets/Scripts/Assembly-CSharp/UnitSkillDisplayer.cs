using UnityEngine;
using UnityEngine.UI;

public class UnitSkillDisplayer : MonoBehaviour
{
	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _tierText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Border _border;

	[SerializeField]
	private TextFitter _descTextFitter;

	public void Set(ResourceUnit resUnit, int level, bool longVersion, string tierFormat = null, CardData cardData = null)
	{
	}

	public static float StatFunc(int cardLevel, ResourceUnit resourceUnit, BuffManager.StatType statType, int unitLevel = 1)
	{
		return 0f;
	}
}
