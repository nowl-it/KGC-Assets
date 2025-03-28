using DG.Tweening;
using UnityEngine;

public class TweenTab : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public TabComponent tabComponent;

	public GameObject notification;

	private bool _opened;

	private Tweener _tweener;

	private float _selectedWidth;

	private float _normalWidth;

	public int index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool opened => false;

	public void Init(float selectedWidth, float normalWidth)
	{
	}

	public void SetToggle(bool v)
	{
	}

	public void SetNewMark(bool v)
	{
	}
}
