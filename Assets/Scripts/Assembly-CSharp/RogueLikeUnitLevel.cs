using UnityEngine;
using UnityEngine.UI;

public class RogueLikeUnitLevel : MonoBehaviour
{
	[SerializeField]
	private ImageFontText _levelText;

	[SerializeField]
	private Border _levelTextBorder;

	[SerializeField]
	private Image _starImage;

	[SerializeField]
	private ImageFont[] _fonts;

	public void Set(int level)
	{
	}
}
