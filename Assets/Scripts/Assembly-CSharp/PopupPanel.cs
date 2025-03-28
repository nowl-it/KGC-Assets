using UnityEngine;

public class PopupPanel : MonoBehaviour, IClosable
{
	public virtual void Show()
	{
	}

	public virtual void OnClickClose()
	{
	}

	public virtual bool Close()
	{
		return false;
	}
}
