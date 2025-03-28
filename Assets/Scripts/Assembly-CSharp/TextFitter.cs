using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
[RequireComponent(typeof(Text))]
public class TextFitter : UIFitter
{
	public bool fitX;

	public bool fitY;

	public bool applyMaxX;

	public bool applyMaxY;

	public Vector2 max;

	public bool applyMinX;

	public bool applyMinY;

	public Vector2 min;

	private RectTransform _rectTransform;

	private Text _text;

	private InputField _input;

	private VerticalWrapMode _originVerticalWrap;

	private HorizontalWrapMode _originHorizontalWrap;

	public Text text => null;

	private void OnEnable()
	{
	}

	public override void Fit()
	{
	}

	public void FitInputField()
	{
	}

	private bool TryGetText()
	{
		return false;
	}

	public void SetTextAndFit(string text)
	{
	}

	public void SetBestFitMaxSize(int size)
	{
	}
}
