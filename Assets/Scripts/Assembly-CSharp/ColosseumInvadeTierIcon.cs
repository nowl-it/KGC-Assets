using UnityEngine;
using UnityEngine.UI;

public class ColosseumInvadeTierIcon : MonoBehaviour
{
	[SerializeField]
	private Image _frameImage;

	[SerializeField]
	private Image _bossHornImage;

	[SerializeField]
	private Image _chapterIconImage;

	[SerializeField]
	private Image _starImage;

	[SerializeField]
	private Text _tierText;

	[SerializeField]
	private Image _backgroundImage;

	[SerializeField]
	private Font[] _levelFonts;

	public void Set(int tier, int theme, bool isBoss)
	{
	}

	public void SetBackgroundColor(Color color)
	{
	}

	public void SetChapterIconColor(Color color)
	{
	}
}
