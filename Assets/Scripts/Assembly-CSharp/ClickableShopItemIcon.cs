using System;
using Awesomepiece;
using Awesomepiece.Model;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class ClickableShopItemIcon : MonoBehaviour
{
	[SerializeField]
	private Text _name;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private Text _countText;

	[SerializeField]
	private GameObject _expText;

	[SerializeField]
	private Button _button;

	[SerializeField]
	private Image _frame;

	[SerializeField]
	private Image _accessoryStatIcon;

	[SerializeField]
	private ConditionalImage _switchFrameConditional;

	[SerializeField]
	private ConditionalGroup _selectedCond;

	[SerializeField]
	[CanBeNull]
	private Image _unitFrame;

	[SerializeField]
	[CanBeNull]
	private Image _unitAvatar;

	[NonSerialized]
	public bool selected;

	private ResourceInventoryItem _resInventoryItem;

	private ResourceArtifact _resArtifact;

	private ResourceTreasure _resTreasure;

	private AccessoryModel _accessory;

	private ResourceFixedAccessoryPreset _resAccessoryPreset;

	private int _itemId;

	private int _flagSeason;

	private int _accessorySynergy;

	private string _countTextFormat;

	private bool _btnInteractable;

	private Action _btnCallback;

	private bool _forceUseCountText;

	private Vector2 _tooltipOffset;

	private ItemTooltipPanel _itemTooltipPanel => null;

	private void Init(Sprite icon, int count, bool showExpText, float scale, string name = null)
	{
	}

	public void SetByCopy(ClickableShopItemIcon icon)
	{
	}

	public void Set(ResourceInventoryItem resInventoryItem, int count, bool showExpText = false, float scale = 1f)
	{
	}

	public void Set(Sprite icon, ResourceInventoryItem resInventoryItem, int count, bool showExpText = false, float scale = 1f)
	{
	}

	public void Set(ResourceArtifact resArtifact, int count, float scale = 1f, float? frameScale = null)
	{
	}

	public void Set(ResourceArtifact resArtifact, float scale = 1f, float? frameScale = null)
	{
	}

	public void SetUnit(int unitId, float scale = 1f)
	{
	}

	public void SetUnitExp(int unitId, int count, float scale = 1f)
	{
	}

	public void SetUnitSoul(int unitId, int count, float scale = 1f)
	{
	}

	public void Set(int skinId, Sprite icon, float scale = 1f)
	{
	}

	public void Set(ResourceTreasure resTreasure, int count, float scale = 1f, float? frameScale = null)
	{
	}

	public void Set(ResourceTreasure resTreasure, float scale = 1f)
	{
	}

	public void Set(ResourceTreasure.Rarity rarity, float scale)
	{
	}

	public void Set(AccessoryModel accessory, int count, float scale = 1f)
	{
	}

	public void Set(AccessoryModel accessory, float scale = 1f)
	{
	}

	public void Set(ResourceFixedAccessoryPreset resAccessoryPreset, int count, float scale = 1f, float? frameScale = null)
	{
	}

	public void Set(ResourceFixedAccessoryPreset resAccessoryPreset, float scale = 1f)
	{
	}

	public void Set(Reward reward, float scale = 1f)
	{
	}

	public void SetRewardItem(Reward reward, ArtifactModel artifact = null, TreasureModel treasure = null, AccessoryModel accessory = null)
	{
	}

	public void SetByAccessorySynergy(int synergy, int count = 0, float scale = 1f)
	{
	}

	public void SetUnclickable(Sprite icon, float scale = 1f, Action callback = null)
	{
	}

	public void SetButtonCallback(Action callback)
	{
	}

	public void SetExceptIcon(ResourceInventoryItem resInventoryItem, float scale = 1f)
	{
	}

	public void SetByThemeRewardIcon(ResourceTheme resTheme, float scale = 1f)
	{
	}

	public void SetByClanBoss(ResourceInventoryItem resInventoryItem, int count, int difficulty, float scale = 1f)
	{
	}

	public void SetIconOffset(Vector2 offset)
	{
	}

	public void SetIconScale(Vector2 scale)
	{
	}

	public void SetIconSize(Vector2 size)
	{
	}

	public void SetItemId(int itemId)
	{
	}

	public void SetFlagSeason(int season)
	{
	}

	public Image GetIcon()
	{
		return null;
	}

	public Text GetNameText()
	{
		return null;
	}

	public Button GetButton()
	{
		return null;
	}

	public Text GetCountText()
	{
		return null;
	}

	public float GetScale()
	{
		return 0f;
	}

	public void SetCountTextFormat(string format)
	{
	}

	public void SetTooltipOffset(Vector2 offset)
	{
	}

	public void MakeOriginSize()
	{
	}

	public void NormalizeInventoryItemSize(float desiredSize)
	{
	}

	public void SetCount(int count)
	{
	}

	public void SetCountColor(Color color)
	{
	}

	public void OnClick()
	{
	}

	public void ShowTooltip(Vector2 offset = default(Vector2))
	{
	}

	public void ForceUseCountText()
	{
	}

	public void SwitchSelected()
	{
	}

	public void SetSelected(bool selected)
	{
	}
}
