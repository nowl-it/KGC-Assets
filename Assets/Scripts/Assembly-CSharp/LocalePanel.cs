using System;
using UnityEngine;
using UnityEngine.UI;

public class LocalePanel : MonoBehaviour
{
	private Action<Localizer.Locale> _callback;

	private Localizer.Locale _locale;

	public Button[] buttons;

	public void Show(Action<Localizer.Locale> callback)
	{
	}

	public void OnSelectLocale(int idx)
	{
	}
}
