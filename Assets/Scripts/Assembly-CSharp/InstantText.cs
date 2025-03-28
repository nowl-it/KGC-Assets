using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text), typeof(RectTransform))]
public class InstantText : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public Text text;

	[GetComponent]
	public Outline textOutline;

	public void Show(Vector2 position, string content)
	{
	}
}
