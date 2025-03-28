using System;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class CutscenePlayer : MonoBehaviour
{
	public class Character
	{
		public readonly ResourceCutscene.Character data;

		public readonly CutsceneCharacter prefab;

		public CutsceneBalloon currentBalloon;

		public Character(ResourceCutscene.Character data, CutsceneCharacter prefab)
		{
		}
	}

	private static CutscenePlayer _instance;

	[SerializeField]
	private Canvas _canvas;

	[SerializeField]
	private CanvasGroup _dialoguePanel;

	[SerializeField]
	private RectTransform _dialoguesRoot;

	[SerializeField]
	private RectTransform _nextArrow;

	[SerializeField]
	private GameObjectPool _characterDialogueItemsPool;

	[SerializeField]
	private GameObjectPool _narrationItemsPool;

	[SerializeField]
	private GameObjectPool _balloonsPool;

	[SerializeField]
	private Button _skipButton;

	[SerializeField]
	private Image _blackMask;

	private CutsceneController _controller;

	private ResourceCutscene _resCutscene;

	private AudioObject _currentMusicObject;

	private AudioObject _originMusicObject;

	private readonly List<AudioObject> _sfxObjects;

	private Tween _addDialogueTween;

	private Tween _dialoguePanelShowTween;

	private Action _onCutsceneEnd;

	private float _dialoguesRootOriginY;

	private int _currentStep;

	private bool _isWaitingForClick;

	private readonly List<CutsceneDialogueItemBase> _dialogueItems;

	private Dictionary<string, Character> _charactersDict;

	public static CutscenePlayer Instance => null;

	public static bool isShowing => false;

	public bool isPlaying { get; private set; }

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void Show(ResourceCutscene resCutscene, Action onCutsceneEnd)
	{
	}

	private void DoFade(float startAlpha, float endAlpha, float time, TweenCallback onComplete)
	{
	}

	private void Update()
	{
	}

	private void SetCurrentStep(int step)
	{
	}

	public void MoveToNextStep()
	{
	}

	public void HandleCutsceneEnded()
	{
	}

	public void PlayMusic(string key, float fadeOut, float fadeIn)
	{
	}

	public void PlaySound(string key)
	{
	}

	public CutsceneCharacterDialogueItem GetCharacterDialogueItem()
	{
		return null;
	}

	public CutsceneNarrationItem GetNarrationItem()
	{
		return null;
	}

	public void AddDialogueItem(CutsceneDialogueItemBase item)
	{
	}

	private void ReturnDialogueItem(int dialogueItemIndex)
	{
	}

	public CutsceneBalloon AddBalloon(Character character)
	{
		return null;
	}

	private void HideBalloon(Character character)
	{
	}

	public void WaitForClick()
	{
	}

	public void ResumeAnimation()
	{
	}

	public Character GetCharacter(string key)
	{
		return null;
	}

	public void SetDialoguePanelVisible(bool show)
	{
	}

	public void Close()
	{
	}

	public void OnClickScreen()
	{
	}

	public void OnClickSkip()
	{
	}
}
