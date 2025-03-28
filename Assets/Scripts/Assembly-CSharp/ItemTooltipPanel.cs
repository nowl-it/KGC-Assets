using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ItemTooltipPanel : MonoBehaviour
{
	[SerializeField]
	protected Text _nameText;

	[SerializeField]
	protected Text _ownCountText;

	[SerializeField]
	protected Image _itemTypeImage;

	[SerializeField]
	protected Text _itemTypeText;

	[SerializeField]
	protected TextFitter _itemTypeTextFitter;

	[SerializeField]
	protected Border _itemTypeBorder;

	[SerializeField]
	protected Text _itemDescText;

	[SerializeField]
	protected Transform _shortCutButtonLayout;

	[SerializeField]
	protected Button _shortcutLinkPrefab;

	[SerializeField]
	protected Image _partition;

	[SerializeField]
	protected Border _border;

	[SerializeField]
	protected TextFitter _descTextFitter;

	[SerializeField]
	protected ClickOutsideClose _clickOutsideClose;

	protected List<Button> _shortcutButtons;

	protected ResourceInventoryItem _resInventoryItem;

	protected ArtifactModel _artifact;

	protected AccessoryModel _accessory;

	protected int _flagSeason;

	private Vector2? _lastBorder;

	public void Show(ResourceInventoryItem resInventoryItem, int itemId, ArtifactModel artifact = null)
	{
	}

	public void Show(AccessoryModel accessory)
	{
	}

	public virtual void Fit()
	{
	}

	public void Close()
	{
	}

	public Vector2 GetPanelSize()
	{
		return default(Vector2);
	}

	public void SetFlagSeason(int season)
	{
	}

	private void AddShortcutLink()
	{
	}

	public void OnClickShortCut(int idx)
	{
	}
}
