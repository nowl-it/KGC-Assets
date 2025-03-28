using System;
using UnityEngine;
using UnityEngine.UI;

public class NewUnitPopupItem : MonoBehaviour
{
	public Text packageNameText;

	public Text packageDescText;

	public ProfileAvatar profile;

	private int unitId;

	private Action onClickNo;

	public void Init(int unitId, Action onClickNo)
	{
	}

	public void OnClickDetail()
	{
	}
}
