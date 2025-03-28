using UnityEngine;
using UnityEngine.UI;

public class ScrollRect_Popping : MonoBehaviour
{
	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private RectTransform _targetContent;

	[SerializeField]
	private Vector2 _popPos;

	public void OnEnable()
	{
	}
}
