using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRaidDeckPreviewPanel : DeckPreviewPanel
{
	[SerializeField]
	private Image _divinePowerGauge;

	[SerializeField]
	private Text _divinePowerText;

	[SerializeField]
	private Text _divinePowerPercentText;

	[SerializeField]
	private Image _remainTimeGauge;

	[SerializeField]
	private Text _remainTimeText;

	private float _divineGaugeOriginLength;

	private float _remainTimeGaugeOriginLength;

	private void Awake()
	{
	}

	public void Show(ClanRaidDeckInfo deckInfo)
	{
	}

	private void SetGauge(float divinePower, float remainTime)
	{
	}
}
