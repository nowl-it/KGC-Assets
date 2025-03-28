using UnityEngine;
using UnityEngine.UI;

public class SynergyInfoPanel : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[ComponentConnect]
	public Text descText;

	[ComponentConnect]
	public Image descIcon;

	public void Show(ResourceSynergy synergy)
	{
	}

	public void Update()
	{
	}
}
