using UnityEngine;
using UnityEngine.UI;

public class UnitInfoPanelBase : MonoBehaviour
{
	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text levelText;

	[ComponentConnect]
	public Image unitImage;

	[ComponentConnect]
	public Text atkText;

	[ComponentConnect]
	public Text matkText;

	[ComponentConnect]
	public Text atkSpeedText;

	[ComponentConnect]
	public Gauge hpGauge;

	[ComponentConnect]
	public Gauge mpGauge;

	[ComponentConnect]
	public Gauge overMpGauge;

	[ComponentConnect]
	public Gauge techniqueGauge;

	[ComponentConnect]
	public Text skillNameText;

	[ComponentConnect]
	public Text skillTierText;

	[ComponentConnect]
	public Text skillDescText;

	public TextFitter skillDescTextFitter;

	[ComponentConnect]
	public Image skillIconImage;

	[GetComponent]
	public ConditionalGroup tierCondGroup;

	[ComponentConnect]
	public GameObject skillArea;

	private GameUnit _target;

	private int _lastMAtk;

	private int _lastSkillID;

	private bool _skillLongDesc;

	public void Set(GameUnit target, bool skillLongDesc, bool showMaxHp = false)
	{
	}

	public void Reload()
	{
	}

	private ResourceSkill GetCurrentSkill()
	{
		return null;
	}

	public void ReloadSkillDesc(bool ignoreLastSkill = false)
	{
	}
}
