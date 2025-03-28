using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ClanMemberListItem : MonoBehaviour
{
	[ComponentConnect]
	public Text roleText;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public Text weeklyText;

	[ComponentConnect]
	public Text lastLoginedText;

	[ComponentConnect]
	public PlayerProfile playerProfile;

	[ComponentConnect]
	public GameObject masterIcon;

	[ComponentConnect]
	public GameObject subMasterIcon;

	[ComponentConnect]
	public RectTransform nameBox;

	[ComponentConnect]
	public RectTransform weeklyBox;

	[SerializeField]
	private Text levelText;

	private ClanMemberModel _model;

	public void Set(ClanMemberModel model, bool showWeekly, List<ClanModel.RoleName> roleNames)
	{
	}

	public void OnClickProfile()
	{
	}
}
