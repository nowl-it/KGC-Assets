using System;
using UnityEngine;
using UnityEngine.UI;

public class SkinInfoItem : MonoBehaviour
{
	public Image skinImage;

	public GameObject[] selectedObjs;

	public GameObject equipped;

	public GameObject noItem;

	public ResourceUnit resUnit;

	public ResourceSkin resSkin;

	[NonSerialized]
	public bool isDefault;

	public void Set(ResourceSkin resourceSkin, SkinInfoPanel.SkinInfoPanelData data, bool selected = false, bool isShowingCatalog = false)
	{
	}

	public void SetSkinImage(ResourceSkin resourceSkin, SkinInfoPanel.SkinInfoPanelData data)
	{
	}

	public void SetDefault(int id, SkinInfoPanel.SkinInfoPanelData skinInfoData)
	{
	}

	private void SetDefaultImage()
	{
	}

	public void SetSelected(bool v)
	{
	}
}
