using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumTarotButton : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Image _choiceSelectorTypeImage;

	[SerializeField]
	private Text _roundText;

	private bool _folded;

	private Tween _foldTween;

	public void SetAlpha(float a)
	{
	}

	public void Reload()
	{
	}

	public void Fold(bool fold)
	{
	}
}
