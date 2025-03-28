using System;
using System.Collections.Generic;
using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactSelectAmountPanel : MonoBehaviour, IComponentConnector, IClosable
{
	[ComponentConnect]
	public Image iconImage;

	[ComponentConnect]
	public Image frameImage;

	[ComponentConnect]
	public Text countText;

	[ComponentConnect]
	public InputField amountField;

	private ArtifactModel _artifact;

	private List<ArtifactModel> _artifacts;

	private int _amount;

	private Action<int> _callback;

	public void Show(ArtifactModel artifact, Action<int> callback)
	{
	}

	public void ShowByList(List<ArtifactModel> artifacts, Action<int> callback)
	{
	}

	[OnClick("ConfirmButton", true)]
	public void OnClickConfirm()
	{
	}

	[OnClick("CancelButton", true)]
	public void OnClickCancel()
	{
	}

	[OnClick("PlusButton", true)]
	public void OnClickPlus()
	{
	}

	[OnClick("MinusButton", true)]
	public void OnClickMinus()
	{
	}

	private void ChangeAmount(int delta)
	{
	}

	public void OnEditAmount()
	{
	}

	public void OnEndEdit()
	{
	}

	public bool Close()
	{
		return false;
	}
}
