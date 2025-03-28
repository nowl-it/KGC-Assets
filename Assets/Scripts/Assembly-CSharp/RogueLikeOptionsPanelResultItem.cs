using UnityEngine;
using UnityEngine.UI;

public class RogueLikeOptionsPanelResultItem : MonoBehaviour
{
	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private RogueLikeItemIcon _icon;

	private Constants.RogueLikeItemType _iconItemType;

	private int _iconItemId;

	public void Set(ResourceRogueLikeEvent.Result result)
	{
	}

	public void SetIcon(Constants.RogueLikeItemType type, int id)
	{
	}

	public void OnClickIcon()
	{
	}
}
