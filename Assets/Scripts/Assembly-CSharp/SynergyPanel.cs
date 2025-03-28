using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SynergyPanel : MonoBehaviour
{
	[ComponentConnect]
	public Text noSynergy;

	[ComponentConnect]
	public GridLayoutGroup grid;

	[ComponentConnect]
	public SynergyInfoPanel synergyInfo;

	public SynergyItem synergyItemPrefab;

	private List<SynergyItem> _currentSynergies;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	private void Reload()
	{
	}

	private void OnClickSynergy(SynergyItem item)
	{
	}
}
