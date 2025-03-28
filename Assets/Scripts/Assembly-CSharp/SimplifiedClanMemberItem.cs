using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class SimplifiedClanMemberItem : MonoBehaviour
{
	[SerializeField]
	[ComponentConnect]
	private Transform _avatar;

	[ComponentConnect]
	[SerializeField]
	private Text _roleName;

	[ComponentConnect]
	[SerializeField]
	private Text _userName;

	private GameObject _character;

	private ClanMemberModel _memberModel;

	public void Set(ClanMemberModel memberModel, List<ClanModel.RoleName> roleNames)
	{
	}

	public void OnClickProfile()
	{
	}
}
