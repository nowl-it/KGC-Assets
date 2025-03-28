using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PassLevelItem : MonoBehaviour
{
	[ComponentConnect]
	public ConditionalGroup levelBox;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	[Space(20f)]
	public Text baseStateText;

	[ComponentConnect]
	public ClickableShopItemIcon baseItemIcon;

	[ComponentConnect]
	public Text baseItemNameText;

	[ComponentConnect]
	public GameObject baseReceived;

	public Image baseReceivableFrame;

	public Image baseReceivableEffect;

	private Tween _baseReceivableEffectTween;

	[ComponentConnect]
	[Space(20f)]
	public Text passStateText;

	[ComponentConnect]
	public ClickableShopItemIcon passItemIcon;

	[ComponentConnect]
	public Text passItemNameText;

	[ComponentConnect]
	public GameObject passOnlyReceived;

	public Image passReceivableFrame;

	public Image passReceivableEffect;

	private Tween _passReceivableEffectTween;

	[ComponentConnect]
	[Space(20f)]
	public Text premiumStateText;

	[ComponentConnect]
	public ClickableShopItemIcon premiumItemIcon;

	[ComponentConnect]
	public Text premiumItemNameText;

	[ComponentConnect]
	public GameObject premiumOnlyReceived;

	public Image premiumReceivableFrame;

	public Image premiumReceivableEffect;

	private Tween _premiumReceivableEffectTween;

	[ComponentConnect]
	[Space(20f)]
	public Text bonusStateText;

	[ComponentConnect]
	public ClickableShopItemIcon bonusItemIcon;

	[ComponentConnect]
	public Text bonusItemNameText;

	[ComponentConnect]
	public Text bonusDescText;

	[ComponentConnect]
	public Text bonusRemainText;

	[ComponentConnect]
	public GameObject bonusReceived;

	public Image bonusReceivableFrame;

	public Image bonusReceivableEffect;

	private Tween _bonusReceivableEffectTween;

	[Space(20f)]
	[ComponentConnect]
	public GameObject buyLevelBox;

	[ComponentConnect]
	public ConditionalGroup buyLevelButton;

	[ComponentConnect]
	public GameObject lockedBox;

	[ComponentConnect]
	public GameObject lockedBoxBonus;

	public ConditionalGroup baseGroup;

	public ConditionalGroup passGroup;

	public ConditionalGroup premiumGroup;

	public ConditionalGroup bonusGroup;

	private ResourceSeasonPass _resSeasonPass;

	private int _level;

	private int _bonusId;

	private List<Image> _activatedReceivableEffects;

	public void Set(ResourceSeasonPass resSeasonPass, int level, int currentLevel)
	{
	}

	public void SetBonus(ResourceSeasonPass resSeasonPass, int bonusId, int currentLevel)
	{
	}

	private void Update()
	{
	}

	public static string GetNameText(string rewardType, int id, int count)
	{
		return null;
	}

	public void OnClickBaseReward()
	{
	}

	public void OnClickPassOnlyReward()
	{
	}

	public void OnClickPremiumOnlyReward()
	{
	}

	public void OnClickBonusReward()
	{
	}

	public void OnClickBuyLevel()
	{
	}
}
