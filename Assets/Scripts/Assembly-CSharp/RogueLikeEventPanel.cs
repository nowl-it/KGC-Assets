using System.Collections.Generic;
using UnityEngine;

public class RogueLikeEventPanel : MonoBehaviour
{
	public ResourceRogueLikeEvent.Option selectedOption { get; set; }

	public virtual void BeforeOpen(bool isRepeat)
	{
	}

	public virtual void OnClickOption(GameObject go, ResourceRogueLikeEvent.Option option)
	{
	}

	public virtual void SetItem(int index, Constants.RogueLikeItemType type, int tier, int id, int amount, string icon = null, string customText = null)
	{
	}

	public virtual void SetItemOwnedItem(int index, Item item, GameUnit equippedBy)
	{
	}

	public virtual void Show(ResourceRogueLikeEvent resEvent, List<ResourceRogueLikeEvent.Option> options)
	{
	}

	public virtual void SetDesc(string desc)
	{
	}

	public virtual void ShowResult(ResourceRogueLikeEvent.Result result, bool isSuccess)
	{
	}

	public virtual void SetButtonText(string text)
	{
	}

	public virtual void BlockClickItem(bool block)
	{
	}

	public virtual void SetRewardLeftText(int curCount, int totalCount)
	{
	}

	public void SelectOption(ResourceRogueLikeEvent.Option option)
	{
	}

	public virtual void Close()
	{
	}
}
