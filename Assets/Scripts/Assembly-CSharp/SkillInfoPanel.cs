using UnityEngine;
using UnityEngine.UI;

public class SkillInfoPanel : MonoBehaviour
{
	[ComponentConnect]
	public Image iconImage;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text descText;

	[ComponentConnect]
	public Text skillEnergyText;

	[SerializeField]
	private UIFitter[] _uiFitters;

	public void Set(ResourceSkill resSkill, ResourceUnit resUnit, CardData cardData, bool longVersion, bool iconNativeSize = true, int unitLevel = 1)
	{
	}
}
