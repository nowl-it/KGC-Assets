using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class CatalystItemToggle : MonoBehaviour
{
	[SerializeField]
	private Toggle _toggle;

	[SerializeField]
	private ConditionalGroup _selectConditional;

	[SerializeField]
	private Image _catalystIcon;

	public ResourceArtifact resCatalyst;

	public ArtifactModel catalyst;

	public bool isOn => false;

	public void Init(int catalystId)
	{
	}

	public void OnValueChanged()
	{
	}

	public void Clear()
	{
	}
}
