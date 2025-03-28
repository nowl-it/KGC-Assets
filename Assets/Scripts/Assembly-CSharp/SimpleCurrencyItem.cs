using UnityEngine;
using UnityEngine.UI;

public class SimpleCurrencyItem : MonoBehaviour
{
	[SerializeField]
	private Text _text;

	[SerializeField]
	private Image _image;

	[SerializeField]
	private TextFitter _textFitter;

	[SerializeField]
	private Border _border;

	public void Set(int count)
	{
	}

	public void SetSprite(Sprite sprite)
	{
	}
}
