using UnityEngine.UI;

public class HqTreasureIllustPopup : TreasureIllust, IClosable
{
	public Text nameText;

	public Text subNameText;

	public Text descText;

	public TextFitter descTextFitter;

	public new void Set(int treasureId)
	{
	}

	public virtual void Show()
	{
	}

	public virtual void OnClickClose()
	{
	}

	public virtual bool Close()
	{
		return false;
	}
}
