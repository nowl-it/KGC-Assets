using UnityEngine;
using UnityEngine.UI;

public class PvPDeckSetGameOverPanel : MonoBehaviour
{
	[ComponentConnect]
	public CanvasGroup confirmButton;

	public ConditionalRoot conditionalRoot;

	public RectTransform divinePowerTab;

	public GameObject divinePowerObject;

	public Text divinePowerText;

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}
}
