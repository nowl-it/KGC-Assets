using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColosseumCustomMatchSelectBotPopup : MonoBehaviour, IClosable
{
	[SerializeField]
	private GameObject _botItemPrefab;

	[SerializeField]
	private RectTransform _botItemLayout;

	[SerializeField]
	private Text _selectedBotText;

	private readonly List<ColosseumCustomMatchSelectBotItem> _bots;

	private List<int> _ranks;

	private int _slotIdx;

	private bool _initialized;

	public int selectedSlotIdx => 0;

	public void Show(int slotIdx)
	{
	}

	public void OnClickBotItem(ColosseumCustomMatchSelectBotItem item)
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
