using UnityEngine;
using UnityEngine.UI;

public class RuneInfoPanel : MonoBehaviour
{
	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Image[] _frameImages;

	[SerializeField]
	private Text _stackText;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Text _tierText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private ConditionalImage _starConditionalImage;

	[SerializeField]
	private ConditionalGroup _ownConditionals;

	private Rune _rune;

	public void Set(Rune rune, bool showFullDesc)
	{
	}

	public void OnClick()
	{
	}
}
