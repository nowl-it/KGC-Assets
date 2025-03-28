using System;
using UnityEngine;
using UnityEngine.UI;

public class AccessorySynergyBuffIcon : MonoBehaviour
{
	[SerializeField]
	private Image _borderImage;

	[SerializeField]
	private Text _synergyCountText;

	[SerializeField]
	private ConditionalImage _synergyCountImage;

	[SerializeField]
	private Image _synergyIcon;

	[SerializeField]
	private Button _button;

	[NonSerialized]
	public int synergy;

	[NonSerialized]
	public int count;

	private Action _callback;

	public void Set(int synergy, int count, Action callback = null)
	{
	}

	private void OnDestroy()
	{
	}
}
