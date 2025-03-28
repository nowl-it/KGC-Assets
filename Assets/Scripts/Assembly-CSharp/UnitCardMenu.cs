using System;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardMenu : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	public Text[] menuTexts;

	private Action<int> _callback;

	public void Show(Vector2 position, string[] texts, Action<int> callback)
	{
	}

	public void OnClickMenu(int idx)
	{
	}

	public void Update()
	{
	}
}
