using UnityEngine;

public class StartGrandArenaPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private UIFitter[] _uiFitters;

	public void Show()
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
