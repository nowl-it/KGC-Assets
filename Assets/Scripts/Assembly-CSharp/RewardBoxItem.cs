using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RewardBoxItem : MonoBehaviour
{
	public enum Type
	{
		Gold = 0,
		Exp = 1,
		SelectUnitExp = 2,
		Artifact = 3,
		PassPoint = 4,
		SeasonalEventToken = 5,
		ClanPoint = 6,
		HardModeToken = 7,
		Accessory = 8,
		HardModeToken2 = 9,
		InventoryItem = 10
	}

	public Image icon;

	public Text valueText;

	public DraggableArtifactCard artifactCard;

	public ConditionalSetActive hotTimeBox;

	public Text hotTimeValueText;

	[Header("Accessory")]
	public Image _accessoryFrame;

	public Image _accessoryStat;

	public Image lockIcon;

	public ConditionalGroup selectedConditional;

	[NonSerialized]
	public AccessoryModel accessoryModel;

	[NonSerialized]
	public bool selected;

	[NonSerialized]
	public bool cleanUpMode;

	[NonSerialized]
	public Type type;

	[NonSerialized]
	public int id;

	[NonSerialized]
	public int value;

	public void Init(Type type, int id, int value, int hotTimeBonusValue = 0)
	{
	}

	public void Init(AccessoryModel accessoryModel)
	{
	}

	public void OnLongPress()
	{
	}

	public void OnClick()
	{
	}

	public void CleanUpMode(bool set)
	{
	}

	public void ToggleSelected()
	{
	}

	public void ShowTooltip(Vector2 offset = default(Vector2))
	{
	}
}
