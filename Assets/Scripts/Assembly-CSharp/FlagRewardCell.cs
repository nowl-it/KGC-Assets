using UnityEngine;
using UnityEngine.UI;

public class FlagRewardCell : MonoBehaviour
{
	public Text tierDesc;

	public Image tierImage;

	public Image leftNameTagImage;

	public Image rightNameTagImage;

	public ClickableShopItemIcon nameTagFrameImage;

	public ClickableShopItemIcon flagImage;

	public Button button;

	[SerializeField]
	private GameObject eqipedFrame;

	public ResourceFlag resFlag;

	public ResourceNameTag resNameTag;

	public FlagRewardCell Set(int flagId)
	{
		return null;
	}

	public FlagRewardCell SetEquiped(bool equiped)
	{
		return null;
	}

	public void OnClickCellItem(bool isFlag)
	{
	}
}
