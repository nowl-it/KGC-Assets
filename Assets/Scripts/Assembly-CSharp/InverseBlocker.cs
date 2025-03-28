using UnityEngine;
using UnityEngine.UI;

public class InverseBlocker : MonoBehaviour
{
	public Color blockColor;

	[GetComponent]
	public RectTransform rectTransform;

	[SerializeField]
	private Image[] _blocks;

	[SerializeField]
	public Image[] blocks => null;

	public void Set(bool set, RectTransform target = null, Canvas canvas = null)
	{
	}
}
