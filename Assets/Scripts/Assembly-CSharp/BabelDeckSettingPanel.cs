using UnityEngine;
using UnityEngine.UI;

public class BabelDeckSettingPanel : DeckSettingPanel
{
	[SerializeField]
	private Text _deckAlertText;

	[SerializeField]
	private Button _presetButton;

	private int _babelId;

	private bool _clearOnClose;

	public void Show(int babelId)
	{
	}

	public override void Show()
	{
	}

	protected override BarrackInfo GetBarrack()
	{
		return null;
	}

	protected override void SetBarrack(BarrackInfo barrack)
	{
	}

	protected override bool FilterCard(CardData cardData)
	{
		return false;
	}

	public override void OnClickClose()
	{
	}

	public void OnClickConfirm()
	{
	}

	public override bool Close()
	{
		return false;
	}

	protected override int SortCard(CardData a, CardData b)
	{
		return 0;
	}
}
