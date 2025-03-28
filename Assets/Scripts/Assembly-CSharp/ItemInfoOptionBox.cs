using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfoOptionBox : MonoBehaviour
{
	public RectTransform rectTransform;

	public Text optionText;

	public Image optionEffect;

	public ConditionalTextColor optionTextColor;

	public UIFitter[] uiFitters;

	private Sequence _sequence;

	public void Set(string option, bool showEffect, bool valueAdded = false, bool controlFontSize = true)
	{
	}

	public void ShowEffect()
	{
	}
}
