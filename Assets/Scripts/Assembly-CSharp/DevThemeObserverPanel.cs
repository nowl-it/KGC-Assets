using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevThemeObserverPanel : MonoBehaviour
{
	public ScrollRect scrollRect;

	public GameObject itemObject;

	private List<GameObject> list;

	public InputField searchInput;

	private int _type;

	private InvasionBattleObserver _observer;

	private bool?[] _gimmickCompleted;

	private bool _init;

	public void Init()
	{
	}

	public void Reload()
	{
	}

	public void Show()
	{
	}

	public void OnClickClearSearch()
	{
	}

	public void OnChangeSearch()
	{
	}

	public void OnClickItem(int idx, bool close = true)
	{
	}

	private void SetSelected(int idx)
	{
	}

	private void Update()
	{
	}

	public void Close()
	{
	}
}
