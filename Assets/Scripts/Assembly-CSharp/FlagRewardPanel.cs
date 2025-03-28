using System;
using System.Collections.Generic;
using UnityEngine;

public class FlagRewardPanel : MonoBehaviour, IClosable, IComponentConnector
{
	[Serializable]
	public enum Type
	{
		PvP = 0,
		Tower = 1,
		Colosseum = 2
	}

	public Type type;

	[ComponentConnect]
	public FlagPreviewTab flagPreview;

	[ComponentConnect]
	public RectTransform flagsLayout;

	[ComponentConnect]
	public GameObject flagRewardCellPrefab;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	private readonly List<FlagRewardCell> _viewFlags;

	private FlagRewardCell _viewEquippedFlag;

	private int _equippedIndex;

	public void Show()
	{
	}

	private void SetFlagInfoUI(FlagRewardCell cell, int season)
	{
	}

	private void LoadRewardFlags()
	{
	}

	private int GetTier(Type type)
	{
		return 0;
	}

	private int GetFlagResourceIdOffset(Type type)
	{
		return 0;
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
