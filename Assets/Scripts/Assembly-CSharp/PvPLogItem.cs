using Awesomepiece.Model;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PvPLogItem : MonoBehaviour
{
	public Text nameText;

	public Text scoreText;

	public PlayerProfile playerProfile;

	public Image tierIcon;

	public Image starIcon;

	public CardPreviewItem[] cardPreviewItems;

	public AltarPreviewItem[] altarPreviewItems;

	public ArtifactCraftSlot[] artifactSlots;

	public Text myScoreText;

	public Text enemyScoreText;

	public Image myGauge;

	public ConditionalRoot[] scoreItems;

	public GameObject content;

	[FormerlySerializedAs("logInfo")]
	[HideInInspector]
	public PvPLogResponseModel.PvPLogData logModel;

	public void Set(PvPLogResponseModel.PvPLogData model)
	{
	}

	private void ReloadGauge(int myScore, int enemyScore)
	{
	}
}
