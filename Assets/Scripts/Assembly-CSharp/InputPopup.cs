using System;
using UnityEngine;
using UnityEngine.UI;

public class InputPopup : MonoBehaviour, IClosable
{
	public Text contentText;

	public InputField inputField;

	private Action<bool, string> _callback;

	private int _minLength;

	private int _maxLength;

	private string _invalidLengthAlertText;

	public InputPopup Show(string text, Action<bool, string> callback)
	{
		return null;
	}

	public InputPopup SetDefaultText(string text)
	{
		return null;
	}

	public void SetMinMaxLength(int min, int max, string invalidLengthAlertText)
	{
	}

	public void OnClickOk()
	{
	}

	public void OnClickNo()
	{
	}

	public bool Close()
	{
		return false;
	}
}
