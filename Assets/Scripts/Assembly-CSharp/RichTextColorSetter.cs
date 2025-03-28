using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RichTextColorSetter : MonoBehaviour
{
	[SerializeField]
	private bool _alphaOnly;

	private Text _text;

	private string _prevText;

	private Color _prevColor;

	private readonly List<Color> _originalPartialColors;

	private void Awake()
	{
	}

	private void LateUpdate()
	{
	}
}
