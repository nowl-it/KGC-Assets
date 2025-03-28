using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CenterText : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public Text content;

	public Image iconImage;

	public ImageTextPair imageTextPair;

	public Border border;

	public float boxHeight;

	private Sequence _sequence;

	private Vector3 _originPos;

	public void ShowFloating(string text, float delay = 0f, float remain = 2f)
	{
	}

	public void Show(string text, float delay = 0f, float remain = 1f)
	{
	}

	public void ShowItem(ResourceItem resItem, float delay, float remain)
	{
	}

	public void ShowGold(int gold)
	{
	}

	public void Hide()
	{
	}
}
