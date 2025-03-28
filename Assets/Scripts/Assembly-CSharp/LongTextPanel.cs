using UnityEngine;
using UnityEngine.UI;

public class LongTextPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _titleText;

	[SerializeField]
	private Text _contentText;

	[SerializeField]
	private Text _pageText;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private ConditionalGroup _leftPageButtonConditionals;

	[SerializeField]
	private ConditionalGroup _rightPageButtonConditionals;

	private string[] _contents;

	private int _curPage;

	public void Show(string title, string[] contents)
	{
	}

	private void ReloadPage()
	{
	}

	public void OnClickPageButton(int pageDelta)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
