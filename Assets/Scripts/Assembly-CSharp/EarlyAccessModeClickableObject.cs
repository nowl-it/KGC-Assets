using UnityEngine;
using UnityEngine.UI;

public class EarlyAccessModeClickableObject : MonoBehaviour
{
	[SerializeField]
	private Button.ButtonClickedEvent _onClick;

	public Button.ButtonClickedEvent onClick => null;

	public static void BlockClicking()
	{
	}

	public void DoNothing()
	{
	}

	public void OnClickSettingsButton()
	{
	}
}
