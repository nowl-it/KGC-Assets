using UnityEngine;
using UnityEngine.UI;

public class GachaItem : ShopItem
{
	public Image bg;

	public Sprite[] backGroundImages;

	public ConditionalRoot backGroundRoot;

	public Sprite[] stackIcons;

	public Sprite[] stackBGIcons;

	public GameObject[] tierTag;

	public Image[] stacks;

	public Image[] stackBGs;

	public GameObject freeAfter;

	public Text freeAfterText;

	private int _keyCount;

	public int keyCount => 0;

	public void SetStack(int stack)
	{
	}

	public void SetFreeTime(bool free, string text = "")
	{
	}

	public override void SetFree(bool v)
	{
	}

	public void SetKey(int count)
	{
	}

	public override void ReloadPrice()
	{
	}

	public override bool CanBuy(int count = 1, bool checkKeyItem = true)
	{
		return false;
	}
}
