using System.Collections.Generic;
using Awesomepiece;
using UnityEngine;
using UnityEngine.UI;

public class GachaResultTable : MonoBehaviour, IClosable
{
	[SerializeField]
	private GameObject _resultItemPrefab;

	[SerializeField]
	private GameObject _resultItemDropdownPrefab;

	[SerializeField]
	private RectTransform _resultItemsRoot;

	[SerializeField]
	private ScrollRect _scrollRect;

	[SerializeField]
	private Text _descText;

	[SerializeField]
	private ConditionalGroup _descConditionals;

	private ResourceGacha _resGacha;

	public void Show(ResourceGacha resGacha)
	{
	}

	public void Show(List<(Reward reward, float probability)> rewards, string desc)
	{
	}

	private void Update()
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
