using System;
using UnityEngine;
using UnityEngine.UI;

public class TODOListItem : MonoBehaviour
{
	public ConditionalRoot conditionalRoot;

	public GameObject mask;

	public GameObject skinSprite;

	public GameObject skinPrefab;

	public ClickableShopItemIcon clickableIcon;

	public Text title;

	public Text desc;

	private Action _callback;

	private ResourceSkin _resourceSkin;

	public void Init(TODOListPanel.TodoListInfo todoListInfo)
	{
	}

	private void ReloadSkin()
	{
	}

	public void ShowSkinPrefab(string prefabName)
	{
	}

	public void OnClick()
	{
	}
}
