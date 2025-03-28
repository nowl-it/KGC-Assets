using UnityEngine;
using UnityEngine.UI;

public class FlagInfoItem : MonoBehaviour
{
	public Image flagImage;

	public GameObject normalFrame;

	public GameObject equipedFrame;

	public GameObject equipped;

	public GameObject noItem;

	public Transform flagParent;

	public ResourceFlag resFlag;

	public int season;

	public void Set(ResourceFlag resFlag, int season)
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void SetEquipped(bool selected)
	{
	}
}
