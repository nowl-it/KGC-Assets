using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class PvPRewardPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public ScrollRect scrollView;

	public RectTransform scrollContents;

	private readonly List<PvPRewardTierItem> _items;

	public PvPRewardTierItem tier0;

	public PvPRewardTierItem tierUpper;

	[ComponentConnect]
	public Button upButton;

	[ComponentConnect]
	public Button downButton;

	[ComponentConnect]
	public RectTransform myPoint;

	public GameObject pvpRewardRoot;

	public GameObject pvpSeasonRewardRoot;

	public FlagRewardPanel pvpFlagRewardRoot;

	public Text seasonRewardTitle;

	public Image[] challengerRewards;

	[SerializeField]
	private Image flagImage;

	[SerializeField]
	private List<Text> flagRewardTexts;

	private bool _inited;

	private Tween _scrollTween;

	private PvPRewardTierItem _curTier;

	private bool _isColosseum;

	private float _myTierPos => 0f;

	public void Show()
	{
	}

	public void SetType(bool isColosseum)
	{
	}

	public void Reload()
	{
	}

	public void OnScrollChanged()
	{
	}

	public void OnClickUpButton()
	{
	}

	public void OnClickDownButton()
	{
	}

	public void ShowMyRank(bool force = false)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}

	public static bool NewRewardExist(bool isColosseum)
	{
		return false;
	}

	public void OnClickArenaSeasonRewardOpen()
	{
	}

	public void OnArenaSeasonRewardClose()
	{
	}

	private static (int, int, int, List<int>, int) GetRewardData(bool isColosseum)
	{
		return default((int, int, int, List<int>, int));
	}

	private static List<IResourceRankTier> GetRankTiers(bool isColosseum)
	{
		return null;
	}

	public static int GetReceivableRewardCount(bool isColosseum)
	{
		return 0;
	}
}
