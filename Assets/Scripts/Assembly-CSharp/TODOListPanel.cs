using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TODOListPanel : MonoBehaviour, IClosable
{
	public struct TodoListInfo
	{
		public Sprite icon;

		public ResourceSkin resSkin;

		public ResourceInventoryItem resInventoryItem;

		public Vector2 iconOffset;

		public Vector2 iconScale;

		public string title;

		public string desc;

		public Action action;

		public bool special;

		public bool news;
	}

	public UITableView tableView;

	public Button updateNoticeButton;

	private bool _showAll;

	private List<TodoListInfo> _todoLists;

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	private void Update()
	{
	}

	public void OnClickShowNotice()
	{
	}

	private void ShowAll()
	{
	}

	public List<TodoListInfo> GetTODOList()
	{
		return null;
	}
}
