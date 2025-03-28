using System;
using System.Collections.Generic;
using Protocol;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumInvadeShopPanel : MonoBehaviour, IClosable
{
	private static ColosseumInvadeShopPanel _instance;

	[SerializeField]
	private Text _invadePointText;

	[SerializeField]
	private List<ColosseumInvadeTierIcon> _invadeTierProbabilityIcons;

	[SerializeField]
	private List<Text> _invadeTierProbabilityTexts;

	[SerializeField]
	private RectTransform _invadeShopItemsRoot;

	[SerializeField]
	private ColosseumInvadeShopItem _invadeShopItemPrefab;

	[SerializeField]
	private ColosseumInvadePointIndicator _invadePointIndicator;

	[SerializeField]
	private Text _rerollText;

	[SerializeField]
	private Image _rerollTokenIcon;

	[SerializeField]
	private Button _rerollButton;

	[SerializeField]
	private ConditionalGroup _rerollButtonCond;

	[SerializeField]
	private ConditionalGroup _lockButtonCond;

	[SerializeField]
	private ColosseumAbilityPanelItem _expIndicator;

	private List<ResourceColosseumInvadeItem> _resInvadeItems;

	private List<ColosseumInvadeShopItem> _invadeShopItems;

	private ColosseumData _playerColosseumData;

	private bool _setBG;

	[NonSerialized]
	public int rerollCount;

	private bool _rerollByStageEnd;

	public static ColosseumInvadeShopPanel Instance => null;

	private bool _isLocked => false;

	private void Awake()
	{
	}

	private void SetBG()
	{
	}

	public void Show()
	{
	}

	public void Reload(bool reroll = false, bool effect = false)
	{
	}

	private void ReloadTierProbabilities(int[] probability)
	{
	}

	public void ReloadPrices(bool showTokenEffect)
	{
	}

	public void OnClickReroll()
	{
	}

	public void Reroll(bool rerollByStageEnd = false, bool effect = false)
	{
	}

	public List<ResourceColosseumInvadeItem> GetInvadeSpawners(int[] weight)
	{
		return null;
	}

	private int[] GetInvadeItemTierProb()
	{
		return null;
	}

	public void OnClickLock()
	{
	}

	public void UnLock()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void RefreshInvadeItems()
	{
	}

	public void SetRerollButtonInteractable(bool interactable)
	{
	}

	public IReadOnlyList<ResourceColosseumInvadeItem> GetCurrentItems()
	{
		return null;
	}

	public ColosseumInvadeShop WriteSnapshot()
	{
		return null;
	}

	public void LoadFromSnapshot(ColosseumInvadeShop data)
	{
	}
}
