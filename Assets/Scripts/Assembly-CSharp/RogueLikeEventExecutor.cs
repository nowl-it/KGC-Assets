using System;
using System.Collections.Generic;
using UnityEngine;

public class RogueLikeEventExecutor
{
	private ResourceRogueLikeEvent.Executor _executor;

	private string _currentPanel;

	public ResourceRogueLikeEvent.Executor executor => null;

	public void StartEvent(ResourceRogueLikeEvent resEvent)
	{
	}

	public void StartEvent(ResourceRogueLikeEvent.Executor.SaveData executorSaveData)
	{
	}

	private void OpenPanel()
	{
	}

	public void ClosePanel()
	{
	}

	public void SetItem(int index, Constants.RogueLikeItemType type, int tier, int id, int amount, string icon, string customText)
	{
	}

	public void SetItemOwnedItem(int index, Item item, GameUnit equippedBy)
	{
	}

	public void SetDesc(string desc)
	{
	}

	public void ShowResult(int rewardIndex, bool isSuccess)
	{
	}

	public void SetButtonText(string text)
	{
	}

	public void BlockClickItem(bool block)
	{
	}

	public void SelectOption(int index)
	{
	}

	public void SetRewardLeftText(int curCount, int totalCount)
	{
	}

	private void WithPanel(string name, Action<RogueLikeEventPanel> func)
	{
	}

	public List<ResourceRogueLikeEvent.Option> GetVisibleOptions()
	{
		return null;
	}

	public bool Execute(Transform selectPanelRoot, ResourceRogueLikeEvent.Option option)
	{
		return false;
	}

	public ResourceRogueLikeEvent.Executor.SaveData GetExecutorSaveData()
	{
		return null;
	}
}
