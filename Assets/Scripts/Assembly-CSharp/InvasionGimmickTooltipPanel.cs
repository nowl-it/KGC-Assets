using UnityEngine;
using UnityEngine.UI;

public class InvasionGimmickTooltipPanel : MonoBehaviour, IClosable
{
	[SerializeField]
	private Text[] _gimmickText;

	[SerializeField]
	private Text _gimmickResultText;

	[SerializeField]
	private Image[] _highlightImages;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private Text _gimmickCountText;

	public void Show(ResourceTheme resTheme)
	{
	}

	private void SetGimmickObject(int gimmickValue)
	{
	}

	public void OnClickClose()
	{
	}

	public bool Close()
	{
		return false;
	}
}
