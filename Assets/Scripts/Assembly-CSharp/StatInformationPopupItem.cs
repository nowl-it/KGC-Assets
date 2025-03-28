using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatInformationPopupItem : MonoBehaviour
{
	public enum StatInfoCategory
	{
		AtkMain = 0,
		AtkSub = 1,
		Def = 2,
		Utility = 3
	}

	[SerializeField]
	private Image _statIcon;

	[SerializeField]
	private Text _statNameText;

	[SerializeField]
	private Text _statDescText;

	[SerializeField]
	private LayoutFitter _mainFitter;

	[SerializeField]
	private List<TextFitter> _textFitters;

	[SerializeField]
	private LayoutFitter _statNamesFitter;

	public StatInfoCategory statInfoCategory;

	public void Set(string pureStatName, StatInfoCategory category)
	{
	}
}
