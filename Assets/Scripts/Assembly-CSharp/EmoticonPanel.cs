using UnityEngine;

public class EmoticonPanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Border _border;

	[SerializeField]
	private GameObject _cooldownMask;

	[SerializeField]
	private FlexibleUIElements _emoticonElements;

	[SerializeField]
	private ClickOutsideClose _clickOutsideClose;

	public void Show()
	{
	}

	private void OnClickEmoticon(ResourceEmoticon resEmoticon)
	{
	}
}
