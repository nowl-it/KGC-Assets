using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstStepPackagePanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _timeText;

	[SerializeField]
	private ScrollRect _scrollArea;

	[SerializeField]
	private Transform _arrowArea;

	[SerializeField]
	private GridLayoutGroup _firstStepPackageItemArea;

	[SerializeField]
	private FirstStepPackageItem _firstStepPackageItemPrefab;

	private List<FirstStepPackageItem> _firstStepPackageItems;

	private Action _onClose;

	public void Show()
	{
	}

	public void Reload()
	{
	}

	public void Scroll()
	{
	}

	public void Update()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	private int GetSnakeIndex(int idx, bool useRightCorner)
	{
		return 0;
	}

	private FirstStepPackageItem.ArrowDirection GetArrowDirection(int idx, bool useRightCorner)
	{
		return default(FirstStepPackageItem.ArrowDirection);
	}
}
