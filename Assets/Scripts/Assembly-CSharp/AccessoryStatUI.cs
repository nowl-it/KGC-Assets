using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class AccessoryStatUI : MonoBehaviour
{
	[SerializeField]
	private ImageTextPair _statPair;

	[SerializeField]
	private Text _statValueText;

	[SerializeField]
	private Text _upgradedStatValueText;

	[SerializeField]
	private GameObject _lockedObj;

	[SerializeField]
	private Text _lockedText;

	[SerializeField]
	private ConditionalGroup _lockCond;

	[SerializeField]
	private Image _whiteFlash;

	private List<Tween> _tweens;

	private Sequence _whiteFlashSequence;

	private List<ulong> _upgradeEffectWorkTimerKeys;

	public void Set(string statName, string statValue, string lockedText = null)
	{
	}

	private void OnDisable()
	{
	}

	public void SetText(string statText)
	{
	}

	public Text GetText()
	{
		return null;
	}

	public void SetUpgradedStatValueText(string statValue)
	{
	}

	public void SetImageColor(Color color)
	{
	}

	public void SetTextColor(Color color)
	{
	}

	public void SetValueTextColor(Color color)
	{
	}

	public void SetLockConditionalValue(int value)
	{
	}

	public void ShowUpgradeEffects(float prevValue, float curValue, float firstPrevValue, string statWord, bool isNewStat, float delay = 0f)
	{
	}

	public void ClearUpgradeEffects()
	{
	}

	private void StopUpgradeEffectWorkTimers()
	{
	}
}
