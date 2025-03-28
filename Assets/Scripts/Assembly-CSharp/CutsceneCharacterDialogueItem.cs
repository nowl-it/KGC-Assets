using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneCharacterDialogueItem : CutsceneDialogueItemBase
{
	[SerializeField]
	private Image _portraitImage;

	[SerializeField]
	private Image _portraitBackgroundImage;

	[SerializeField]
	private Text _nameText;

	[SerializeField]
	private RectTransform _dialogueBox;

	[SerializeField]
	private RectTransform _monologueBox;

	private Tween _focusOffTween;

	private readonly List<Graphic> _graphics;

	private List<Color> _graphicOriginColors;

	public CutscenePlayer.Character character { get; private set; }

	private void Awake()
	{
	}

	private void OnDisable()
	{
	}

	public override void Set(CutscenePlayer.Character character, string line)
	{
	}

	public void SetDialogue()
	{
	}

	public void SetMonologue()
	{
	}

	public override void HandleFocusOff()
	{
	}
}
