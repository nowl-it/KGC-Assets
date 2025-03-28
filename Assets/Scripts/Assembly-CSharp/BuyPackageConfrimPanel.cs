using System;
using UnityEngine;
using UnityEngine.UI;

public class BuyPackageConfrimPanel : BuyConfirmPanel
{
	public Text itemName;

	public Image itemImage;

	public Image boxKeyImage;

	public Text boxKeyCount;

	public Text expCount;

	public Text unitExpCount;

	public Image cashImage;

	public Text cashCount;

	public Image goldImage;

	public Text goldCount;

	public Text skinTokenCount;

	public Image unitImage;

	public GameObject goldIcon;

	public GameObject boxIcon;

	public GameObject expIcon;

	public GameObject cashIcon;

	public GameObject skinTokenIcon;

	public GameObject unitExpIcon;

	public Text upEfficiency;

	public PackageItemArtifactIcon[] artifactIcons;

	public PackageItemTreasureIcon[] treasureIcons;

	public override void Show(ShopItem from, Action callback)
	{
	}
}
