using System;
using UnityEngine;
using UnityEngine.UI;

public class NewChapterPanel : MonoBehaviour
{
	[ComponentConnect]
	public RectTransform newChallenge;

	public Image newChallengeEffect;

	public Text newChallengeText;

	public ConditionalImage newChallengeIcon;

	[ComponentConnect]
	public RectTransform newChapter;

	public Image newChapterEffect;

	public Text newChapterText;

	public ConditionalImage newChapterIcon;

	[ComponentConnect]
	public RectTransform newContent;

	public Image newContentEffect;

	public Text newContentText;

	public ConditionalImage newContentIcon;

	public CanvasGroup confirmButton;

	private bool _tutorialOpened;

	private int _chapter;

	private int _content;

	private Action _packagePopupCallback;

	public virtual void Show(int chapter, int content)
	{
	}

	public void Hide()
	{
	}
}
