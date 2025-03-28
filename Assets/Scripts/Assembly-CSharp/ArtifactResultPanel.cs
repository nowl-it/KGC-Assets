using Awesomepiece.Model;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactResultPanel : MonoBehaviour
{
	[GetComponent]
	public RectTransform rectTransform;

	[GetComponent]
	public CanvasGroup canvasGroup;

	[ComponentConnect]
	public Text nameText;

	[ComponentConnect]
	public ArtifactCraftSlot artifactCraftSlot;

	public ArtifactOptionUI artifactOptionUI;

	public Image[] gradLines;

	[ComponentConnect]
	public Image effect;

	private Sequence _sequence;

	public void Show(ArtifactModel artifact)
	{
	}
}
