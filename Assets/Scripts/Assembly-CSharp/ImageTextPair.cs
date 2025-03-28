using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]
[ExecuteInEditMode]
public class ImageTextPair : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	public Image image;

	public Text text;

	public float widthSpace;

	public Image[] otherImages;

	public void Set(Sprite sprite, string text, bool makeOriginSize = false)
	{
	}

	public void Set(Sprite sprite, int v, bool makeOriginSize = false)
	{
	}

	public void SetSprite(Sprite sprite, bool makeOriginSize = false)
	{
	}

	public void SetOtherSprite(int idx, Sprite sprite, float offsetY = 0f)
	{
	}

	public Image GetOtherSprite(int idx)
	{
		return null;
	}

	public void SetText(string text)
	{
	}

	public void SetText(int v)
	{
	}

	public void SetTextColor(Color c)
	{
	}

	public void SetSpace(float space)
	{
	}

	public void Reload()
	{
	}

	private void ReloadSize()
	{
	}
}
