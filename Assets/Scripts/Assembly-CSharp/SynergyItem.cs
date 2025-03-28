using System;
using UnityEngine;
using UnityEngine.UI;

public class SynergyItem : MonoBehaviour
{
	[ComponentConnect]
	public Image icon;

	[ComponentConnect]
	public Text nameText;

	private Action<SynergyItem> _onClickCallback;

	private ResourceSynergy _synergy;

	public ResourceSynergy synergy => null;

	public void Set(ResourceSynergy synergy, Action<SynergyItem> onClickCallback = null)
	{
	}

	public void OnClick()
	{
	}
}
