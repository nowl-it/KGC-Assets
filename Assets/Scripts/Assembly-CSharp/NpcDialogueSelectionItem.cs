using UnityEngine;
using UnityEngine.UI;

public class NpcDialogueSelectionItem : MonoBehaviour
{
	[ComponentConnect]
	public Text content;

	[ComponentConnect]
	public GameObject costBox;

	[ComponentConnect]
	public Text costText;

	private int _idx;

	public void Set(int idx, DialogueSelection selection)
	{
	}

	public void OnClick()
	{
	}
}
