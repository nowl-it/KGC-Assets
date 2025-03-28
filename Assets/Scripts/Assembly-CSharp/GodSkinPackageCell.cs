using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class GodSkinPackageCell : MonoBehaviour
{
	[SerializeField]
	private List<Text> _unitNameText;

	[SerializeField]
	private List<Text> _skinNameText;

	[SerializeField]
	private List<Text> _packageNameText;

	[Space(20f)]
	[SerializeField]
	private List<Transform> _rewardItemsRoot;

	[SerializeField]
	private GameObject _rewardItemPrefab;

	[SerializeField]
	private ClickableShopItemIcon _skinIcon;

	[SerializeField]
	[Space(20f)]
	private Transform _unitParent;

	[SerializeField]
	private Transform _skinParent;

	[SerializeField]
	[Space(20f)]
	private List<Image> _blackMasks;

	[SerializeField]
	private GameObject _swipeArea;

	[SerializeField]
	private CanvasGroup _unitRewardTooltip;

	[SerializeField]
	private Image _godSkinColorFrom;

	private GameObject _unitObj;

	private GameObject _skinObj;

	private int _unitId;

	private int _skinId;

	private bool _alreadyBuyPackage1;

	private Tween _rewardInfoTween;

	public void Set(ResourceShopItem resShopItem, int unitId, int skinId, bool alreadyBuyPackage1 = false)
	{
	}

	private void SetRewardTable(ResourceShopItem resShopItem)
	{
	}

	public void SetBlackMaskAlpha(float alpha)
	{
	}

	public void OnClickUnitRewardInfo()
	{
	}
}
