using UnityEngine;

public class WebViewBasePanel : MonoBehaviour, IClosable
{
	public RectTransform webViewAreaRect;

	private Canvas _canvas;

	private WebViewObject _webViewObject;

	public virtual void ShowUrl(string url)
	{
	}

	private void Update()
	{
	}

	public void OnClickClose()
	{
	}

	private void Clear()
	{
	}

	private void SetPositionAndSizeByRect()
	{
	}

	private void ShowUrlImpl(string url)
	{
	}

	public virtual bool CanShow()
	{
		return false;
	}

	public bool Close()
	{
		return false;
	}

	private void OnShowWebView(string resultData)
	{
	}
}
