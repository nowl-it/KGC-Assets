using System;
using UnityEngine;
using UnityEngine.UI;

public class ClanMarkPanel : MonoBehaviour, IClosable
{
	[ComponentConnect]
	public GridLayoutGroup layout;

	[ComponentConnect]
	public ClanMark markPrefab;

	private Action<int> _callback;

	private bool _inited;

	public void Awake()
	{
	}

	public void Show(Action<int> callback)
	{
	}

	private void Init()
	{
	}

	public void OnClickMark(ClanMark mark)
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
