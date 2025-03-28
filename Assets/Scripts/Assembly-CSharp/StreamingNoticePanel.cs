using UnityEngine;
using UnityEngine.UI;

public class StreamingNoticePanel : PopupPanel
{
	[SerializeField]
	private Image _image;

	[SerializeField]
	private Button _dontShowToday;

	public void Show(int idx, bool preview = false)
	{
	}

	private void OnClickStreaming(int idx)
	{
	}

	public void OnClickDontShowToday()
	{
	}
}
