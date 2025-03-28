using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class InvasionRewardPanelRewardItem : MonoBehaviour
{
	[SerializeField]
	private ClickableShopItemIcon _clickableShopItemIcon;

	[SerializeField]
	private GameObject _lockedObject;

	[SerializeField]
	private GameObject _canReceiveObject;

	[SerializeField]
	private GameObject _receivedObject;

	[SerializeField]
	private RectMask2D _iconMask;

	private InvasionRewardPanelMissionItem _missionItem;

	private int _pass;

	public void Set(InvasionRewardPanelMissionItem missionItem, Reward reward, int receiveState, int pass, bool hasPass)
	{
	}

	public void OnClick()
	{
	}
}
