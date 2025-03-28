using UnityEngine;
using UnityEngine.UI;

public class RogueLikeItemInfoPanel : MonoBehaviour
{
	[SerializeField]
	private ItemInfoPanel _itemInfoPanel;

	[SerializeField]
	private RectTransform _rectTransform;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private LayoutFitter _layoutFitter;

	[SerializeField]
	private Text _typeText;

	[SerializeField]
	private GridLayoutGroup _statGridLayoutGroup;

	public void Show(Item item, Vector2 pos)
	{
	}

	public void Hide()
	{
	}
}
