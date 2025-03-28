using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class GachaPanelOld : MonoBehaviour
{
	public Image shadow;

	public Image chest;

	public Image white;

	[ComponentConnect]
	public GachaCard unitCard;

	[ComponentConnect]
	public GachaCard unitExpCard;

	[ComponentConnect]
	public GachaCard goldCard;

	[ComponentConnect]
	public GachaCard cashCard;

	[ComponentConnect]
	public Text remainCountText;

	[ComponentConnect]
	public GameObject resultPanel;

	public GachaResultItem[] resultItems;

	private List<GachaResult> _datas;

	private List<GachaResult> _remains;

	private bool _boxOpened;

	private GachaCard _openedCard;

	private Action _onComplete;

	public void Show(GachaResultCollection datas, Action onComplete = null)
	{
	}

	public void Hide()
	{
	}

	public void OnClick()
	{
	}

	private void BoxOpen()
	{
	}

	private void ShowNextItem()
	{
	}

	private void ShowResult()
	{
	}
}
