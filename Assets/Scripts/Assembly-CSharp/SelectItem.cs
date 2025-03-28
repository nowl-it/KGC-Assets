using UnityEngine;
using UnityEngine.UI;

public class SelectItem : MonoBehaviour
{
	public Image itemImage;

	public Text nameText;

	public bool selected;

	public ConditionalRootGroup condGroup;

	public ConditionalImage frameImage;

	public Item item;

	public void Set(Item item)
	{
	}

	public void SetToggle(bool on)
	{
	}
}
