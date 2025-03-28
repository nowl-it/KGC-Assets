using UnityEngine;
using UnityEngine.UI;

public class PackageItemIcon : MonoBehaviour
{
	public Image icon;

	public Text countText;

	public Image frame;

	protected int resourceId;

	public virtual void Init(int resId, int count)
	{
	}

	public virtual void OnClick()
	{
	}
}
