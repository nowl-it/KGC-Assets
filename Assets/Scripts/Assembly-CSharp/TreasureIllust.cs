using System;
using UnityEngine;
using UnityEngine.UI;

public class TreasureIllust : MonoBehaviour
{
	public Image illustImage;

	public Image illustBGImage;

	public Image gradationImage;

	public HqTreasureIllustPopup _hqIllustPopup;

	[NonSerialized]
	public Vector3 illustOriginPos;

	public ResourceTreasure resTreasure;

	private bool _isPositionInitialized;

	public void Set(int treasureId)
	{
	}

	public void SetDefault()
	{
	}

	public void HideGradation()
	{
	}
}
