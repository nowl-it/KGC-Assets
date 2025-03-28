using System;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactSelectPolishItem : MonoBehaviour
{
	[SerializeField]
	private ArtifactCraftSlot _artifact;

	[SerializeField]
	private GameObject _removeButton;

	[SerializeField]
	private Image _highlight;

	[SerializeField]
	private Text _amountCountText;

	[SerializeField]
	private Text _usingCountText;

	[SerializeField]
	private ClickableShopItemIcon _clickableShopItemIcon;

	public ArtifactModel artifactModel;

	public ResourceArtifact resArtifact;

	private int _ownAmount;

	private int _usingCount;

	private Action _onValueChanged;

	private Func<int, bool> _checkFunc;

	public int usingCount => 0;

	public void Set(ArtifactModel model, Func<int, bool> checkFunc, Action onValueChanged, int index)
	{
	}

	public void AddAmount()
	{
	}

	public void MinusAmount()
	{
	}

	private void OnValueChanged()
	{
	}

	public void ShowArtifactTooltip()
	{
	}
}
