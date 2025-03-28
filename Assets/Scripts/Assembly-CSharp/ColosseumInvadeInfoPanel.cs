using UnityEngine;

public class ColosseumInvadeInfoPanel : MonoBehaviour
{
	public static ColosseumInvadeInfoPanel Instance;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private ColosseumInvadeShopItem _invadeShopItem;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(InvadeItem invadeItem)
	{
	}

	public void OnClickSummonEffectInfoButton()
	{
	}

	public void Hide()
	{
	}
}
