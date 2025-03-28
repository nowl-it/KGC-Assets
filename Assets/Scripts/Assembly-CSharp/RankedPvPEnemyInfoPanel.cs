using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.UI;

public class RankedPvPEnemyInfoPanel : MonoBehaviour
{
	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public PlayerProfile myProfile;

	[ComponentConnect]
	public Text myNameText;

	[ComponentConnect]
	public LerpText myScoreText;

	[ComponentConnect]
	public Image myGauge;

	[ComponentConnect]
	public PlayerProfile enemyProfile;

	[ComponentConnect]
	public Text enemyNameText;

	[ComponentConnect]
	public LerpText enemyScoreText;

	[ComponentConnect]
	public GameObject scoreLayout;

	public ConditionalRoot[] scoreItems;

	public DeckPreviewPanel deckPreviewPanel;

	private bool _isSplash;

	private int _myScore;

	private int _lastStage;

	private bool _lastWin;

	private void ShowImpl(bool splash)
	{
	}

	public void Show(PvPDeckInfo info, bool splash = true)
	{
	}

	public void RegisterScore(int stage, bool win, int myScore)
	{
	}

	public void OnClickClose()
	{
	}

	private void ReloadGauge(int myScore, int enemyScore)
	{
	}
}
