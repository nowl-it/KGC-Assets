using System;
using UnityEngine;
using UnityEngine.UI;

public class EliteItem : MonoBehaviour
{
	public Text descText;

	public Button upButton;

	public Button downButton;

	public Text ratioText;

	private int _level;

	private int _maxLevel;

	private int _ratio;

	private string _desc;

	private Func<int, string> _descFormat;

	private Action<int> _callback;

	private ResourceEliteLevel _resEliteLevel;

	private IElitePanel _panel;

	public int level => 0;

	public void Set(IElitePanel panel, int level, int maxLevel, int ratio, Func<int, string> descFormat, Action<int> callback)
	{
	}

	public void Set(IElitePanel panel, int level, ResourceEliteLevel resEliteLevel, Action<int> callback)
	{
	}

	public void Reload()
	{
	}

	public void OnClickUp()
	{
	}

	public void OnClickDown()
	{
	}
}
