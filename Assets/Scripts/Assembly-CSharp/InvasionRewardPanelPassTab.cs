using UnityEngine;
using UnityEngine.UI;

public class InvasionRewardPanelPassTab : MonoBehaviour
{
	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private Image _tabImage;

	[SerializeField]
	private Text _badgeCountText;

	public int index { get; private set; }

	public void Init(Sprite[] iconSprites, int index, int receivableRewardCount)
	{
	}

	public void ReloadBadge(int receivableRewardCount)
	{
	}

	public void SetSelected(bool isSelected)
	{
	}

	public void OnClick()
	{
	}
}
