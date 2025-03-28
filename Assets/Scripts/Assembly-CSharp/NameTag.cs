using UnityEngine;
using UnityEngine.UI;

public class NameTag : MonoBehaviour
{
	[SerializeField]
	private Image _castleNameImage;

	[SerializeField]
	private Image _kingNameImage;

	[SerializeField]
	private Image _avatarFrameImage;

	private ResourceNameTag _resNameTag;

	public void Set(ResourceNameTag resNameTag)
	{
	}

	public void ShowNameTagWings(bool show)
	{
	}

	public Transform GetAvatarRoot()
	{
		return null;
	}

	public string GetPrefabName()
	{
		return null;
	}
}
