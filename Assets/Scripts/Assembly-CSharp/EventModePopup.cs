using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventModePopup : MonoBehaviour, IClosable
{
	public List<Image> modeBG;

	public List<Image> modeUnit;

	public List<Text> modeNameText;

	public List<ClickableShopItemIcon> modeRewardIcon;

	public List<GameObject> dayTextObject;

	public List<Button> button;

	public List<ConditionalGroup> lockedModeConditionals;

	public List<ResourceTheme> modeIds;

	public Text currentFlagText;

	public GameObject flagLeftTime;

	public Text flagLeftTimeText;

	public void Show()
	{
	}

	public void OnClickTheme(int idx)
	{
	}

	public void OnClickBuyTicket()
	{
	}

	public bool Close()
	{
		return false;
	}

	public void OnClickClose()
	{
	}

	private void ReloadFlag()
	{
	}

	public void Update()
	{
	}
}
