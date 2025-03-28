using Awesomepiece.Model;
using UnityEngine.UI;

public class ClanSupportCompletePanel : PopupPanel, IComponentConnector
{
	[ComponentConnect]
	public Image unitImage;

	[ComponentConnect]
	public Text unitNameText;

	[ComponentConnect]
	public Image supportGauge;

	[ComponentConnect]
	public Text supportValueText;

	[ComponentConnect]
	public Text supportersText;

	public void Show(ClanSupportCompletedModel supportCompletedModel)
	{
	}

	[OnClick("OkButton", true)]
	public void OnClickConfirm()
	{
	}
}
