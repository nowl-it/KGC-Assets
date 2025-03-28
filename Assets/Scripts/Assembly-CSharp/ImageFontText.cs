using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFontText : MonoBehaviour
{
	[SerializeField]
	private ImageFont _font;

	[SerializeField]
	private int _fontSize;

	private readonly List<Image> _images;

	private string _text;

	private float _totalWidth;

	public ImageFont font
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void SetText(string newText)
	{
	}
}
