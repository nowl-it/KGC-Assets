using UnityEngine;

public class TabManager : MonoBehaviour
{
	public delegate void OnClickTab(int idx);

	public enum ToggleType
	{
		None = 0,
		GameObjectSwap = 1,
		Color = 2,
		Sprite = 3,
		MultiSprite = 4
	}

	public enum TextToggleType
	{
		None = 0,
		Color = 1,
		ColorAndOutline = 2
	}

	public int index;

	public TabComponent tabPrefab;

	public TabComponent[] tabs;

	public GameObject[] objects;

	[Space(10f)]
	public ToggleType toggleType;

	[Space(10f)]
	public TextToggleType textToggleType;

	[HideInInspector]
	public Color normalColor;

	[HideInInspector]
	public Color selectedColor;

	[HideInInspector]
	public Sprite normalSprite;

	[HideInInspector]
	public Sprite selectedSprite;

	[HideInInspector]
	public Sprite leftNormalSprite;

	[HideInInspector]
	public Sprite leftSelectedSprite;

	[HideInInspector]
	public Sprite centerNormalSprite;

	[HideInInspector]
	public Sprite centerSelectedSprite;

	[HideInInspector]
	public Sprite rightNormalSprite;

	[HideInInspector]
	public Sprite rightSelectedSprite;

	[HideInInspector]
	public Color normalTextColor;

	[HideInInspector]
	public Color selectedTextColor;

	private OnClickTab _callback;

	public int maxIndex => 0;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(OnClickTab callback)
	{
	}

	public void Init(int count, string[] names, OnClickTab callback)
	{
	}

	public void OnClick(TabComponent tab)
	{
	}

	public void OnClick(int idx)
	{
	}

	private Sprite GetMultiSprite(int i, bool selected)
	{
		return null;
	}
}
