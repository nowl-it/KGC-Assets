using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ReloadGaugeGroup : MonoBehaviour
{
	public static ReloadGaugeGroup instance;

	public GameObject playerReloadGaugeObj;

	public Image playerReloadGauge;

	public GameObject uiReloadGaugeObj;

	public Image uiReloadGauge;

	private Sequence _sequence;

	public void Awake()
	{
	}

	public void Show(float time)
	{
	}

	public void Hide()
	{
	}
}
