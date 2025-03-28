using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabelPassPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text _babelName;

	[SerializeField]
	private Text _babelCannotRefund;

	[SerializeField]
	private Button _leftButton;

	[SerializeField]
	private Button _rightButton;

	[SerializeField]
	private Image[] _flagImages;

	[SerializeField]
	private UIGridView _layout;

	private List<BabelPassItem> _items;

	private List<ResourceBabel> _babelList;

	private int _currentBabelIdx;

	public void Show(int babelId)
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

	public void OnClickLeft()
	{
	}

	public void OnClickRight()
	{
	}

	public void PropagateSoldOutState()
	{
	}
}
