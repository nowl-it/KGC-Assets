using UnityEngine;
using UnityEngine.UI;

public class AccessorySynergyTextItem : MonoBehaviour
{
	[SerializeField]
	private Text _countText;

	[SerializeField]
	private Text _effectText;

	[SerializeField]
	private TextFitter _textFitter;

	[SerializeField]
	private Border _border;

	public void Set(ResourceAccessorySynergyBuff resSynergy, int synergyCount)
	{
	}
}
