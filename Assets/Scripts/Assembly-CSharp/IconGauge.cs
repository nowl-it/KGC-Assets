using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconGauge : MonoBehaviour
{
	public GameObject prefab;

	public int numberUnit;

	private int _maxValue;

	private int _value;

	private List<IconGaugeItem> _items;

	private GridLayoutGroup _layout;

	private Sprite _sprite;

	public int maxValue => 0;

	public int value => 0;

	public void Start()
	{
	}

	public void Init(int maxValue, int value)
	{
	}

	public void SetValue(int v)
	{
	}

	private void Clear()
	{
	}

	private void MakeIcon(int v)
	{
	}

	public void SetSprite(Sprite sprite)
	{
	}
}
