using UnityEngine;
using UnityEngine.UI;

public class BossHpBar : MonoBehaviour
{
	public Gauge gauge;

	public Gauge manaGauge;

	public Gauge buffGauge;

	public Gauge channelingGauge;

	public Gauge groggyGauge;

	public Image levelIcon;

	public Image bossIcon;

	public Image hpGauge;

	[Space(20f)]
	public RectTransform bars;

	public new RectTransform tag;

	public RectTransform box;

	[Space(20f)]
	public GameObject indicator;

	public Image indicatorIcon;

	public Text indicatorText;

	[Space(20f)]
	public GameObject defIndicator;

	public Text defIndicatorText;

	[Space(20f)]
	public GameObject mdefIndicator;

	public Text mdefIndicatorText;
}
