using UnityEngine;
using UnityEngine.UI;

public class TabComponent : MonoBehaviour
{
	public int index;

	public Image targetImage;

	public Text targetText;

	public Sprite normalImage;

	public Sprite selectedImage;

	public GameObject selectedObject;

	public GameObject disabledObject;

	public Text[] tabTexts;

	public string tabTextKey;

	public void SetSelected(bool selected)
	{
	}

	public void SetSelectedToChildResponses(bool selected)
	{
	}

	public void SetTabText(string value)
	{
	}
}
