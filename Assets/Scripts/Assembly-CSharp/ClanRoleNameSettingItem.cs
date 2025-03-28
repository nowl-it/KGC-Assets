using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanRoleNameSettingItem : MonoBehaviour
{
	[SerializeField]
	private Text _defaultRoleName;

	[SerializeField]
	private Text _roleName;

	private ChangeClanSettingPanel _changeClanSettingPanel;

	private int _role;

	public void Set(ClanModel clan, int role, string roleName, ChangeClanSettingPanel changeClanSettingPanel)
	{
	}

	public void OnClickChangeRoleName()
	{
	}
}
