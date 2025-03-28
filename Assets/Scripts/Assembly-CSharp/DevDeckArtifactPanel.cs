using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevDeckArtifactPanel : MonoBehaviour
{
	public ScrollRect scrollRect;

	public GameObject itemObject;

	private List<GameObject> list;

	public InputField searchInput;

	private List<ResourceArtifact> _allArtifacts;

	private bool _init;

	private int _idx;

	private DevDeckPanel _deckPanel => null;

	public void Init()
	{
	}

	public void Reload()
	{
	}

	public void Show(int idx)
	{
	}

	public void OnClickClearSearch()
	{
	}

	public void OnChangeSearch()
	{
	}

	public void OnClickItem(int id)
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
