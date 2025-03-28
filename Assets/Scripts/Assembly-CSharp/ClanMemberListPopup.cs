using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanMemberListPopup : MonoBehaviour, IClosable
{
	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private ConditionalSetActive _joined;

	[SerializeField]
	private Text _memberCountText;

	public void Show(List<ClanMemberModel> members, bool joined, int maxMember, List<ClanModel.RoleName> roleNames)
	{
	}

	public void Reload(List<ClanMemberModel> members, bool joined, int maxMember, List<ClanModel.RoleName> roleNames)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
