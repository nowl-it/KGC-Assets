using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeToReturnPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private List<Text> _rewardTexts;

	[SerializeField]
	private Text _duringDateText;

	private Action _onClose;

	public void Show()
	{
	}

	public void SetOnClose(Action onClose)
	{
	}

	private void Reload()
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
