using System.Collections.Generic;
using UnityEngine;

public class SpriteFontText : MonoBehaviour
{
	[SerializeField]
	private ImageFont _font;

	[SerializeField]
	private int _fontSize;

	private readonly List<SpriteRenderer> _spriteRenderers;

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
