using UnityEngine;
using UnityEngine.UI;

public class UnitBalanceInfoItem : MonoBehaviour
{
	[SerializeField]
	private Image _unitAvatar;

	[SerializeField]
	private Text _unitName;

	[SerializeField]
	private ConditionalGroup _damageModulatorSign;

	[SerializeField]
	private ConditionalGroup _defenseModulatorSign;

	[SerializeField]
	private Text _damageModulatorText;

	[SerializeField]
	private Text _defenseModulatorText;

	public void Set(int unitId, int theme)
	{
	}
}
